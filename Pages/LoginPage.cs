using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mars01.Pages
{
    internal class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            //Open Mars web page
            driver.Navigate().GoToUrl("http://localhost:5000/");
            

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

            //IWebElement hiIndika = driver.FindElement(By.CssSelector(".item ui dropdown link"));
            IWebElement hiIndika = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/span"));

            if (hiIndika.Text == "Hi Indika")
            {
                Console.WriteLine("Logged in successfull. Test passed");

            }
            else
            {
                Console.WriteLine("Login Failed. Test failed");

            }


        }
    }
}
