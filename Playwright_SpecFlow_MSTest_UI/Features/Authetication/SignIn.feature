Feature: SignIn feature

Verify sign in feature for Automation Practice website.

Background: Launch application
	Given User browses the application url

@regression @sanity
Scenario: Verify application sign in
	When User clicks on Sign in link in Landing page
	Then User must see Authentication page displayed
	When User provides sign in details and click on SignIn button
	Then User must see My account page with account name displayed
