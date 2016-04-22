using System;
using System.Diagnostics;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Mobile.POMFramework.Core;
using Mobile.POMFramework.Pages.Android;

using OpenQA.Selenium;

namespace Mobile.POMFramework.Tests.Android
{
    [TestClass]
    public class LoginTests : AndroidBaseTest
    {
        [TestMethod]
        [Description("C525262. Login successful")]
        public void LoginSuccess()
        {
            var landingPage = Login(WebDriver, Settings.App.Default.ValidUserName, Settings.App.Default.ValidPassword);
        }

        [TestMethod]
        [Description(("C525263. Login unsuccessful - Invalid user id"))]
        public void LoginWithInvalidUser()
        {
            var landingPage = Login(WebDriver, Settings.App.Default.InvalidUserName, Settings.App.Default.ValidPassword);
            try
            {
                Assert.IsTrue(landingPage.IsSearchPresent());
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Login failed. Invalid username or password.");
                throw new AssertFailedException();
            }
            
        }

        [TestMethod]
        [Description("C525264. Login unsuccessful - Invalid password")]
        public void LoginWithInvalidPassword()
        {
            var landingPage = Login(WebDriver, Settings.App.Default.ValidUserName, Settings.App.Default.InvalidPassword);
            try
            {
                Assert.IsTrue(landingPage.IsSearchPresent());
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Login failed. Invalid username or password.");
                throw new AssertFailedException();
            }
        }

    }
}
