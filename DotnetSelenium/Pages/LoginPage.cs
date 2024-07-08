using OpenQA.Selenium;

namespace DotnetSelenium.Pages
{
    public class LoginPage
    {
        /// <summary>
        /// WebDriver Instance Field. 
        /// Holds and makes available the instance of the WebDriver within the LoginPage class.
        /// </summary>
        private readonly IWebDriver driver;

        /// <summary>
        /// Parameterized Constructor.
        /// The constructor (instance) of the class assigns the instance of the WebDriver to the driver field.
        /// </summary>
        /// <param name="driver"></param>
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /* Properties 
         * -Locators-
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
        public IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));

        /// <summary>
        /// IWebElement TxtUserName getter Property
        /// </summary>
        public IWebElement TxtUserName => driver.FindElement(By.Id("UserName"));

        /// <summary>
        /// IWebElement TxtPassword getter Property
        /// </summary>
        public IWebElement TxtPassword => driver.FindElement(By.Id("Password"));

        /// <summary>
        /// IWebElement BtnLogin getter Property
        /// </summary>
        public IWebElement BtnLogin => driver.FindElement(By.CssSelector(".btn"));

        /// <summary>
        /// IWebElement LinkEmployeeDetails getter Property
        /// </summary>
        public IWebElement LinkEmployeeDetails => driver.FindElement(By.LinkText("Employee Details"));

        /// <summary>
        /// IWebElement LinkManageUsers getter Property
        /// </summary>
        public IWebElement LinkManageUsers => driver.FindElement(By.LinkText("Manage Users"));

        /* Methods 
         * -Actions-
         */

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

        /* SeleniumCustomMethods based on IWebElement that utilizes 
         * the LoginPage locator properties as parameters to Actions (methods)
         */

        /// <summary>
        /// ClickLogin2 | SeleniumCustomMethods
        /// </summary> 
        public void ClickLogin2()
        {
            SeleniumCustomMethods.Click(LoginLink);
        }

        /// <summary>
        /// Login2 | SeleniumCustomMethods
        /// </summary>
        public void Login2()
        {
            SeleniumCustomMethods.EnterText(TxtUserName, "admin");
            SeleniumCustomMethods.EnterText(TxtPassword, "password");

            SeleniumCustomMethods.Click(BtnLogin);
        }

        /* SeleniumExtensionMethods based on this IWebElement. HOW TO:
         * 1. Create a class file named "SeleniumExtensionMethods"
         * 2. Make the class public static class
         * 3. Create static methods that extends the functionality of a Selenium class
         * e.g.
         */

        /// <summary>
        /// ClickLogin3 | SeleniumExtensionMethods
        /// </summary>
        public void ClickLogin3()
        {
            LoginLink.SubmitSEM();
        }

        /// <summary>
        /// Login3 | SeleniumExtensionMethods
        /// </summary>
        public void Login3()
        {
            TxtUserName.EnterTextSEM("admin");
            TxtPassword.EnterTextSEM("password");

            BtnLogin.SubmitSEM();
        }

        /* Display Conditions | Important: DO NOT use Assertions within the Page Object Model
         * since it leads to an anti-pattern design (no separation of concerns)
         */

        /// <summary>
        /// IsLoggedIn | Simple Display Condition
        /// </summary>
        /// <returns></returns>
        public bool IsLoggedIn()
        {
            return LinkEmployeeDetails.Displayed;
        }

        /// <summary>
        /// IsLoggedIn2 | Tuple Display Condition
        /// </summary>
        /// <returns></returns>
        public (bool employeeDetails, bool manageUsers) IsLoggedIn2() 
        {
            return (LinkEmployeeDetails.Displayed, LinkManageUsers.Displayed);
        }
    }
}
