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
            //Initialize the page
            EAPageObject page = new EAPageObject();
            page.txtInitial.SendKeys("Boom!");
            page.btnSave.Click();

        }

        [TearDown]
        public void cleanUp()
        {
            GlobalMethods.driver.Close();
        }
    }
}
