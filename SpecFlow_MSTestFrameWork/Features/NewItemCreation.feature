Feature: NewItemCreation
	Scenario to create a new item and publish in store

@mytag
Scenario: To Verify the creation of new item
	Given user enters the credentials and navigate to landing page '<username>', '<hqpassword>'
	When user click side menu and select the item.
	And user create a new batch
	And then creates a new item
	#Then confirm the item in thw batch file
	#And publish the batch