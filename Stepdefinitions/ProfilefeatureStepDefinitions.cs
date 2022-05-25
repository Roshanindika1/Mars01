using Mars01.Pages;
using Mars01.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars01.StepDefinitions 
{
    [Binding]
    public class ProfilefeatureStepDefinitions : CommonDriver
    {
        [Given(@"\[I logged into MARS successfully]")]
        public void GivenILoggedIntoMARSSuccessfully()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginSteps(driver);

        }

        [When(@"\[I create the new language details]")]
        public void WhenICreateTheNewLanguageDetails()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddLanguage(driver);

        }

        [When(@"\[I Create the new Skills details]")]
        public void WhenICreateTheNewSkillsDetails()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddSkills(driver);

        }

        [When(@"\[I Create the new Education details]")]
        public void WhenICreateTheNewEducationDetails()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddEducation(driver);

        }

        [When(@"\[I Create the new Certification details]")]
        public void WhenICreateTheNewCertificationDetails()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddCertification(driver);

        }


        [Then(@"\[The record should be created successfully]")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            string newLanguage = ProfilePageObj.GetLanguage(driver);
            string newSkills = ProfilePageObj.GetSkills(driver);
            string newEducation = ProfilePageObj.GetEducation(driver);
            string newCertification = ProfilePageObj.GetCertification(driver);

            Assert.That(newLanguage == "French", "New Language and Expected language does not match");
            Assert.That(newSkills == "Painting", "New Skill and Expected Skill does not match");
            Assert.That(newEducation == "AUT", "New Education and Expected Education does not match");
            Assert.That(newCertification == "Diploma", "New Certification and Expected Certification does not match");


        }
    }
}
