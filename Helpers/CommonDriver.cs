using August2020.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace August2020.Helpers
{
    class CommonDriver
    {
        // Init driver
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginActions()
        {
            // define webdriver
            driver = new ChromeDriver();

            // Login page object init and definition
            LoginPage loginObj = new LoginPage(driver);
            loginObj.LoginSteps();

        }

        [OneTimeTearDown]
        public void ClosingSteps()
        {
            // kills driver instance
            driver.Quit();
        }
    }
}
