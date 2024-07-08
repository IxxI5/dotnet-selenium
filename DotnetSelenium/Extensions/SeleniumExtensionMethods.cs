using OpenQA.Selenium;

namespace DotnetSelenium
{
    public static class SeleniumExtensionMethods
    {
        /// <summary>
        /// Method similar to Click that extends the Selenium class.
        /// </summary>
        /// <param name="locator"></param>
        public static void SubmitSEM(this IWebElement locator)
        {
            locator.Click();
        }

        /// <summary>
        /// Method similar to SendKeys that extends the Selenium class.
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="text"></param>
        public static void EnterTextSEM(this IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }
    }
}
