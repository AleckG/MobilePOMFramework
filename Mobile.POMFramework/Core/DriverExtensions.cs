using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Mobile.POMFramework.Pages.Android;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Mobile.POMFramework.Core
{
    public static class DriverExtensions
    {
        /// <summary>
        /// Checks if element is present and if not, waits specified number of second
        /// in timeout parameter. Default is 10.
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="elementLocator"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static IWebElement WaitUntilElementPresent(this IWebDriver webDriver, By elementLocator, int timeout = 10)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeout));
            IWebElement waitOnElement = null;
            try
            {
                waitOnElement = wait.Until(ExpectedConditions.ElementExists(elementLocator));
            }
            catch (UnhandledAlertException)
            {
                webDriver.SwitchTo().Alert().Dismiss();
            }
            catch (NoAlertPresentException)
            {
                // ignore this exception
            }
            catch (StaleElementReferenceException e)
            {
                Console.WriteLine("Element is no longer valid", e);
            }
            return waitOnElement;
        }


        public static bool IsElementDisplayed(this IWebDriver webDriver, By elementLocator)
        {
            return webDriver.FindElements(elementLocator).Count > 0 && webDriver.FindElement(elementLocator).Displayed;
        }

        public static bool IsElementEnabled(this IWebDriver webDriver, By elementLocator)
        {
            return webDriver.FindElements(elementLocator).Count > 0 && webDriver.FindElement(elementLocator).Enabled;
        }

        public static bool IsElementAvailable(this IWebDriver driver, IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        public static bool ExpectedPage(this IWebDriver driver, string titleExpected)
        {
            return driver.Title.Equals(titleExpected);
        }

        //public static LandingPage Login(this IWebDriver driver, string username, string password)
        //{
        //    var instanceSelection = new InstanceSelection(driver);
        //    LoginPage loginPage = instanceSelection.SetInstance(Settings.App.Default.instanceName, Settings.App.Default.environment);
        //    LandingPage landingPage = loginPage.LogIn(username, password);
        //    return landingPage;
        //}
    }
}
