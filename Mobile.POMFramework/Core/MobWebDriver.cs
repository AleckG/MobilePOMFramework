using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;

namespace Mobile.POMFramework.Core
{
    // Wrapper class for both iOS and Android.
    public class MobWebDriver : AppiumDriver
    {
        private AppiumDriver driver;

        public MobWebDriver(DeviceType deviceType, MobileCapabilities testMobileCapabilities, Uri testServerUri)
            : base(testServerUri,testMobileCapabilities)
        {
            switch (deviceType)
            {
                case DeviceType.Ios:
                    {
                        driver = new IOSDriver(testServerUri, testMobileCapabilities);
                        break;
                    }

                case DeviceType.Android:
                    {
                        driver = new AndroidDriver(testServerUri, testMobileCapabilities);
                        break;
                    }
            }
        }
    }
}
