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
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement element = driver.FindElement(By.Id("lst-ib"));
            element.SendKeys("Hello World");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Here goes the second test");
        }

        [TearDown]
        public void cleanUp()
        {
            driver.Close();
        }
    }
}
