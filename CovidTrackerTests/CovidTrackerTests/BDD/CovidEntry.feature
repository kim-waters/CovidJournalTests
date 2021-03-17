Feature: CovidEntry
	Make daily entries on symptoms

@navigate
Scenario: Navigate to the entry page
	Given the user is signed in
	And the user is on the homepage
	When the covid entry link is clicked
	Then the user is directed to the covid entry page

@create new
Scenario: Navigate to the create entry page
	Given the user is signed in
	And the user is on the covid entry page
	When the create new link is clicked
	Then the user is directed to the Create covid entry page
