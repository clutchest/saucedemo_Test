Feature: HomePage social networks
	Check if all 3 social network links from homepage redirect user to correct url

@SocialNetworks-Twitter
Scenario: Check twitter link working properly
	Given I launch the driver and navigate to test site and login with correct credentials
	And I click twitter button
	And I switch to popup tab in browser
	Then Twitter should be loaded

@SocialNetworks-Facebook
Scenario: Check facebook link working properly
	Given I launch the driver and navigate to test site and login with correct credentials
	And I click facebook button
	And I switch to popup tab in browser
	Then Facebook should be loaded

@SocialNetworks-LinkedIn
Scenario: Check linkedin link working properly
	Given I launch the driver and navigate to test site and login with correct credentials
	And I click linkedin button
	And I switch to popup tab in browser
	Then LinkedIn should be loaded