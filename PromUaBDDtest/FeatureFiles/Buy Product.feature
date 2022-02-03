Feature: The choice of products on Prom.ua

 As a buyer
 I want to choose a laptop
 To see its characteristics

 As a customer
 I want to look at the seller's details
 I want to get a contact number

 As a customer
 I want to see return policy
 To assess risks

 As a Buyer
 I want to see information about the manufacturer
 To view their products in this store

 Background: 
    Given open a browser window and maximize

    Scenario: Selecting products by filter
        When the shopper is on the product page
        And the shopper clicks on All Description
        Then the buyer should see the full characteristics of the product
   
    Scenario: Viewing seller's information
        When customer is on the product info page
        And the customer clicks on the Seller UsaSklad button
        And the customer clicks on the Contact  button
        Then customer should then see the seller's phone number
    
        Scenario: Viewing return information
        When the shopper is on the product information page
        And the customer clicks on the Return Policy link
        Then customer should then see the possible return date
    
        Scenario: Viewing manufacturer information
        When shopper is on the product information page
        And the customer clicks on the Acer link
        Then customer should then see products from that manufacturer in different categories
