using DotnetSelenium.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotnetSelenium.Tests
{
    [TestFixture("admin", "password")]
    [Author("IxxI5")]
    [Category("general")]
    public class UnitTest5
    {
        /// <summary>
        /// WebDriver Instance Field. Holds and makes available the instance of the WebDriver within the UnitTest5 class.
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// LoginPageRefactored Instance Field. Holds and makes available the instance of the LoginPage within the UnitTest5 class.
        /// </summary>
        private LoginPageRefactored loginPage;

        /// <summary>
        /// Field. Holds and makes available its value within the UnitTest5 class.
        /// </summary>
        private readonly string username;

        /// <summary>
        /// Field. Holds and makes available its value within the UnitTest5 class.
        /// </summary>
        private readonly string password;

        /// <summary>
        /// Constructor | Sets the username and password to the values provided by the TestFixture
        /// [TestFixture("admin", "password")]
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public UnitTest5(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        /* Set the Initial Conditions for all subsequent Tests (Test1, Test2, etc):
         * 1. Instantiate the ChromeDriver
         * 2. Navigate to the target URL: http://eaapp.somee.com/
         * 3. Maximize the driver (browser) window
         * 4. Instantiate the Page Object Model -> LoginPageRefactored
         */
        [SetUp]
        public void SetUp()
        {
            /* Set Selenium to Headless Mode (no Browser in Ubuntu) as required in CI with GitHub */
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless=new");

            driver = new ChromeDriver(chromeOptions);

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();

            loginPage = new LoginPageRefactored(driver);
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

            Console.WriteLine("UnitTest5.Test1() completed.");
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
