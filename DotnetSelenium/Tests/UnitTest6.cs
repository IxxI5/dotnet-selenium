using DotnetSelenium.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotnetSelenium.Tests
{
    [TestFixture("admin", "password")]
    [Author("IxxI5")]
    [Category("general")]
    public class UnitTest6
    {
        /// <summary>
        /// WebDriver Instance Field. Holds and makes available the instance of the WebDriver within the UnitTest6 class.
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// LoginPageRefactored Instance Field. Holds and makes available the instance of the LoginPage within the UnitTest6 class.
        /// </summary>
        private LoginPage loginPage;

        /// <summary>
        /// Field. Holds and makes available its value within the UnitTest6 class.
        /// </summary>
        private readonly string username;

        /// <summary>
        /// Field. Holds and makes available its value within the UnitTest6 class.
        /// </summary>
        private readonly string password;

        /// <summary>
        /// Constructor | Sets the username and password to the values provided by the TestFixture
        /// [TestFixture("admin", "password")]
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public UnitTest6(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        /* Set the Initial Conditions for all subsequent Tests (Test1, Test2, etc):
         * 1. Instantiate the ChromeDriver
         * 2. Apply an ImplicitWait (Timeout with a polling interval of 500 msec (default)) for all elements globally.
         *    It is the amount of time the driver should wait when searching for an element if it is not immediately present.
         * 3. Navigate to the target URL: http://eaapp.somee.com/
         * 4. Maximize the driver (browser) window
         * 5. Instantiate the Page Object Model -> LoginPage
         */
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();

            loginPage = new LoginPage(driver);
        }

        /* EA Website Test using the Page Object Model
         * 1. Click on Log in Link
         * 2. Login (Sign In) with the credentials provided by the [TestFixture("admin", "password")]
         * 3. Assert IF Tag.ManageUsers Web element is Displayed
         */
        [Test]
        public void Test1()
        {
            /* Act */

            loginPage.ClickLogin();
            loginPage.Login(username, password);

            /* Assert */

            loginPage.IsLoggedIn().Should().BeTrue();

            Console.WriteLine("UnitTest6.Test1() completed.");
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
