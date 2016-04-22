using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mobile.POMFramework.Core;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Pages.Android
{
    public class PasswordReset
    {
        private readonly IWebDriver driver;

        public PasswordReset(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy (How = How.Id, Using = "login_reset_password_edit_text")]
        private IWebElement LoginId { get; }

        [FindsBy (How = How.Id, Using = "'login_reset_password_button")]
        private IWebElement ResetPasswordButton { get; }

        public PasswordConfirmation ResetPassword(string loginId)
        {
            if (driver.IsElementAvailable(LoginId))
            {
                LoginId.Clear();
                LoginId.SendKeys(loginId);
            }
            if (driver.IsElementAvailable(ResetPasswordButton))
            {
                ResetPasswordButton.Click();
            }
            PasswordConfirmation passwordConfirmation = new PasswordConfirmation(driver);
            PageFactory.InitElements(driver, passwordConfirmation);
            return passwordConfirmation;
        }
    }
}
