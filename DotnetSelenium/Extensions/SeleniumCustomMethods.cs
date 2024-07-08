using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Reflection.Metadata;

namespace DotnetSelenium
{
    public class SeleniumCustomMethods
    {
        /* IWebDriver Actions. 
         * Based on the parameter (WebDrive instance) IWebDriver driver. */

        /// <summary>
        /// Click | Custom Method
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        public static void Click(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Click();
        }

        /// <summary>
        /// EnterText | Custom Method
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        /// <param name="text"></param>
        public static void EnterText(IWebDriver driver, By locator, string text) 
        {
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);
        }

        /// <summary>
        /// SelectDropDown | Custom Method
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        /// <param name="dropDownsIndex"></param>
        /// <param name="optionIndex"></param>
        public static void SelectDropDown(IWebDriver driver, By locator, int dropDownsIndex, int optionIndex)
        {
            IList<IWebElement> dropDowns = driver.FindElements(locator);

            if (dropDowns.Count > 0)
            {
                IWebElement dropDown = dropDowns[dropDownsIndex];

                SelectElement selectElement = new SelectElement(dropDown);
                string selectOptionText = selectElement.Options[optionIndex].Text;
                selectElement.SelectByIndex(optionIndex);

                Console.WriteLine("Available Options");
                Console.WriteLine("-----------------");

                foreach (var item in selectElement.Options)
                {
                    Console.WriteLine(item.Text);    
                }

                Console.WriteLine();
                Console.WriteLine($"Selected Dropdown = Dropdowns[{dropDownsIndex}] | Option: {selectOptionText}");

            }
            else
            {
                Console.WriteLine("No dropdown elements found.");
            }
        }

        /* IWebElement Actions. This is an alternative approach that results in reducing the method parameters, 
         * especially by removing the parameter IWebDriver driver. */

        /// <summary>
        /// Click | Custom Method
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="text"></param>
        public static void Click(IWebElement locator)
        {
            locator.Click();
        }

        /// <summary>
        /// EnterText | Custom Method
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="text"></param>
        public static void EnterText(IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }

        /// <summary>
        /// SelectDropDown | Custom Method
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="dropDownsIndex"></param>
        /// <param name="optionIndex"></param>
        public static void SelectDropDown(IWebElement locator, int dropDownsIndex, int optionIndex)
        {
            IList<IWebElement> dropDowns = (IList<IWebElement>)locator;

            if (dropDowns.Count > 0)
            {
                IWebElement dropDown = dropDowns[dropDownsIndex];

                SelectElement selectElement = new SelectElement(dropDown);
                string selectOptionText = selectElement.Options[optionIndex].Text;
                selectElement.SelectByIndex(optionIndex);

                Console.WriteLine("Available Options");
                Console.WriteLine("-----------------");

                foreach (var item in selectElement.Options)
                {
                    Console.WriteLine(item.Text);
                }

                Console.WriteLine();
                Console.WriteLine($"Selected Dropdown = Dropdowns[{dropDownsIndex}] | Option: {selectOptionText}");

            }
            else
            {
                Console.WriteLine("No dropdown elements found.");
            }
        }
    }
}
