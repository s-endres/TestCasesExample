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
            Global.driver = new ChromeDriver();
            Global.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection(@"C:\Data.xlsx");
            LoginPOM loginPage = new LoginPOM();

            ExecutePOM EApage = loginPage.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));

            EApage.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "FirstName"), ExcelLib.ReadData(1, "MiddleName"), "Mr.");
            Console.WriteLine(EApage.UserFormToString());

        }

        [TearDown]
        public void cleanUp()
        {
            Global.driver.Close();
        }
    }
}
