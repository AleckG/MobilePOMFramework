using Mobile.POMFramework.Core;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Pages.Android
{
    public class PasswordConfirmation
    {
        private readonly IWebDriver driver;

        public PasswordConfirmation(IWebDriver driver)
        {
            this.driver = driver;
        }

        [FindsBy(How = How.Id, Using = "login_back_to_sign_in_button")]
        private IWebElement BackToSignInButton { get; }

        public LoginPage BackToSignIn()
        {
            if (driver.IsElementAvailable(BackToSignInButton))
            {
                BackToSignInButton.Click();
            }
            LoginPage loginPage = new LoginPage(driver);
            PageFactory.InitElements(driver, loginPage);
            return loginPage;
        }
    }
}