using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using log4net;

using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Pages.Android
{
    public class LandingPage
    {
       private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    
        #region Page Elements
        // Landing page elements
        [FindsBy(How = How.Id, Using = "search_button")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "search_src_text")]
        private IWebElement SearchText { get; set; }
        
        [FindsBy(How = How.Id, Using = "action_profile")]
        private IWebElement ActionProfile { get; set; }

        [FindsBy(How = How.Id, Using = "account_settings_period_text_view")]
        private IWebElement AccountSettingsPeriod { get; set; }

        [FindsBy(How = How.Id, Using = "account_settings_data_views_text_view")]
        private IWebElement AccountSettingsDataViews {get; set; }

        [FindsBy(How = How.Id, Using = "filter_all_text_view")]
        private IWebElement FilterAllButton { get; set; }

        [FindsBy(How = How.Id, Using = "filter_prepared_text_view")]
        private IWebElement FilterPreparedButton { get; set; }

        [FindsBy(How = How.Id, Using = "filter_approved_text_view")]
        private IWebElement FilterApprovedButton { get; set; }

        [FindsBy(How = How.Id, Using = "key_filter_tab_layout")]
        private IWebElement KeyFilterTab { get; set; }

        [FindsBy(How = How.Name, Using = "All")]
        private IWebElement KeyFilterTabAll { get; set; }

        [FindsBy(How = How.Name, Using = "Key")]
        private IWebElement KeyFilterTabKey { get; set; }

        [FindsBy(How = How.Name, Using = "Non-Key")]
        private IWebElement KeyFilterTabKeyNonKey { get; set; }

        #endregion
        #region Reconciliations controls

        [FindsBy(How = How.Id, Using = "home_item_account_name_text_view")]
        private IWebElement ItemAccountName { get; set; }

        [FindsBy(How = How.Id, Using = "home_item_bank_balance_text_view")]
        private IWebElement ItemBankBalance { get; set; }

        [FindsBy(How = How.Id, Using = "home_item_risk_text_view")]
        private IWebElement ItemRisk { get; set; }

        [FindsBy(How = How.Id, Using = "home_item_key_text_view")]
        private IWebElement ItemKey { get; set; }

        [FindsBy(How = How.Id, Using = "home_item_description_name_text_view")]
        private IWebElement ItemDescription { get; set; }

        [FindsBy(How = How.Id, Using = "home_item_gl_balance_text_view")]
        private IWebElement ItemGlBalance { get; set; }

        #endregion


        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public LandingPage(IWebDriver driver)
        {
            Log.Info("Initialize Landing Page");
            PageFactory.InitElements(driver, this);
        }

        public bool IsSearchPresent()
        {
            return SearchButton.Displayed;
        }
    }
}
