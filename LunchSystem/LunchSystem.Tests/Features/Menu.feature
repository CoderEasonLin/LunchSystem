Feature: Menu
	For menu page.

@Order
Scenario: OrderMeal
	Given enter order page
	And enter the order "Tom", "Big Mac", "90"
	When press order
	Then the order should show in the ordered list

Scenario: Page present
	Given enter order page
	Then can see the menu image
	And can see the system logo