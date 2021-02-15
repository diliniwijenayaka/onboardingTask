Feature: User updates the profile
	In prder to Share my Skills
	As a skill trader
	I want to add details of my Skills

@mytag

Background:
Given User is using the Chrome browser
When User is navigates to "http://localhost:5000/Home" url
And User enters the valid login cridentials "diliniwijenayaka@gmail.com" and "1qaz2wsx@"
Then Use is able to log in to the application

Scenario Outline: 13 Check whether the user is able to share a relevant skill
     Given User clicks on the 'Share Skill' button
	 When  User enters the details <Title>,<Description>,<Category>,<Tags>,<Service Type>,<Location Type>, <Skill Trade>, <Skill Exchange>, <Credit> , <Work Samples> and <Active>
	 And   User enteres Available Days
	 Then  that Skill should be added to the Manage Listing page

		 Examples: 
		       | Title       | Description  | Category | Tags                | Service Type         | Location Type | Skill Trade | Skill Exchange | Credit | Work Samples    | Active |
		       | Skill Share | Professional | Business | Business Statistics | Hourly basis service | Online        | Credit      | Available      | 100    | WorkSamples.pdf | Active |


Scenario Outline: 14 Check whether the user is able to Edit the shared skill details
     Given User clicks on the Edit button on the Manage Listings page
	 When  User enters the details <Title>,<Description> and <Category>
	 And   User updates Available Days
	 Then  that updated details should be displayed on the Manage Listings page

         Examples: 
		       | Title            | Description | Category        | Service Type |
		       | Skill Share Test | Beginners   | Music and Audio | Hourly       |

     
Scenario Outline: 15 Check whether the user is able to Delete the shared skill
     Given User clicks on the Manage Listings tab
	 When  User clicks on the 'Delete' button
	 Then  that Shared Skill should no be visible on the Manage Listings page

		Examples: 
			  | Title            | Description | Category        | Service Type |
		      | Skill Share Test | Beginners   | Music and Audio | Hourly       |