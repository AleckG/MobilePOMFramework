using Mobile.POMFramework.Core;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Pages.Android
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        #region Page Elements
        [FindsBy(How = How.Id, Using = "login_id_edit_text")]
        private IWebElement LoginId { get; set; }

        [FindsBy(How = How.Id, Using = "login_password_edit_text")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login_sign_in_button")]
        private IWebElement SignInButton { get; set; }
        #endregion

        public LoginPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        public LandingPage LogIn(string user, string password)
        {
            LoginId.Clear();
            LoginId.SendKeys(user);
            
            Password.Clear();
            Password.SendKeys(password);

            SignInButton.Click();

            return new LandingPage(driver);
        }
    }
}
