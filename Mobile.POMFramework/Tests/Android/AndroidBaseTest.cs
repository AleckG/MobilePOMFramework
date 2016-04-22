using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile.POMFramework.Core;
using Mobile.POMFramework.Pages.Android;

using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Mobile.POMFramework.Tests.Android
{
    [TestClass]
    public class AndroidBaseTest : TestBase
    {
       
        [TestInitialize]
        public override void BeforeAll()
        {
            TestMobileCapabilities = new MobileCapabilities(DeviceType.Android);
            TestServerUri = new Uri(Settings.Android.Default.uri);
            WebDriver = new AndroidDriver<AppiumWebElement>(TestServerUri, TestMobileCapabilities);
            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(Settings.App.Default.MaxPageElementWaitTimeSeconds));
        }

        public LandingPage Login( IWebDriver driver, string username, string password)
        {
            var instanceSelection = new InstanceSelection(driver);
            LoginPage loginPage = instanceSelection.SetInstance(Settings.App.Default.instanceName, Settings.App.Default.environment);
            LandingPage landingPage = loginPage.LogIn(username, password);
            return landingPage;
        }
    }
}
