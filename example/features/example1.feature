Feature: Google
  In order to find useful information quickly
  As an internet user
  I want to search for stuff on Google
  
  Scenario: search for japan
    Given I am on google
    When I search for "Japan"
    Then I should see "nuclear" in the results
    
  Scenario: search for monkeys
    When I go to google
    And I search for "monkeys"
    Then I should see "apes" in the results
    
  Scenario: search for guitars
    When I go to google
    And I search for "guitars"
    Then I should see "strings" in the results