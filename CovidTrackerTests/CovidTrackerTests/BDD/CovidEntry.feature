Feature: CovidEntry
	Make daily entries on symptoms

@navigate
Scenario: Navigate to the entry page
	Given the user is signed in
	And the user is on the homepage
	When the covid entry link is clicked
	Then the user is directed to the covid entry index page

@create new
Scenario: Navigate to the create entry page
	Given the user is signed in
	And the user is on the covid entry index page
	When the create new link is clicked
	Then the user is directed to the Create covid entry page

Scenario: Create a valid entry
	Given the user is signed in
	And the user is on the covid entry create page
	And the user enters valid journal details
	When the user clicks the create button
	Then the user is directed to the covid entry index page
	And the entry from the same day is present

Scenario: Create an invalid entry for a future date
	Given the user is signed in
	And the user is on the covid entry create page
	And the user enters a date in the future in the journal details
	When the user clicks the create button
	Then an error message is displayed on the create page
