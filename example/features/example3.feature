Feature: Google
  In order to find useful information quickly
  As an internet user
  I want to search for stuff on Google
  
  Background:
    Given I am on google
  
  Scenario: search for japan
    When I search for "Japan"
    Then I should see "nuclear" in the results
    
  Scenario: search for monkeys
    And I search for "monkeys"
    Then I should see "apes" in the results
    
  Scenario: search for guitars
    And I search for "guitars"
    Then I should see "strings" in the results