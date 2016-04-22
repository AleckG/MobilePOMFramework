using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Pages.Android
{
    public class PeriodSelection
    {
        private const string PageTitle = "Period Selection";

        [FindsBy(How = How.Id, Using = "period_selection_selected_period")]
        private IWebElement SelectedPeriod { get; }





    }
}
