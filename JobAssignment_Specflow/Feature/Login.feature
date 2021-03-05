Feature: Login
	Check if login is doing as expected

@IncorrectCredentials
Scenario: Check if error message is displayed when trying to login with incorrect credentials
	Given I launch the driver and navigate to test site
	And Input wrong credentials
	When I press login button
	Then Error message should now be displayed

@EmptyCredentials(Username)
Scenario: Check if correct error message displayed when username is empty
	Given I launch the driver and navigate to test site
	And I pass empty username
	When I press login button
	Then Correct username empty error message should be displayed

@EmptyCredentials(Password)
Scenario: Check if correct error message displayed when password is empty
	Given I launch the driver and navigate to test site
	And I pass empty password
	When I press login button
	Then Correct error message should be displayed

@CorrectCredentials
Scenario: Check if homepage is loaded when loging in with correct credentials
	Given I launch the driver and navigate to test site
	And I pass correct credentials
	When I press login button
	Then Homepage should be loaded