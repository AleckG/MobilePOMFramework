using System.Reflection;

using log4net;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile.POMFramework.Pages.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Tests.Android
{
    public class AndroidTestLibrary : AndroidBaseTest
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void FindInstance()
        {
            Log.Info("Start Find Instance Test");
            var instanceSelection = new InstanceSelection(WebDriver);
            PageFactory.InitElements(WebDriver, instanceSelection);
            instanceSelection.FindInstance();

            var findInstancePage = new FindInstance(WebDriver);
            PageFactory.InitElements(WebDriver, findInstancePage);

            Assert.IsInstanceOfType(findInstancePage, typeof(FindInstance), $"Invalid page returned from factory. {this.GetType()}");
            Assert.IsTrue(findInstancePage.VerifyInfoMessage(), "Instance Information message isn't found.");
            WebDriver.Navigate().Back();
        }

        public void InstanceTest()
        {
            Log.Info("Start Instance Test");
            var instanceSelection = new InstanceSelection(WebDriver);
            PageFactory.InitElements(WebDriver, instanceSelection);
            
            // Verify we're on the right page.
            Assert.IsInstanceOfType(instanceSelection, typeof(InstanceSelection), $"Invalid page return from factory. {this.GetType()}");
            instanceSelection.SetInstance("test1", "Internal - DCI2");
         
        }

        public void LoginTest()
        {
            Log.Info("Start Login Test");
            var loginPage = new LoginPage(WebDriver);

            PageFactory.InitElements(WebDriver, loginPage);
            var landingPage = loginPage.LogIn(Settings.App.Default.ValidUserName, Settings.App.Default.ValidPassword);
            Assert.IsInstanceOfType(landingPage, typeof(LandingPage), $"Invalid page returned from factory. {this.GetType()}");
            Log.Fatal("Invalid page returned from factory");
        }
    }
}
