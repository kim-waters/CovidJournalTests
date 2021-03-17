Feature: LoginPageHappyPath
	logging in with valid email and password

@happy path
Scenario: logging with registered email
	Given I am on the log in page
	And I enter a registered username
	And I enter a valid password
	When the login button is pressed
	Then I am taken to the home page