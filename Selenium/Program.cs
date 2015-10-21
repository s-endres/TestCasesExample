using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
        }

        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            SeleniumSetMethods.EnterText(driver, "Initial", "Boom!", "Name");
            SeleniumSetMethods.PerformClick(driver, "Save", "Name");

            string textSelect = SeleniumGetMethods.getDDLText(driver, "TitleId", "Id");
            string textInput = SeleniumGetMethods.getElementText(driver, "Initial", "Name");

            Console.WriteLine("First text: " + textSelect + " - Second text: " + textInput);
        }

        [TearDown]
        public void cleanUp()
        {
            driver.Close();
        }
    }
}
