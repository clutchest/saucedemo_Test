Feature: Cart page funcionality
	Check if cart page works as expected

@ContinueShoppingButton
Scenario: Check continue shopping button
	Given I launch the driver and navigate to test site and login with correct credentials
	And I click on shopping cart button
	And I click continue shopping button
	Then Homepage should be displayed

@ProceedToCheckoutButton
Scenario: Check proceed to checkout button
	Given I launch the driver and navigate to test site and login with correct credentials
	And I click on shopping cart button
	And I click proceed to checkout button
	Then Checkout page should be displayed