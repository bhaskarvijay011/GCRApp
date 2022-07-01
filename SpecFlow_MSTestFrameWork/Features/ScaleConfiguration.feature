Feature: ScaleConfiguration
	Simple calculator for adding two numbers

@mytag
Scenario: To Verify Font Configuration
	Given user navigates to HQ application
	When enter valid '<username>', '<hqpassword>'
	And Clicks on Log In button
	Then HQ homepage should be displayed
	When User clicks on the Left Menu
	Then menu should be displayed
	When User enters Scale Configuration in the Search Box
	Then Scale Configuration Item should be displayed on the Menu
	When User Selects the Scale Configuration
	Then Scale Configuration Page should be displayed
	When User click s on the Add New from Font Section 
	Then Create New Font Pop up should appear
	When  User enters the '<Code>', '<FontName>'
	Then the save button should be enabled
	When User clicks on button Save
	Then Font should get saved and a '<confirmationMsg>' should be displayed for the same
	When user Looks Font table
	Then the recently created Font should be displayed
