using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using System.Threading;
using static MarsQA_1.Helpers.CommonMethods;


namespace MarsQA_1.SpecflowPages.Pages
{
    public class ProfilePage
    {
        //Click on the Menu links
        public void clickMenuOptions(string menuOptions)
        {
            var clickMenu = new ProfilePage();
            var barXpath = "//*[@class='ui top attached tabular menu']/a[text()[normalize-space(.)='" + menuOptions + "']]";
            IWebElement _menuClickoption = clickMenu.MenuBarOptions(barXpath);
            _menuClickoption.Click();

        }

        //Function to find menu options 
        public IWebElement MenuBarOptions(string menuOptionLocator)
        {

            var toolMenu = Driver.driver.FindElement(By.XPath(menuOptionLocator));
            return toolMenu;

        }

        //Click on Add New button to enter the item into profile
        public void clickAddNew(string addNewItem)
        {
            switch (addNewItem)
            {
                case "Languages":
                case "Skills":
                    Driver.TurnOnWait();
                    IWebElement addNew = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table/thead/tr/th[3]/div"));
                    addNew.Click();
                    break;

                case "Education":
                    Driver.TurnOnWait();
                    IWebElement addNewEducation = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table/thead/tr/th[6]/div"));
                    addNewEducation.Click();
                    break;

                case "Certifications":
                    Driver.TurnOnWait();
                    IWebElement addNewCertifications = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table/thead/tr/th[4]/div"));
                    addNewCertifications.Click();

                    break;

            }

        }

        //Adding New Language
        public void addNewLanguage(string language, string languageLevel)
        {
            //Enter value in Add Language field
            IWebElement addLanguageName = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[1]/input"));
            addLanguageName.Clear();
            addLanguageName.Click();
            addLanguageName.SendKeys(language);

            //Select value for level
            IWebElement DropDownList = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[2]//select"));
            IList<IWebElement> options = DropDownList.FindElements(By.TagName("option"));
            int optionCount = options.Count();
            for (int i = 0; i < optionCount; i++)
            {
                if (options[i].Text == languageLevel)
                {
                    options[i].Click();
                }
            }

            //Click Add Button after enter the lanaguage and language level
            IWebElement clickAdd = Driver.driver.FindElement(By.XPath("//*[@class='six wide field']/input[1]"));
            clickAdd.Click();
            Thread.Sleep(5000);

        }

        //Verify Language is added successfully
        public void rowPresent(string language)
        {
            bool LanguageFound = false;
            IWebElement tableElement = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));

            foreach (IWebElement row in tableRow)
            {
                var p = row.Text;
                if (row.Text.Contains(language))
                {
                    LanguageFound = true;
                    SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "LanguageAdded");
                    //CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    break;
                }
            }
        }

        //Delete the added language
        public void deleteLanguage(string language)
        {
            var deleteLanguage = new ProfilePage();
            var barXpath = "//tr[.//td='" + language + "']/td[3]/span[2]/i";
            IWebElement _menuClickoption = deleteLanguage.deleteLanguageOptions(barXpath);
            _menuClickoption.Click();
            Thread.Sleep(5000);
            Driver.driver.SwitchTo().DefaultContent();

        }

        //function to find menu options 
        public IWebElement deleteLanguageOptions(string menuOptionLocator)
        {

            var toolMenu = Driver.driver.FindElement(By.XPath(menuOptionLocator));
            return toolMenu;

        }

        //Verify Langauge is deleted from profile
        public void languageDeletedConfirm(string langauge)
        {
            bool languagePresent = false;
            IWebElement tableElement = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            foreach (IWebElement row in tableRow)
            {
                var p = row.Text;

                if (row.Text.Contains(langauge))
                {
                    languagePresent = true;
                    SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "LanguageNotDeleted");

                }
            }

            languagePresent = false;
            SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "LanguageDeleted");

        }

        //Adding a New SKill
        public void AddNewSkill(string skill, string skillLevel)
        {
            //Enter value in Add skill field
            IWebElement addSkill = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[1]/input"));
            addSkill.Clear();
            addSkill.Click();
            addSkill.SendKeys(skill);

            //Select value for level
            IWebElement DropDownList = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[2]//select"));
            IList<IWebElement> options = DropDownList.FindElements(By.TagName("option"));
            int optionCount = options.Count();
            for (int i = 0; i < optionCount; i++)
            {
                if (options[i].Text == skillLevel)
                {
                    options[i].Click();
                }

            }

            //Click Add Button after enter skill and skill level
            IWebElement clickAdd = Driver.driver.FindElement(By.XPath("//*[@class='buttons-wrapper']/input[1]"));
            clickAdd.Click();
            Thread.Sleep(5000);
        }

        //Verify the Skill is added
        public void rowSkillPresent(string skill)
        {

            bool skillPresent = false;
            IWebElement tableElement = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("td"));

            foreach (IWebElement row in tableRow)
            {
                var p = row.Text;
                if (row.Text.Contains(skill))
                {
                    skillPresent = true;
                    SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "SkillAdded");
                    //CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");

                    break;
                }
                else
                skillPresent = false;
                SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "SkillNotAdded");
                //CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Failed to Add a Language Successfully");


            }

        }


        //Adding new Education
        public void addNewEducation(string college, string country, string title, string degree, string year)
        {

            //Enter value in College/University name field  
            IWebElement addCollege = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[1]/div[1]/input"));
            addCollege.Clear();
            addCollege.Click();
            addCollege.SendKeys(college);

            // Select a value for Country
            IWebElement DropDownListCountry = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[1]/div[2]/select"));
            IList<IWebElement> optionsCountry = DropDownListCountry.FindElements(By.TagName("option"));
            int optionCountCountry = optionsCountry.Count();
            for (int i = 0; i < optionCountCountry; i++)
            {
                if (optionsCountry[i].Text == country)
                {
                    optionsCountry[i].Click();
                    break;
                }

            }

            //Select a value for Title
            IWebElement DropDownListTitle = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[2]/div[1]/select"));
            IList<IWebElement> optionsTitle = DropDownListTitle.FindElements(By.TagName("option"));
            int optionCountTitle = optionsTitle.Count();
            for (int i = 0; i < optionCountTitle; i++)
            {
                if (optionsTitle[i].Text == title)
                {
                    optionsTitle[i].Click();
                    break;
                }

            }

            //Enter a value in Degree field
            IWebElement addDegree = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/div/div[2]/div[2]/input"));
            addDegree.Clear();
            addDegree.Click();
            addDegree.SendKeys(degree);


        }

        //Verify Education is added
        public void rowEducationPresent(string college, string country)
        {

            bool educationPresent = false;
            IWebElement tableElement = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));

            foreach (IWebElement row in tableRow)
            {
                var p = row.Text;
                if (row.Text.Contains(college) && row.Text.Contains(country))
                {
                    educationPresent = true;
                    SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "EducationAdded");
                    //CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    break;
                }

            }
            educationPresent = false;
            SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "EducationNotAdded");
            //CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Failed to Add a Language Successfully");

        }

        public void addNewCertificate(string certificate, string certFrom, string year)
        {
            //Enter value in Add Certificate field
            IWebElement addCertificate = Driver.driver.FindElement(By.Name("certificationName"));
            addCertificate.Clear();
            addCertificate.Click();
            addCertificate.SendKeys(certificate);

            //Add Certifiacte From
            IWebElement addCertificateFrom = Driver.driver.FindElement(By.Name("certificationFrom"));
            addCertificateFrom.Clear();
            addCertificateFrom.Click();
            addCertificateFrom.SendKeys(certFrom);

            //Select value for year
            IWebElement DropDownList = Driver.driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']"));
            IList<IWebElement> options = DropDownList.FindElements(By.TagName("option"));
            int optionCount = options.Count();
            for (int i = 0; i < optionCount; i++)
            {
                if (options[i].Text == year)
                {
                    options[i].Click();
                    break;
                }

            }


            //Click Add button after enter the Certificate details
            IWebElement clickAdd = Driver.driver.FindElement(By.XPath("//*[@class='six wide field']/input[1]"));
            clickAdd.Click();
            Thread.Sleep(5000);
        }


        //Verify Certificate is added
        public void rowCertificatePresent(string certificate)
        {

            bool certificatePresent = false;
            IWebElement tableElement = Driver.driver.FindElement(By.XPath("//*[contains(@class,'active') and contains(@class, 'tab')]/div/div[2]/div/table"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("td"));

            foreach (IWebElement row in tableRow)
            {
                var p = row.Text;
                if (row.Text.Contains(certificate))
                {
                    certificatePresent = true;
                    SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "CertificateAdded");
                    //CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");

                    break;
                }

            }
            certificatePresent = false;
            SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "CertificateNotAdded");
            //CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Failed to Add a Language Successfully");
        }

    }

}


