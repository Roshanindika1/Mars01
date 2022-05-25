using Mars01.Pages;
using Mars01.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Mars01
{
    internal class ProfileTests : CommonDriver
    {
        static void Main(string[] args)
        {

            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginSteps(driver);

            //Profile page object initializing and defining
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddLanguage(driver);
            ProfilePageObj.AddSkills(driver);
            ProfilePageObj.AddEducation(driver);
            ProfilePageObj.AddCertification(driver);




        }
    }
}
