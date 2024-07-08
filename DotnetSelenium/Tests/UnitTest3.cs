using DotnetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotnetSelenium.Tests
{
    [TestFixture("admin", "password")]
    [Author("IxxI5")]
    [Category("general")]
    public class UnitTest3
    {
        /// <summary>
        /// WebDriver Instance Field. Holds and makes available the instance of the WebDriver within the UnitTest3 class.
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// LoginPage Instance Field. Holds and makes available the instance of the LoginPage within the UnitTest3 class.
        /// </summary>
        private LoginPage loginPage;

        /// <summary>
        /// Field. Holds and makes available its value within the UnitTest3 class.
        /// </summary>
        private readonly string username;

        /// <summary>
        /// Field. Holds and makes available its value within the UnitTest3 class.
        /// </summary>
        private readonly string password;

        /// <summary>
        /// Constructor | Sets the username and password to the values provided by the TestFixture.
        /// [TestFixture("admin", "password")]
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public UnitTest3(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        /* Set the Initial Conditions for all subsequent Tests (Test1, Test2, etc):
         * 1. Instantiate the ChromeDriver
         * 2. Navigate to the target URL: http://eaapp.somee.com/
         * 3. Maximize the driver (browser) window
         * 4. Instantiate the Page Object Model -> LoginPage
         */
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();

            loginPage = new LoginPage(driver);
        }

        /* EA Website Test using the Page Object Model
         * 1. Click on Log in Link
         * 2. Login (Sign In) with the credentials provided by the [TestFixture("admin", "password")]
         */
        [Test]
        public void Test1()
        {
            loginPage.ClickLogin();
            loginPage.Login(username, password);

            Console.WriteLine("UnitTest3.Test1() completed.");
        }

        /* EA Website Test using the Page Object Model
         * 1. Click on Log in Link
         * 2. Login (Sign In) with the credentials provided by the [TestFixture("admin", "password")]
         * 3. Write to the Standard Output 
         */
        [Test]
        [Author("Tester")]
        [Category("smoke")]
        [TestCase("Chrome", "126")]
        public void Test2(string driverName, string driverVersion)
        {
            loginPage.ClickLogin();
            loginPage.Login(username, password);

            Console.WriteLine($"The Web Browser name is {driverName} and its version is {driverVersion}.0.0.0");

            Console.WriteLine("UnitTest3.Test2() completed.");

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
