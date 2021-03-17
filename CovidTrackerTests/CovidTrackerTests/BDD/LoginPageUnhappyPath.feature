Feature: LoginPageUnhappyPath
	loging in to the system with invalid details

@Unhappy path
Scenario: Login with blank username
	Given I am on the log in page
	And I enter a blank username
	And I enter a valid password
	When the login button is pressed
	Then an error message is displayed