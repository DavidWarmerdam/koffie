Feature: HomePageItems


@mytag
Scenario: See koffiewarenhuis logo
	Given I open the homepage
	Then the koffiewarenhuislogo is present

Scenario: Customer service phone number is present on homepage
	Given I open the homepage
	Then the phone number of customer service is present

Scenario: Cart is empty notification present when no items added to cart
	Given I open the homepage
	When I click on the cart icon
	Then I see the cart notification no items

Scenario: Stock notification present in slider product
	Given I open the homepage
	Then the slider product does contain stock

Scenario: Item is presented in minicart after adding to cart
	Given I open the homepage
	And I have added the slider item to the cart
	When I click on the cart icon
	Then the cart presents the added item