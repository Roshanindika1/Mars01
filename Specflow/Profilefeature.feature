Feature: Profilefeature

As a MARS Admin 
I would like to add and  retrieve my profile details
(Languages/ Skills/ Education and Certification details)

Scenario: [Create Profile records with valid details]
	Given [I logged into MARS successfully]
	When [I create the new language details]
	And [I Create the new Skills details]
	And [I Create the new Education details]
	And [I Create the new Certification details]
	Then [The record should be created successfully]
