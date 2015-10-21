using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class LoginPOM
    {

        public LoginPOM()
        {
            PageFactory.InitElements(Global.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public ExecutePOM Login(string pUserName, string pPassword)
        {
            txtUserName.SendKeys(pUserName);
            txtPassword.SendKeys(pPassword);
            btnLogin.Submit(); // Tiene que se .Submit() para que redireccione la pagina

            return new ExecutePOM();
        }
    }
}
