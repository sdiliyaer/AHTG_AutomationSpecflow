Feature: RequestDemo_Feature

@mytag
Scenario: verify default name and email on Request Demo page
	Given User is at Home Page
	When Click Request a demo button
	Then User will be navigate to Request demo page
	And Name box should have value of "What's your name?" as default text
	And Email box should have value of "What's your email?" as default text
	When Click about us button And Click Our team button
	Then User should be able to see images for employees
		| FirstName | LastName  |
		| Brian     | Schwidder |
		| Ben       | Palmer    |
	When Click view more button under employee "Ben Palmer"
	Then User should be able to see a page with more details for "Ben Palmer"
	When Click our products button
	Then Verify the products with a request demo button
		| Product      |
		| Trio VMS     |
		| Insight ATS+ |