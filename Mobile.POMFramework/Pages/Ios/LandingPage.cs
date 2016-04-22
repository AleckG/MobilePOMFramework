using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Pages.Ios
{
    public class LandingPage
    {
        private const string PageTitle = "Landing Page";
        /// TODO: Once landing page is available add page controls here
        
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public LandingPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
