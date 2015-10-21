using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class SeleniumSetMethods
    {
        /// <summary>
        /// Set my values in Elements
        /// </summary>
        /// <param name="pDriver"></param>
        /// <param name="pElement"></param>
        /// <param name="pValue"></param>
        /// <param name="pElementType"></param>
        public static void EnterText(IWebDriver pDriver, string pElementIdentifier, string pValue, string pElementType)
        {
            IWebElement element = getMyElement(pDriver, pElementIdentifier, pElementType);
            if (element != null)
                element.SendKeys(pValue);
        }

        /// <summary>
        /// We look for an element, and then perform a Click on it
        /// </summary>
        /// <param name="pDriver"></param>
        /// <param name="pElementIdentifier"></param>
        /// <param name="pElementType"></param>
       
        public static void PerformClick(IWebDriver pDriver, string pElementIdentifier, string pElementType)
        {
            IWebElement element = getMyElement(pDriver, pElementIdentifier, pElementType);
            if (element != null)
                element.Click();
        }

        /// <summary>
        /// We look for the drop down list element, and set the value on it
        /// </summary>
        /// <param name="pDriver"></param>
        /// <param name="pElementIdentifier"></param>
        /// <param name="pValue"></param>
        /// <param name="pElementType"></param>
        public static void SelectDropDown(IWebDriver pDriver, string pElementIdentifier, string pValue, string pElementType)
        {
            SelectElement dropDown = new SelectElement(getMyElement(pDriver, pElementIdentifier, pElementType));
            if (dropDown != null)
                dropDown.SelectByText(pValue);
        }

        /// <summary>
        /// We look for an element, if we dont find it we return NULL
        /// </summary>
        /// <param name="pDriver"></param>
        /// <param name="pElementIdentifier"></param>
        /// <param name="pValue"></param>
        /// <param name="pElementType">Name or Id</param>
        /// <returns></returns>
        private static IWebElement getMyElement(IWebDriver pDriver, string pElementIdentifier, string pElementType)
        {
            IWebElement element;

            switch (pElementType)
            {
                case "Id":
                    element = pDriver.FindElement(By.Id(pElementIdentifier));
                    break;
                case "Name":
                    element = pDriver.FindElement(By.Name(pElementIdentifier));
                    break;
                default:
                    element = null;
                    break;
            }

            return element;
        }

    }
}
