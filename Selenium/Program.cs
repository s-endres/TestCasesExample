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
            //Create reference for our browser
            IWebDriver driver = new ChromeDriver();
            // ó IWebDriver driver = new FirefoxDriver();

            //Go to google.com
            driver.Navigate().GoToUrl("http://www.google.com");

            //Get the element
            IWebElement element = driver.FindElement(By.Id("lst-ib"));

            //Perform Ops
            element.SendKeys("Hello World");

        }
    }
}
