Feature: RegisterPage
	I can register my account on the register page

@Register
Scenario: Register with valid values
	Given I am on the register page
	And I have entered a valid first name
	And I have entered a valid last name 
	And I have entered a valid email 
	And I have entered the password "Password12!"
	And I have entered the password confirmation "Password12!"
	When I click register
	Then I should be taken to the confirmation page

@Register
Scenario: Register with no first name
	Given I am on the register page
	And I have entered a valid last name 
	And I have entered a valid email 
	And I have entered the password "Password12!"
	And I have entered the password confirmation "Password12!"
	When I click register
	Then An error message should be displayed saying "The First Name field is required."

@Register
Scenario: Register with no last name
	Given I am on the register page
	And I have entered a valid first name 
	And I have entered a valid email 
	And I have entered the password "Password12!"
	And I have entered the password confirmation "Password12!"
	When I click register
	Then An error message should be displayed saying "The Last Name field is required."

@Register
Scenario: Register with no email
	Given I am on the register page
	And I have entered a valid first name 
	And I have entered a valid last name 
	And I have entered the password "Password12!"
	And I have entered the password confirmation "Password12!"
	When I click register
	Then An error message should be displayed saying "The Email field is required."

	
@Register
Scenario: Register with no password
	Given I am on the register page
	And I have entered a valid first name 
	And I have entered a valid last name 
	And I have entered a valid email 
	When I click register
	Then An error message should be displayed saying "The Password field is required."

@Register
Scenario: Register with invalid password
	Given I am on the register page
	And I have entered a valid first name 
	And I have entered a valid last name 
	And I have entered a valid email 
	And I have entered the password "password"
	And I have entered the password confirmation "password"
	When I click register
	Then An error message should be displayed saying "Passwords must have at least one non alphanumeric character."

@Register
Scenario: Register with mismatching passwords
	Given I am on the register page
	And I have entered a valid first name 
	And I have entered a valid last name 
	And I have entered a valid email 
	And I have entered the password "Password12!"
	And I have entered the password confirmation "Password21!"
	When I click register
	Then A password error message should be displayed saying "The password and confirmation password do not match."

