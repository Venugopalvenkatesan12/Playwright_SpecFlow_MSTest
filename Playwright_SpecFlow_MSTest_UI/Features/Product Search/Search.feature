Feature: Search

Search product from Landing page

Background: Launch application
	Given User browses the application url

Scenario Outline: Search the product in landing page and verify the results count
	When User provides search text '<SearchText>' in Landing page
	And User clicks on Search icon in Landing page
	Then User must see '<ResultsText>' text in results grid in Search page
	And User must see result page count '<ResultShowingText>' text in results grid in Search page
	And User must see text '<SearchText>' in the product description in Search page
	Examples:
	| SearchText | ResultsText                | ResultShowingText        |
	| Short      | 4 results have been found. | Showing 1 - 4 of 4 items |
