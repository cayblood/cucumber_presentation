Feature: Manage users
  In order to be aware of and serve my customers
  As an administrator
  I want to create, read, update, and delete user information
  
  Scenario: View user list
    Given I have users named George, Mary
    When I go to the list of users
    Then I should see "George"
    And I should see "Mary"