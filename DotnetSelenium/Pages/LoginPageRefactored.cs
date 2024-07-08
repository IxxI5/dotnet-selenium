using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium.Pages
{
    public class Tag
    {
        /// <summary>
        /// LoginLink Tag String
        /// </summary>
        public static string LinkLogin => "loginLink";

        /// <summary>
        /// UserName Tag String
        /// </summary>
        public static string UserName => "UserName";

        /// <summary>
        /// Password Tag String
        /// </summary>
        public static string Password => "Password";

        /// <summary>
        /// DotBtn Tag String
        /// </summary>
        public static string DotBtn => ".btn";

        /// <summary>
        /// EmployeeDetails Tag String
        /// </summary>
        public static string EmployeeDetails => "Employee Details";

        /// <summary>
        /// ManageUsers Tag String
        /// </summary>
        public static string ManageUsers => "Manage Users";
    }

    public class LoginPageRefactored
    {
        /// <summary>
        /// WebDriver Instance Field.
        /// Holds and makes available the instance of the WebDriver within the LoginPage class
        /// </summary>
        private readonly IWebDriver driver;

        /// <summary>
        /// WebDriverWait Instance Field.
        /// </summary>
        public WebDriverWait driverWait;

        /// <summary>
        /// Parameterized Constructor.
        /// The constructor (instance) of the class assigns the instance of the WebDriver to the driver field
        /// </summary>
        /// <param name="driver"></param>
        public LoginPageRefactored(IWebDriver driver)
        {
            this.driver = driver;
            this.driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        /// <summary>
        /// Method WaitWebElement. It waits (up to 5 sec) until the WebElement displayed, otherwise return null.
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public IWebElement WaitWebElement(By by)
        {
            try
            {
                return driverWait.Until(d =>
                {
                    var webElement = driver.FindElement(by);
                    return (webElement != null && webElement.Displayed) ? webElement : null;
                });
            }
            catch (WebDriverTimeoutException)
            {
                return null;
            }
        }

        /* Properties. 
         * Web Elements Locators.
         */

        /* public IWebElement LoginLink 
           { 
               get 
                { 
                    return driver.FindElement(By.Id("LoginLnk")); 
                } 
           }
        */

        /// <summary>
        /// IWebElement LoginLink getter Property
        /// </summary>
        public IWebElement LoginLink => WaitWebElement(By.Id(Tag.LinkLogin));

        /// <summary>
        /// IWebElement TxtUserName getter Property
        /// </summary>
        public IWebElement TxtUserName => WaitWebElement(By.Id(Tag.UserName));

        /// <summary>
        /// IWebElement TxtPassword getter Property
        /// </summary>
        public IWebElement TxtPassword => WaitWebElement(By.Id(Tag.Password));

        /// <summary>
        /// IWebElement BtnLogin getter Property
        /// </summary>
        public IWebElement BtnLogin => WaitWebElement(By.CssSelector(Tag.DotBtn));

        /// <summary>
        /// IWebElement LinkEmployeeDetails getter Property
        /// </summary>
        public IWebElement LinkEmployeeDetails => WaitWebElement(By.LinkText(Tag.EmployeeDetails));

        /// <summary>
        /// IWebElement LinkManageUsers getter Property
        /// </summary>
        public IWebElement LinkManageUsers => WaitWebElement(By.LinkText(Tag.ManageUsers));

        /// <summary>
        /// ClickLogin. Clicks the Login link to open the Login page.
        /// </summary>
        public void ClickLogin()
        {
            LoginLink.Click();
        }

        /// <summary>
        /// Login(string username, string password). Enters the user credentials and submits the form (Login form).
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void Login(string username, string password)
        {
            TxtUserName.SendKeys(username);
            TxtPassword.SendKeys(password);

            BtnLogin.Submit();
        }

        /// <summary>
        /// IsLoggedIn | Simple Display Condition
        /// </summary>
        /// <returns></returns>
        public bool IsLoggedIn()
        {
            return LinkEmployeeDetails.Displayed;
        }
    }
}
