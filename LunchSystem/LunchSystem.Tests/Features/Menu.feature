﻿Feature: Menu
	For menu page.

@Order
Scenario: OrderMeal
	Given enter order page
	And enter the meal "Big Mac"
	When press order
	Then the result should "Big Mac" in the ordered list

Scenario: Page present
	Given enter order page
	Then can see the menu image
	And can see the system logo