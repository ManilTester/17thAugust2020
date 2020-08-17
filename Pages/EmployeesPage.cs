using OpenQA.Selenium;

namespace August2020.Pages
{
    internal class EmployeesPage : BasePage
    {
        public EmployeesPage(IWebDriver driver) : base(driver)
        {
        }

        internal By PageLocator => By.CssSelector("div[id=container] p a[class*=btn]");

        // create employee test
        public void CreateEmployee(IWebDriver driver)
        {

        }

        // edit employee test
        public void EditEmployee(IWebDriver driver)
        {

        }

        // delete employee test
        public void DeleteEmployee(IWebDriver driver)
        {

        }
    }
}
