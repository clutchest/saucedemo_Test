Feature: Login page elements
	Check if login page elements are doing as expected

@loginPageDisplayed
Scenario: Check if login page displayed
	Given I launch the driver and navigate to test site
	Then The login page should be displayed

@UsernameFieldDisplayedAndEmpty
Scenario: Check if username field displayed and empty
	Given I launch the driver and navigate to test site
	Then Username field should be empty and displayed

@PasswordFieldDisplayedAndEmpty
Scenario: Check if password field displayed and empty
	Given I launch the driver and navigate to test site
	Then Password field should now be empty and displayed

@LoginButtonDisplayedAndEnabled
Scenario: Check if login button displayed and enabled
	Given I launch the driver and navigate to test site
	Then Login button should now be displayed and enabled


