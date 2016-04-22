using System;
using System.Reflection;

using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile.POMFramework.Pages.Ios;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Tests.Ios
{
    [TestClass]
    public class IosLoginTest : IosBaseTest
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void LoginTest()
        {
            Log.Info("Start Login Test");
            var loginPage = PageFactory.InitElements<LoginPage>(WebDriver);
            var landingPage = loginPage.LogIn("UserName", "123456");
            Assert.IsInstanceOfType(landingPage, typeof(LandingPage), "Invalid page returned from factory");
            Log.Fatal("Invalid page returned from factory");
        }
        

    }
}
