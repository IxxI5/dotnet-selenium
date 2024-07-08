using DotnetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotnetSelenium.Tests
{
    public class UnitTest2
    {
        /// <summary>
        /// WebDriver Instance Field. Holds and makes available the instance of the WebDriver within the UnitTest2 class.
        /// </summary>
        private IWebDriver driver;

        /* Set the Initial Conditions for all subsequent Tests (Test1, Test2, etc):
         * 1. Instantiate the ChromeDriver
         * 2. Navigate to the target URL: http://eaapp.somee.com/
         * 3. Maximize the driver (browser) window
         */
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();
        }

        /* EA Website Test using the Page Object Model
         * 1. Instantiate the LoginPage (Page Object Model)
         * 2. Click on Log in Link
         * 3. Login (Sign In) with the credentials "admin" and "password"
         */
        [Test]
        public void Test1()
        {
            /* Instantiate the Page Object Model -> LoginPage */
            LoginPage loginPage = new LoginPage(driver);

            loginPage.ClickLogin();
            loginPage.Login("admin", "password");

            Console.WriteLine("UnitTest2.Test1() completed.");
        }

        /* Dispose Resources on Each Test Run e.g. Test1, Test2, etc.
         * 1. Wait 1000 msec
         * 2. Dispose the WebDriver (driver)
         * e.g. On Test1 completion, the driver (Browser) will be disposed (and automatically closed)
         */
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(1000);

            driver.Dispose();
        }
    }
}
