using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Pages.Android
{
    public class CertificationStatusFilter
    {
        //private readonly IWebDriver driver;

        [FindsBy(How = How.Id, Using = "filter_all_text_view")]
        private IWebElement FilterAllButton { get; }

        [FindsBy(How = How.Id, Using = "filter_prepared_text_view")]
        private IWebElement FilterPreparedButton { get; }

        [FindsBy(How = How.Id, Using = "filter_approved_text_view")]
        private IWebElement FilterApprovedButton { get; }
    }
}
