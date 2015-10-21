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
        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            GlobalMethods.driver = new ChromeDriver();
            GlobalMethods.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
        }

        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", ElementType.Id);
            SeleniumSetMethods.EnterText("Initial", "Boom!", ElementType.Name);
            SeleniumSetMethods.PerformClick("Save", ElementType.Name);

            string textSelect = SeleniumGetMethods.getDDLText("TitleId", ElementType.Id);
            string textInput = SeleniumGetMethods.getElementText("Initial", ElementType.Name);

            Console.WriteLine("First text: " + textSelect + " - Second text: " + textInput);
        }

        [TearDown]
        public void cleanUp()
        {
            GlobalMethods.driver.Close();
        }
    }
}
