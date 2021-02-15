Feature: User updates the profile
	In order to update my profile 
	As a skill trader
	I want to add my skills and other details

@mytag

Background:
Given User is using the Chrome browser
When User is navigates to "http://localhost:5000/Home" url
And User enters the valid login cridentials "diliniwijenayaka@gmail.com" and "1qaz2wsx@"
Then Use is able to log in to the application


Scenario Outline: 1 Check whether the user is bale to add Languages to the profile
	Given User clicks on the 'Languages' tab in profile page
	And User clicks on the 'Add New' button
	When User adds a new language <Language> and <Language Level>
	Then The <Language> language should be added to the 'Language' page

	Examples: 

		| Language | Language Level |
		| Spanish  | Intermediate   |


Scenario Outline: 2 Check whether the user is able to add Skills to the profile
	Given USer clicks on the 'Skills' tab in Profile page
	And User clicks on the 'Add New' button
	When User adds a new skill <Skill> and <Skill Level>
	Then The <Skill> skill should be added to the 'Skills' page

	Examples: 
		
		| Skill | Skill Level  |
		| Java  | Intermediate |


Scenario Outline: 3 Check whether the user is bale to add Education details to the profile
	Given User clicks on the 'Education' tab in profile page
	And User clicks on the 'Add New' button
	When User adds a new language <Country>, <University>, <Title>, <Degree> and <Graduation Year>
	Then The <Education> education details should be added to the 'Education' page

	Examples: 
		| Country     | University        | Title | Degree | Graduation Year |
		| New Zealand | Massey University | B.Sc. | Honors | 2019            |


Scenario Outline: 4 Check whether the user is able to add the Certifications to the profile
	Given USer clicks on the 'Certifications' tab in the Profile Page
	And User clicks on the 'Add New' button
	When User adds a new certification <Certificate>, <From>, <Year>
	Then The <Certification> certification details should be added to the 'Certification' page

	Examples: 
		| Certificate | From  | Year |
		| ISTQB       | NZTQB | 2018 |


Scenario Outline: 5 Check whether the user is able to Edit the added language successfully
	Given User clicks on the 'Languages' tab in profile page
	And User clicks on 'Edit' button
	When User updates the Language information <Language Level>
	Then that updated details should be visible on the 'Languages' page

	Examples: 
		| Language | Language Level |
		| Spanish  | Expert         |

Scenario Outline: 6 Check whether the user is able to Delete the added Language successfully
	Given User clicks on the 'Languages' tab in profile page
	When User clicks on the 'Delete' button
	Then that Language should not be visible on the 'Languages" page


Scenario Outline: 7 Check whether the user is able to Edit the added Skill successfully
	Given User clicks on the 'Skills' tab in Profile page
	And User clicks on the 'Edit' button
	When User updates the Skill information <Level>
	Then that updated details should be visible on the 'Skills' page

	Examples: 
		| Skill | Level  |
		| Java  | Expert |


Scenario Outline: 8 Check whether the user is able to Delete the added Skill successfully
    Given User clicks on the 'Skills' tab in Profile page
	When User clicks on the 'Delete' button
	Then that Langiage should not be visible on the 'Skills' page


Scenario Outline: 9 Check whether the user is able to Edit the added Education successfully
	Given User clicks on the 'Education' tab in the Profile page
	And User clicks on the 'Edit' button
	When User updates the Education information <University>, <Graduation Year>
	Then that updated details should be visible on the 'Education' page

	Examples: 
		| Country     | University | Title | Degree | Graduation Year |
		| New Zealand | AUT        | B.Sc. | Hons   | 2020            |


Scenario Outline: 10 Check whether the user is able to Delete the added Education successfully
    Given User clicks on the 'Skills' tab in Profile page
	When User clicks on the 'Delete' button
	Then that Langiage should not be visible on the 'Education' page


Scenario Outline: 11 Check whether the user is able to Edit the added Certification successfully
	Given User clicks on the 'Certification' tab in the Profile page
	And User clicks on the 'Edit' button
	When User updates the Certification information <Certificate>, <Year>
	Then that updated details should be visible on the 'Certification' page

	Examples: 
		| Certificate      | From  | Year |
		| ISTQB - Advanced | ANZQB | 2020 |



Scenario Outline: 12 Check whether the user is able to Delete the added Certification successfully
    Given User clicks on the 'Certification' tab in the Profile page
	When User clicks on the 'Delete' button
	Then that Langiage should not be visible on the 'Certification' page



	


