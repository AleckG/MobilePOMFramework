using Mobile.POMFramework.Core;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Pages.Ios
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.Id, Using = "idTextField_UserName")]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "idTextField_Password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "idButton_LogIn")]
        private IWebElement LoginButton { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LandingPage LogIn(string user, string pass)
        {
            PageFactory.InitElements(driver, this);
            if (driver.IsElementAvailable(UserName))
            {
                UserName.SendKeys(user);
            }
            if (driver.IsElementAvailable(Password))
            {
                Password.SendKeys(pass);
            }
            if (driver.IsElementAvailable(LoginButton))
            {
                LoginButton.Click();
            }
            LandingPage landingPage = new LandingPage(driver);
            PageFactory.InitElements(driver, landingPage);
            return landingPage;
        }

    }
}
