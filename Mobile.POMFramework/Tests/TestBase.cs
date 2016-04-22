using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile.POMFramework.Core;
using OpenQA.Selenium;

namespace Mobile.POMFramework.Tests
{
    public abstract class TestBase
    {
        protected IWebDriver WebDriver { get; set; }

        protected Uri TestServerUri { get; set; }
        protected MobileCapabilities TestMobileCapabilities { get; set; }

        public abstract void BeforeAll();
        
        public void AfterAll() => WebDriver?.Quit();
    }
}
