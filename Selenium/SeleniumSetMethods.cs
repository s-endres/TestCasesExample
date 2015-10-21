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
        /// <param name="GlobalMethods.driver"></param>
        /// <param name="pElement"></param>
        /// <param name="pValue"></param>
        /// <param name="pElementType"></param>
        public static void EnterText(string pElementIdentifier, string pValue, ElementType pElementType)
        {
            IWebElement element = GlobalMethods.getMyElement(pElementIdentifier, pElementType);
            if (element != null)
                element.SendKeys(pValue);
        }

        /// <summary>
        /// We look for an element, and then perform a Click on it
        /// </summary>
        /// <param name="GlobalMethods.driver"></param>
        /// <param name="pElementIdentifier"></param>
        /// <param name="pElementType"></param>

        public static void PerformClick(string pElementIdentifier, ElementType pElementType)
        {
            IWebElement element = GlobalMethods.getMyElement(pElementIdentifier, pElementType);
            if (element != null)
                element.Click();
        }

        /// <summary>
        /// We look for the drop down list element, and set the value on it
        /// </summary>
        /// <param name="GlobalMethods.driver"></param>
        /// <param name="pElementIdentifier"></param>
        /// <param name="pValue"></param>
        /// <param name="pElementType"></param>
        public static void SelectDropDown(string pElementIdentifier, string pValue, ElementType pElementType)
        {
            SelectElement dropDown = new SelectElement(GlobalMethods.getMyElement(pElementIdentifier, pElementType));
            if (dropDown != null)
                dropDown.SelectByText(pValue);
        }


    }
}
