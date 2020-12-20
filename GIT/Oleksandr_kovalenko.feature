Feature: Testing Epam web-site


Background: 
    Given I opened Epam web-site


Scenario: Select Region
	Given Click "Global (EN)"	
	When I select "Ukraine(English)"
	Then I should be redirected to Ukrainian region English web-page

Scenario: Read about company
    Given I am on the ane page
	When I click "Company" button
	Then I should see all info about EPAM.

Scenario: Look at vacancies
    Given I am on the any page.
	When I click "Vacancies" button
	Then I should see menu for finding vacancies

Scenario: Finding McDonald`s cashier vacancies
	Given I`m on "Vacancies" page
	When I printed "McDonalds" to search string
	Then I should see "McDonald`s" vacancies
	And vacancy for cashier too

Scenario: Looking at Privacy Policy
	Given I am on the any page
	And I scroll down the page 
	When I clicked at Privacy Policy
	Then Site should show me all the needed information
	
Scenario: Using a Search
	Given I am on the main page
	* I click on the searching button
	* Serch menu drops down
	* I type in "Blockchain" in search field
	When I click "FIND" button
	Then I should see everything about Blockchain at EPAM

Scenario: Adaptive structure
	Given I am on the contact page 
	When I click "CONTACT US" button
	Then browser should onload new page with a contact form

	Scenario: Info about EPAM and Healthcare
	Given I am on the any page
	And Put my mouse on the "Our Work"
	When I clicked on Healthcare
	Then I should see all the info about Healthcare