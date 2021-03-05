Feature:  Home page elements
	Check if home page elements are doing as expected

@SortContainerDisplayed
Scenario: Check if sort container displayed and enabled
	Given I launch the driver and navigate to test site and login with correct credentials
	Then Sort container should be displayed and enabled

@ShoppingCartDisplayed
Scenario: Check if shopping cart displayed and enabled
	Given I launch the driver and navigate to test site and login with correct credentials
	Then Shopping cart should be displayed and enabled

@MerchandiseDisplayed
Scenario: Check if merchandise is displayed
	Given I launch the driver and navigate to test site
	Then Merchandise should now be displayed

@Options>AboutLink
Scenario: Check if options > about link is redirecting user to correct page
	Given I launch the driver and navigate to test site and login with correct credentials
	And I click on options dropdown
	And I click on about link on options dropdown
	Then User should be redirected to saucelabs.com site

@Options>LogOutLink
Scenario: Check if options > log out link is redirecting user to correct page
	Given I launch the driver and navigate to test site and login with correct credentials
	And I click on options dropdown
	And I click on log out link on options dropdown
	Then User should be redirected to saucedemo.com site

@ShoppingCartPageDisplayed
Scenario: Check if Shopping cart is displayed on home page
	Given I launch the driver and navigate to test site and login with correct credentials
	And I click on shopping cart
	Then User should be redirected to shopping cart page

@AddToCart/RemoveButtons
Scenario: Check if AddtoCart/Remove buttons work as expected
	Given I launch the driver and navigate to test site and login with correct credentials
	And I click every button
	Then Button text should now be REMOVE
	Then I click every button again
	Then Button text should now be ADD TO CART


	 