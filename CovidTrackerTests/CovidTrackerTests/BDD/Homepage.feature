Feature: Homepage
	I want to be able to navigate to other pages from the home poge

@navigate
Scenario: Navigate to login
	Given I am on the homepage
	When I click on the login nav link
	Then I should be taken to the login page


@navigate
Scenario: Navigate to register
	Given I am on the homepage
	When I click on the register nav link
	Then I should be taken to the register page


@navigate
Scenario: Try to access data while not signed in
	Given I am on the homepage
	When I click on the covid entry nav link
	Then I should be taken to the login page