using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

                                                  
namespace MarsQA_1.SpecflowPages.Pages
{
   public class LoginPage
    {
        public void LoginSteps(string username, string password)
        {

            //Click on SignIn link
            Driver.driver.FindElement(By.XPath("//*[@class='ui secondary menu inverted']/div/a")).Click();
            Driver.TurnOnWait();

            //Driver.webDriver.SwitchTo().Window(Driver.webDriver.WindowHandles.Last());


            //Enter Username
            IWebElement Username = Driver.driver.FindElement(By.Name("email"));
            Username.Click();
            Username.Clear();
            Username.SendKeys("username");

            //Enter password
            IWebElement Password = Driver.driver.FindElement(By.Name("password"));
            Password.Click();
            Password.Clear();
            Password.SendKeys("password");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//*[@class='fluid ui teal button']")).Click();
        }
    }
}
