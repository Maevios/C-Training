Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Calculator/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**
	#To generate report: 
		#Run tests
		#open command prompt
		#cd to project
		#run: livingdoc feature-folder .\Calculator -t .\Calculator\bin\Debug\netcoreapp3.1\TestExecution.json

	#To run smoke suite:
	#	open command prompt
	#	cd to project
	#	run: dotnet test --filter Category=smoke
		
	
	@smoke
	Scenario: User Logs in
	Given User navigates to register page
	When User logins with username Test and password Test
	And User clicks the log in button
	Then User has succefully logged in
	
	@smoke
	Scenario: Register with correct data
	Given User navigates to register page
	When fill out the following field with the coresponding text
	| Field		 | Value|
	| First Name | Test |
	| Last Name  | Test |
	| Address	 | Test |
	| City		 | Test	|
	| State		 | Test	|
	| Zip Code	 | Test	|
	| Phone	     | Test	|
	| SSN		 | Test	|
	| Username	 | Test	|
	| Password   | Test	|
	| Confirm    | Test	|
	And User clicks the register button
	Then User has succefully registered

	Scenario: Register with empty form
	Given User navigates to register page
	When User clicks the register button
	Then the following field should display the coresponding error
	| Field		 | Value |
	| First Name | First name is required.|
	| Last Name  | Last name is required. |
	| Address	 | Address is required.   |
	| City		 | City is required.	  |
	| State		 | State is required.	  |
	| Zip Code	 | Zip Code is required.  |
	| SSN		 | Social Security Number is required. |
	| Username	 | Username is required.  |
	| Password   | Password is required.   |
	| Confirm    | Password confirmation is required.  |

	Scenario: Register with an existing username
	Given User navigates to register page
	When fill out the following field with the coresponding text with existing username
	| Field		 | Value|
	| First Name | Test |
	| Last Name  | Test |
	| Address	 | Test |
	| City		 | Test	|
	| State		 | Test	|
	| Zip Code	 | Test	|
	| Phone	     | Test	|
	| SSN		 | Test	|
	| Username	 | Test	|
	| Password   | Test	|
	| Confirm    | Test	|
	And User clicks the register button
	Then the following field should display the coresponding error
	| Field		 | Value						  |
	| Username	 | This username already exists.  |


