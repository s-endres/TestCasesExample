using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class EAPageObject
    {

        public EAPageObject()
        {
            PageFactory.InitElements(GlobalMethods.driver, this);
        }

        [FindsBy(How = How.Id,Using="TitleId")]
        public IWebElement ddlTitle { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }



    }
}
