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
            txtInitial.setElementValue(pInitial, ElementType.TextInput);
            txtFirstName.setElementValue(pFirstName, ElementType.TextInput);
            txtMiddleName.setElementValue(pMiddleName, ElementType.TextInput);
            ddlTitle.setElementValue(pTitle, ElementType.TextInput);
            
            btnSave.Click(); // ó btnSave.Submit();

            return new ExecutePOM();
        }

        public string UserFormToString()
        {
            string result;

            result = txtInitial.getElementValue(ElementType.TextInput)+",";
            result += txtFirstName.getElementValue(ElementType.TextInput) + ",";
            result += txtMiddleName.getElementValue(ElementType.TextInput) + ",";
            result += ddlTitle.getElementValue(ElementType.Ddl);

            return result;
        }

    }
}
