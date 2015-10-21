using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class SeleniumGetMethods
    {
        /// <summary>
        /// We get the value of an element.
        /// </summary>
        /// <param name="pDriver"></param>
        /// <param name="pElementIdentifier"></param>
        /// <param name="pElementType"></param>
        /// <returns></returns>
        public static string getElementText(IWebDriver pDriver, string pElementIdentifier, string pElementType)
        {
            IWebElement element = GlobalMethods.getMyElement(pDriver, pElementIdentifier, pElementType);
            return element.GetAttribute("value");
            
        }

        /// <summary>
        /// We get the selected value of a Drop Down List
        /// </summary>
        /// <param name="pDriver"></param>
        /// <param name="pElementIdentifier"></param>
        /// <param name="pElementType"></param>
        /// <returns></returns>
        public static string getDDLText(IWebDriver pDriver, string pElementIdentifier, string pElementType)
        {
            SelectElement element = new SelectElement(GlobalMethods.getMyElement(pDriver, pElementIdentifier, pElementType));
            return element.SelectedOption.Text;

        }
    }
}
