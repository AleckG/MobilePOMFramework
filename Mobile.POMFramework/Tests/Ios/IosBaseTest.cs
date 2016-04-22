using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile.POMFramework.Core;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;

namespace Mobile.POMFramework.Tests.Ios
{
    [TestClass]
    public class IosBaseTest : TestBase
    {
        [TestInitialize]
        public override void BeforeAll()
        {
            TestMobileCapabilities = new MobileCapabilities(DeviceType.Ios);
            TestServerUri = new Uri(Settings.iOS.Default.uri);
            WebDriver = new IOSDriver<AppiumWebElement>(TestServerUri, TestMobileCapabilities);
        }
    }
}
