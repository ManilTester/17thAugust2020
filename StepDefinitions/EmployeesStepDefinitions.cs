using August2020.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace August2020.StepDefinitions
{
    [Binding]
    public sealed class EmployeesStepDefinitions
    {
        private readonly LoginPage _loginPage;
        private readonly HomePage _homePage;
        private readonly EmployeesPage _employeesPage;

        public EmployeesStepDefinitions(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
            _homePage = new HomePage(driver);
            _employeesPage = new EmployeesPage(driver);
        }

        [Given(@"I login to the Turn Up Portal")]
        public void GivenILoginToTheTurnUpPortal()
        {
            _loginPage.LoginSteps();
        }

        [When(@"I navigate to the Employees Page")]
        public void WhenINavigateToTheEmployeesPage()
        {
            _homePage.NavigateToEmployee();
        }

        [When(@"I click the option ""(.*)"" under Administration dropdown on Home Page")]
        public void WhenIClickTheOptionUnderAdministrationDropdownOnHomePage(string option)
        {

        }

        [Then(@"I am on the Employess Page")]
        public void ThenIAmOnTheEmployessPage()
        {
            var pageLocator = _employeesPage.PageLocator;
            _employeesPage.IsPageLoaded(pageLocator);
        }
    }
}
