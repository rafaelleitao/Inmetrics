Feature: Access carreers page  
	in order to make an application to an open opportunity in the Inmetrics carrers web page
	i as a candidate
	i desire to see all open opportunities listed in the web page

@mytag
Scenario: Access carreers page 
	Given I accessed the home page
	And Located the "check our opportunities" button.
	When I click on the "check our opportunities" button.
	Then The open opportunities page is properly displayed
