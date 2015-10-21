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
        public static IWebDriver driver { get; set; }

        /// <summary>
        /// We look for an element, if we dont find it we return NULL
        /// </summary>
        /// <param name="pDriver"></param>
        /// <param name="pElementIdentifier"></param>
        /// <param name="pValue"></param>
        /// <param name="pElementType"></param>
        /// <returns></returns>
        public static IWebElement getMyElement(string pElementIdentifier, ElementType pElementType)
        {
            IWebElement element;

            switch (pElementType)
            {
                case ElementType.Id:
                    element = GlobalMethods.driver.FindElement(By.Id(pElementIdentifier));
                    break;
                case ElementType.Name:
                    element = GlobalMethods.driver.FindElement(By.Name(pElementIdentifier));
                    break;
                default:
                    element = null;
                    break;
            }

            return element;
        }
    }
}
