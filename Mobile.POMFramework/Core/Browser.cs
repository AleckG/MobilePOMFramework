using OpenQA.Selenium;

namespace Mobile.POMFramework.Core
{
    public static class Browser
    {
        public static IWebDriver WebDriver { get; }

        #region Internal Methods and properties

        internal static string Title => WebDriver.Title;
        internal static string PageSource => WebDriver.PageSource;

        #endregion

    }
}
