using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Mobile.POMFramework.Pages.Android
{
    public class UserProfile
    {
        [FindsBy(How = How.Id, Using = "user_profile_full_name_text_view")]
        private IWebElement UserProfileFullName { get; }

        [FindsBy(How = How.Id, Using = "user_profile_products_text_view")]
        private IWebElement UserProfileProducts{ get; }

    }
}
