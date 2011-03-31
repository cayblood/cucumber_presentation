Feature: Factorial
  In order to do awesome math functions
  As a user
  I want to calculate a factorial
  
  Scenario Outline:
    Given I have the number <operand>
    When I compute its factorial
    Then I see the number <result>
    
    Examples:
    | operand | result |
    | 0       | 1      |
    | 1       | 1      |
    | 2       | 2      |
    | 3       | 6      |
    | 4       | 24     |
