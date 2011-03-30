Feature: Google
  In order to find useful information quickly
  As an internet user
  I want to search for stuff on Google
  
  Scenario: search for japan
    Given I am on google
    When I search for "Japan"
    Then I should see the following results:
      | text      | link                                |
      | Wikipedia | http://en.wikipedia.org/wiki/Japan  |
      | Reuters   | http://www.reuters.com/places/japan |
