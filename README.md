# .NET Selenium from Scratch to CI/CD with GitHub

Author: IxxI5

### Description

.NET Selenium from Scratch to CI/CD with GitHub. Selected sections of Karthik KK's Udemy course inspired the above code (modified by IxxI5) for website testing automation using .NET C# Selenium.

Click the arrow to view the details.
<details>
<summary><b>1 Troubleshooting Hints after Installing .NET 8.0 or VS2022 Community Edition in a x64 Machine</b></summary>

- Step 1: Open the Developer PowerShell in VS2022 and type: 
  **setx DOTNET_ROOT "C:\Program Files\dotnet"**
- Step 2: Restart VS2022. Open the Developer PowerShell in VS2022 and type: 
  **dotnet --info** 
- Step 3: ATTENTION! IF the above typed command is not recognized then, delete the dotnet folder under **Program Files (x86)**
- Step 4: RESTART VS2022. Repeat Step 2

Note: As long as VS2022 and.NET are available without issues, ignore this step.
</details>

<details>
<summary><b>2 Installing .NET Selenium on a New NUnit Project</b></summary>

- CREATE a new NUnit Cross platform project
- SOLUTION EXPLORER: Double click click on solution -> Dependencies are visible (Analyzers, Frameworks, 
  Packages)
- RIGHT CLICK: on Dependencies -> Manage NU Packages
- SEARCH for and INSTALL: Selenium.WebDriver (> 107M Downloads)
- CHECK: Dependencies -> Packages -> Selenium.WebDriver (4.22.0 or later)
- TEST EXPLORER: View -> Test Explorer
- TEST EXPLORER: Select the icon with the chemical bottle to see the list of tests (IF NOT VISIBLE, 
  read below this line)
- CLICK ON: .sln file -> List of Tests becomes available e.g. Test1, Test2..etc

Note: This step applies not to the current project but to creating a new one from scratch.
</details>

<details>
<summary><b>3 Simple .NET Selenium Test (Google Website) with NUnit</b></summary>

- Test: UnitTest1.Test1() Google Search Basic Test (https://www.google.com/). Searching Test.

- Keywords: IWebDriver, ChromeDriver, Navigate, GoToUrl, Manage, Maximize, FindElement, By.Id, By.Name, 
SendKeys  
</details>

<details>
<summary><b>4 Simple .NET Selenium Test (EA Website) with NUnit</b></summary>

- Test: UnitTest1.Test2(). EA Website Basic Test (http://eaapp.somee.com/). Sign In Test.

- Keywords: IWebDriver, ChromeDriver, Navigate, GoToUrl, Manage, Maximize, FindElement, By.Id, By.Name, 
SendKeys 
</details>

<details>
<summary><b>5 Simple .NET Selenium Test (EA Website) with NUnit (Refactored)</b></summary>

- Test: UnitTest1.Test3(). EA Website Basic Test (http://eaapp.somee.com/). 

- Keywords: IWebDriver, ChromeDriver, Navigate, GoToUrl, Manage, Maximize, FindElement, By.Id, By.Name, 
SendKeys  
</details>

<details>
<summary><b>6 Dropdown Element Test with .NET Selenium</b></summary>

- Test: UnitTest1.Test4(). EA Website Basic Test (http://eaapp.somee.com/). Dropdown Element Test.

- Prerequisites: Selenium.Support library should be preinstalled -> Dependecies -> Manage NuGet Packages

- Keywords: IWebDriver, ChromeDriver, Navigate, GoToUrl, Manage, Maximize, FindElement, By.Id, By.Name, 
By.ClassName, SendKeys, Click, LinkText, FindElements, IList<IWebElement>, SelectElement, 
SelectByIndex
</details>

<details>
<summary><b>7 Tests using Custom Methods and .NET Selenium</b></summary>

- Test: UnitTest1.Test5(). EA Website Basic Test (http://eaapp.somee.com/). Creating/Invoking Custom 
Methods.

- Prerequisites: A separate public class e.g. SeleniumCustomMethods, having public static methods e.g. Click() 
should be available.

- Usage: e.g. SeleniumCustomMethods.Click(driver, By.Id("loginLink"))

- Keywords: SeleniumCustomMethods.Click, SeleniumCustomMethods.EnterText, SeleniumCustomMethods.SelectDropDown
</details>

<details>
<summary><b>8 Tests using the Page Object Model and .NET Selenium</b></summary>

- Test: UnitTest1.Test6(). EA Website Test using the Page Object Model (LoginPage.cs).

- Prerequisites: Page Object Model, also known as POM, is a design pattern in Selenium that creates an object 
repository for storing all web elements. It helps reduce code duplication and improves test case 
maintenance. In Page Object Model, consider each web page of an application as a class file e.g. 
LoginPage.

- Keywords: IWebDriver, IWebElement, FindElement
</details>

<details>
<summary><b>9 Tests using the Page Object Model, Custom Methods and .NET Selenium</b></summary>

- Test: UnitTest1.Test7(). EA Website Test using the Page Object Model (LoginPage.cs).

- Prerequisites: Page Object Model, also known as POM, is a design pattern in Selenium that creates an object 
repository for storing all web elements. It helps reduce code duplication and improves test case 
maintenance. In Page Object Model, consider each web page of an application as a class file e.g. 
LoginPage.

- Keywords: IWebDriver, IWebElement, FindElement, SeleniumCustomMethods
</details>

<details>
<summary><b>10 Tests using the Page Object Model and .NET Selenium Extension Methods</b></summary>

- Test: UnitTest1.Test8(). EA Website Test using the Page Object Model (LoginPage.cs).

- Prerequisites: Page Object Model, also known as POM, is a design pattern in Selenium that creates an object 
repository for storing all web elements. It helps reduce code duplication and improves test case 
maintenance. In Page Object Model, consider each web page of an application as a class file e.g. 
LoginPage. A separate public class e.g. SeleniumExtensionMethods, having public static methods extending the 
Selenium class e.g. Submit(), should be available.

- Keywords: IWebDriver, IWebElement, FindElement, SeleniumExtensionMethods
</details>

<details>
<summary><b>11 Tests using the Page Object Model, the SetUp Method and .NET Selenium</b></summary>

- Test: UnitTest2.Test1(). EA Website Test using the Page Object Model and the SetUp Method.

- Prerequisites: The SetUp method holds the initialization of the test as the WebDriver along with the initial 
actions that are common in all Tests under the e.g. UnitTest2.cs.
</details>

<details>
<summary><b>12 Tests using the Page Object Model, the TextFixture and TestCase Attributes and .NET Selenium</b></summary>

- Test: UnitTest3.Test1(), UnitTest3.Test2().  EA Website Test using the Page Object Model, the TextFixture 
and TestCase Attributes.

- Keywords: TestFixture, Author, Category, TestCase
</details>

<details>
<summary><b>13 Launching .NET Selenium Tests using PowerShell Commands</b></summary>

- To run all tests: 

  <b>dotnet test</b> 

- To run Test5 of UnitTest1.cs only:

  <b>dotnet test --filter "FullyQualifiedName~DotnetSelenium.Tests.UnitTest1.Test5"</b>  

- To run all tests in UnitTest3:

  <b>dotnet test --filter "FullyQualifiedName~DotnetSelenium.Tests.UnitTest3"</b>  

- To run all tests of the project having category "smoke":

  <b>dotnet test --filter "Category=smoke"</b>  

- To run all tests of the UnitTest3 having category "smoke":

  <b>dotnet test --filter "FullyQualifiedName~DotnetSelenium.Tests.UnitTest3&Category=smoke"</b>
</details>

<details>
<summary><b>14 Data Driven .NET Selenium Tests using the TestCaseSource Attribute and the IEnumerable as Data Source</b></summary>

- Test: UnitTest4.Test1(). EA Website Data Driven Test using the TestCaseSource Attribute and the 
IEnumerable<LoginModel> Login as data source.

- Keywords: IEnumerable
</details>

<details>
<summary><b>15 Data Driven .NET Selenium Tests using the TestCaseSource Attribute and a JSON file as Data Source</b></summary>

- Test: UnitTest4.Test2(). EA Website Data Driven Test using the TestCaseSource Attribute and a JSON file 
as Data Source.
</details>

<details>
<summary><b>16 Data Driven .NET Selenium Tests using the Arrange/Act/Assert Principle | Simple, Tuple and Fluent Assertions</b></summary>

- Test: UnitTest4.Test3(), UnitTest4.Test5(), UnitTest4.Test6(). EA Website Data Driven Test using the 
Arrange/Act/Assert Principle | Simple, Tuple and Fluent Assertions.

- Keywords: Assert.That, Should().BeTrue()
</details>

<details>
<summary><b>17 Tests using the Page Object Model and the .NET Selenium Explicit Wait Mechanism</b></summary>

- Test: UnitTest5.Test1(). EA Website Test using the Page Object Model and the Explicit Wait Mechanism for a
less fragile UI Test Code.
- LoginPageRefactored class:
  a. **WaitWebElement** (Custom Method) utilizes the Selenium WebDriverWait class and applies to each IWebElement on demand. 
  b. **Tag** class is located in the same class file (LoginPageRefactored) having all the tag string designations for the Login Page.

- Keywords: WebDriverWait (see LoginPageRefactored class), WaitWebElement (see LoginPageRefactored class), TestFixture
</details>

<details>
<summary><b>18 Tests using the Page Object Model and the .NET Selenium Implicit Wait Mechanism</b></summary>

- Test: UnitTest5.Test1(). EA Website Test using the Page Object Model and the Implicit Wait Mechanism for a
less fragile UI Test Code.

- Keywords: Timeouts, ImplicitWait, TestFixture
</details>

<details>
<summary><b>19 CI/CD with GitHub. Creating a Scheduled or Manually triggered Test RUN (Headless Mode)</b></summary>

- Test: UnitTest5.Test1(). EA Website Test using the Page Object Model and Selenium Headless Mode.
- UnitTest5.SetUp(): We add the browser option for Headless Mode.
- GitHub -> Project Repository -> Actions -> scroll down to Continuous Integration -> select .NET and press Configure.
- YML File -> Clear the content and paste the following:

```
# This workflow will build a .NET project
# For more information see: https://docs.github.com/en/actions/automating-builds-and-tests/building-and-testing-net

name: NUnit Tests using .NET Selenium

on:
  workflow_dispatch:
  schedule:
    - cron: '0 0 * * *'  # This cron syntax means "at midnight UTC"
  # push:
  #   branches:
  #     - main  # This keeps the workflow running on every commit to the main branch (if needed)
  # pull_request:
  #   branches:
  #     - main  # This keeps the workflow running on every pull request to the main branch (if needed)

jobs:
  build:

    runs-on: ubuntu-latest

    steps:
    - uses: actions/checkout@v4
    - name: Setup .NET
      uses: actions/setup-dotnet@v4
      with:
        dotnet-version: 8.0.x

    - name: Restore dependencies
      run: dotnet restore

    - name: Build
      run: dotnet build --no-restore

    - name: Tests using .NET Selenium Headless Mode
      run: dotnet test --filter "FullyQualifiedName~DotnetSelenium.Tests.UnitTest5" 
```

- Actions -> On the left, select "NUnit Tests using .NET Selenium". The following actions are available:
  a. Manual RUN -> Run Workflow
  b. Scheduled RUN -> On 00:00 at every midnight UTC, UnitTest5 will run automatically (no user action is required)

- Keywords: ChromeOptions, AddArgument, SetUp
</details>


