using Mars01.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Mars01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Open chromedriver
            IWebDriver driver = new ChromeDriver();

            //Open Mars web page
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

            //Identify the sign in button and click it
            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signInButton.Click();

            //Identify the email address text box and enter valid email address
            IWebElement emailAddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailAddress.SendKeys("roshanfer80@gmail.com");


            //Identify the Password text box and enter valid Password
            IWebElement passWord = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passWord.SendKeys("Producetaka1");

            //Identify the login button and click 
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(1000);

            //Check if user is logged in successfully

            // IWebElement hiIndika = driver.FindElement(By.CssSelector(".item ui dropdown link"));
            IWebElement hiIndika = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/span"));

            if (hiIndika.Text == "Hi Indika")
            {
              Console.WriteLine("Logged in successfull. Test passed");

            }
            else
            {
                Console.WriteLine("Login Failed. Test failed");

            }


            //Add New Language skill

            //Identify and click the Add new button
            IWebElement addNewButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(1000);

            //Identify Add new language box and enter valid language details
            IWebElement addNewLanguage = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addNewLanguage.Click();
            Thread.Sleep(500);
            addNewLanguage.SendKeys("French");

            //Identify Choose language level drop down button and select the language level
            IWebElement languageLevelDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));

            Wait.Waitforclicable(driver, "Xpath", "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 2);

            languageLevelDropdown.Click();
            

            IWebElement languageLevelOption = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));

            Wait.WaitForvisible(driver, "Xpath", "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]", 2);

            languageLevelOption.Click();

            //Identify and click the add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();

            //


            //Identify Skills Tab and click it

            IWebElement skillTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();

            //Identify Addnew button and click

            IWebElement addNewSkillbutton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewSkillbutton.Click();
            Thread.Sleep(1000);

            //Identify Add Skill box and enter valid skill details

            IWebElement addSkill = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            Thread.Sleep(1000);
            addSkill.SendKeys("Painting");



            //Identify and click skill level dropdown button and select the skill level
            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevelDropdown.Click();

            IWebElement skillLevelOption = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            skillLevelOption.Click();

            //Identify and click the skill Add button
            IWebElement skillAddButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            skillAddButton.Click();





            //

            //Identify Education Tab and click it

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();

            //Identify and click the add new button

            IWebElement educationAddnewbutton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            educationAddnewbutton.Click();
            Thread.Sleep(1000);


            //Identify and input the college details
            IWebElement collegeUniName = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            Thread.Sleep(1000);
            collegeUniName.SendKeys("AUT");

            //Identify country dropdown box and select the country
            IWebElement countryDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countryDropdown.Click();

            IWebElement countryOption = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
            countryOption.Click();

            //Identify the graduate title and select the title option
            IWebElement titleDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropdown.Click();

            IWebElement titleOption = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[6]"));
            titleDropdown.Click();

            //Identify the degree qualification box and enter valid details
            IWebElement degreeQualification = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreeQualification.SendKeys("Degree");

            //Identify the year of graduation and select the details
            IWebElement yearOfGraduationdropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearOfGraduationdropdown.Click();

            IWebElement yearOfGraduationoption = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[9]"));
            yearOfGraduationoption.Click();

            //Identify and click the education Add button
            IWebElement addEducationbutton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addEducationbutton.Click();




            //


            //Identify Certification Tab and click it

            IWebElement certificationTab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationTab.Click();

            //Identify Addnew certification button and click

            IWebElement addNewCertification = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewCertification.Click();
            Thread.Sleep(1000);

            //Identify Add certification box and enter valid certification details

            IWebElement addCertification = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            Thread.Sleep(1000);
            addCertification.SendKeys("Diploma");



            //Identify and add the certified from box
            IWebElement certifiedFrom = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certifiedFrom.SendKeys("Microsoft");

            //Identify and select the year of achievement
            
            IWebElement yearDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            yearDropdown.Click();

            IWebElement yearOption = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[9]"));
            yearOption.Click();
            

            //Identify and click the Certification Add button
            IWebElement certificationAddButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            certificationAddButton.Click();


















        }
    }
}
