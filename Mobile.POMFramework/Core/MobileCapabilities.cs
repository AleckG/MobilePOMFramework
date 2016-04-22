using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;

namespace Mobile.POMFramework.Core
{
    public class MobileCapabilities : DesiredCapabilities
    {
        public MobileCapabilities(DeviceType deviceType)
        {
            switch (deviceType)
            {
                case DeviceType.Ios:
                {
                    SetCapability(MobileCapabilityType.DeviceName, Settings.iOS.Default.deviceName);
                    SetCapability(MobileCapabilityType.PlatformVersion, Settings.iOS.Default.platformVersion);
                    SetCapability(MobileCapabilityType.PlatformName, Settings.iOS.Default.platformName);
                    break;
                }

                case DeviceType.Android:
                {
                    SetCapability(MobileCapabilityType.DeviceName, Settings.Android.Default.deviceName);
                    SetCapability(MobileCapabilityType.PlatformVersion, Settings.Android.Default.platformVersion);
                    SetCapability(MobileCapabilityType.PlatformName, Settings.Android.Default.platformName);
                    break;
                }
            }
        }
    }
}
