using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Mobile.POMFramework.Core;
using Mobile.POMFramework.Tests.Android;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

using Selenium.WebDriver.Extensions.Core;

using By = OpenQA.Selenium.By;

namespace Mobile.POMFramework.Pages.Android
{
    public class InstanceSelection
    {
        private readonly IWebDriver driver;

        public InstanceSelection(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);

        }
        #region Page Elements
        [FindsBy(How = How.Id, Using = "login_instance_edit_text")]
        private IWebElement LoginInstanceName { get; set; }

        [FindsBy(How = How.Id, Using = "login_environment_text_view")]
        private IWebElement LoginEnvironment { get; set; }

        [FindsBy(How = How.Id, Using = "select_dialog_listview")]
        private IWebElement SelectEnvironmentList { get; set; }


        [FindsBy(How = How.Id, Using = "login_save_button")]
        private IWebElement SaveButton { get; set; }

        [FindsBy(How = How.Id, Using = "login_find_instance_text_view")]
        private IWebElement FindInstanceLink { get; set; }

        [FindsBy(How = How.Id, Using = "instance_selection_page_title")]
        private IWebElement PageTitle { get; set; }
        #endregion

        
        public LoginPage SetInstance(string instance, string environment)
        {
            LoginInstanceName.SendKeys(instance);
            
            LoginEnvironment.Click();

            if (driver.IsElementAvailable(SelectEnvironmentList))
            {
                List<IWebElement> dropList = new List<IWebElement>(SelectEnvironmentList.FindElements(By.ClassName("android.widget.TextView")));
                
                foreach (IWebElement option in dropList)
                {
                    if (option.Text.Equals(environment))
                    {
                        option.Click();
                        break;
                    }
                }
            }
            SaveButton.Click();
           
            LoginPage loginPage = new LoginPage(driver);
            PageFactory.InitElements(driver, loginPage);
            return loginPage;
        }

        public void FindInstance()
        {
            FindInstanceLink.Click();
        }
    }
}
