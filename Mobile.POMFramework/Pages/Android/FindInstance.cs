using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Pages.Android
{
    public class FindInstance
    {
        private readonly IWebDriver driver;

        #region Page Elements
        [FindsBy(How = How.Id, Using = "login_instance_information_message_text_view")]
        private IWebElement InfoMessage { get; set; }
        #endregion

        public FindInstance(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        public bool VerifyInfoMessage()
        {
            return InfoMessage.Text.StartsWith("The instance name");
        }
    }
}
