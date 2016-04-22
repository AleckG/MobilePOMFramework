using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mobile.POMFramework.Core;
using Mobile.POMFramework.Pages.Android;

using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Mobile.POMFramework.Tests.Android
{
    [TestFixture()]
    public class NunitTest
    {
        private IWebDriver webDriver;
        
        private Uri TestServerUri { get; set; }
        private MobileCapabilities TestMobileCapabilities { get; set; }

        [SetUp]
        public void Init()
        {
            TestMobileCapabilities = new MobileCapabilities(DeviceType.Android);
            TestServerUri = new Uri(Settings.Android.Default.uri);
            webDriver = new AndroidDriver<AppiumWebElement>(TestServerUri, TestMobileCapabilities);
        }

        [Test]
        public void Test_1()
        {
            var instanceSelection = new InstanceSelection(webDriver);
            PageFactory.InitElements(webDriver, instanceSelection);
            instanceSelection.FindInstance();

            var findInstancePage = new FindInstance(webDriver);
            PageFactory.InitElements(webDriver, findInstancePage);

            Assert.IsInstanceOfType(findInstancePage, typeof(FindInstance), $"Invalid page returned from factory. {GetType()}");
            Assert.IsTrue(findInstancePage.VerifyInfoMessage(), "Instance Information message isn't found.");
            webDriver.Navigate().Back();
       
            // Verify we're on the right page.
            Assert.IsInstanceOfType(instanceSelection, typeof(InstanceSelection), $"Invalid page return from factory. {GetType()}");
            instanceSelection.SetInstance("test1", "Internal - DCI2");
            var loginPage = new LoginPage(webDriver);

            PageFactory.InitElements(webDriver, loginPage);
            LandingPage landingPage = loginPage.LogIn(Settings.App.Default.ValidUserName, Settings.App.Default.ValidPassword);
            Assert.IsInstanceOfType(landingPage, typeof(LandingPage), $"Invalid page returned from factory. {GetType()}");
            
        }

        [TearDown]
        public void Cleanup()
        {
            webDriver.Quit();
        }
    }
}
