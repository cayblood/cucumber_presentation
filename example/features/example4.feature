Feature: Google
  In order to find useful information quickly
  As an internet user
  I want to search for stuff on Google
  
  Scenario Outline:
    When I go to google
    And I search for "<query>"
    Then I should see "<result>" in the results
    
    Examples:
      | query   | result  |
      | Japan   | nuclear |
      | monkeys | apes    |
      | guitars | strings |