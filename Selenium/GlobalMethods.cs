using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    static class GlobalMethods
    {
        /// <summary>
        /// We look for an element, if we dont find it we return NULL
        /// </summary>
        /// <param name="pDriver"></param>
        /// <param name="pElementIdentifier"></param>
        /// <param name="pValue"></param>
        /// <param name="pElementType">Name or Id</param>
        /// <returns></returns>
        public static IWebElement getMyElement(IWebDriver pDriver, string pElementIdentifier, string pElementType)
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
