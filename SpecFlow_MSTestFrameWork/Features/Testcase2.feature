Feature: Testcase2

Feature to verify the search functionality in the application

@Smoke
Scenario: To verify search funtionality of Execute Automation
	Given that I have gone to the Home page of application
	When I add "selenium" to the search box
	And click the Search Button
	Then "selenium" should be mentioned in the results