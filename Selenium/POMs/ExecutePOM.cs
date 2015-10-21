using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Selenium.SeleniumMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class ExecutePOM
    {

        public ExecutePOM()
        {
            PageFactory.InitElements(Global.driver, this);
        }

        [FindsBy(How = How.Id,Using="TitleId")]
        public IWebElement ddlTitle { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }
        
        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }


        public ExecutePOM FillUserForm(string pInitial, string pFirstName, string pMiddleName, string pTitle)
        {
            SeleniumSetMethods.setElementValue(txtInitial, pInitial, ElementType.TextInput);
            SeleniumSetMethods.setElementValue(txtFirstName, pFirstName, ElementType.TextInput);
            SeleniumSetMethods.setElementValue(txtMiddleName, pMiddleName, ElementType.TextInput);
            SeleniumSetMethods.setElementValue(ddlTitle, pTitle, ElementType.Ddl);
            
            btnSave.Click(); // ó btnSave.Submit();

            return new ExecutePOM();
        }

        public string UserFormToString()
        {
            string result;

            result = SeleniumGetMethods.getElementValue(txtInitial, ElementType.TextInput)+",";
            result += SeleniumGetMethods.getElementValue(txtFirstName, ElementType.TextInput) + ",";
            result += SeleniumGetMethods.getElementValue(txtMiddleName, ElementType.TextInput) + ",";
            result += SeleniumGetMethods.getElementValue(ddlTitle, ElementType.Ddl);

            return result;
        }

    }
}
