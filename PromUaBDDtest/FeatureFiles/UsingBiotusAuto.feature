Feature: Using Biotus

 As a customer
 I want to read the payment reference
 In order to know what kinds of payment methods work on the site

 As a customer
 I want to read the Help for Buyers
 In order to know how to find the item I'm interested in

 As a Seller
 I want to read the help for sellers
 In order to know how to work with the catalog

 As a customer 
 I want to read the safety help
 So I don't get scammed


 Background: 
    Given user opening a browser window and maximize
    And user in on the home page

	Scenario: Selecting items by filter
	    When customer clicks on the Vitamins link
		And customer clicks on the Vitamin C link.
        And customer clicks on the Ester-C link
        And shopper clicks on the link Ester-C Plus Vitamin C 
		Then customer must see a info of the product

	Scenario: Choosing a product through search
		When customer enters 'omega 3' in the search box
        And customer clicks on the link Omega, Now Foods
		Then customer should have a window with a description of that product

	Scenario: Adding to cart
		When customer clicks on the For Sports link
		And shopper clicks on the Sports Amino Acids link
        And shopper clicks on the Arginine link
		Then customer must see a description of the product

	Scenario: Combination Choice
		When shopper clicks on the Minerals link
		And shopper clicks on the Vitamins link with Selenium
        And buyer clicks on the Selenium for eye checkbox
        And buyer clicks on the Selenium, Puritan's Pride link
		Then buyer should see a description of the product


	
