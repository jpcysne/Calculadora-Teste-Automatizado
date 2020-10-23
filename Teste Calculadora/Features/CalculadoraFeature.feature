Feature: CalculadoraFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers



Scenario: Add two numbers
	Given I have provided 70 and 20 as the inputs
	When I press add
	Then the result should be 90
 
Scenario: Substract two numbers
	Given I have provided 70 and 20 as the inputs
	When I press substract
	Then the result should be 50
 
Scenario: Multiply two numbers
	Given I have provided 70 and 20 as the inputs
	When I press multiply
	Then the result should be 1400
 
Scenario: Divide two numbers
	Given I have provided 70 and 20 as the inputs
	When I press divide
	Then the result should be 3.5
 