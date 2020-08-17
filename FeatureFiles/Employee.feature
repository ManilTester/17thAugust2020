Feature: Employee

Scenario: Verify user can create an employee
	Given I login to the Turn Up Portal
	#When I click the option "Employees" under Administration dropdown on Home Page
	When I navigate to the Employees Page
	Then I am on the Employess Page