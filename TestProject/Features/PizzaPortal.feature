Feature: PizzaOrderingFeature
    In order to enjoy delicious pizza
    As a pizza lover
    I want to select pizza, place an order, and receive a confirmation

Scenario: User can order pizza
    Given the user is on the Pizza Selection page
    When the user selects a "Pepperoni" pizza with quantity "2"
    And adds it to the cart
    And proceeds to checkout
    Then the user should be on the Order Checkout page

Scenario: User can confirm the order
    Given the user is on the Order Checkout page
    When the user confirms the order
    Then the user should be on the Order Confirmation page
    And the order details should include:
        | Pizza Type  | Quantity | Total Price |
        | Pepperoni   | 2        | 900         |
