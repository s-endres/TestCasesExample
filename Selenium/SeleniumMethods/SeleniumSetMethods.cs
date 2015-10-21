using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.SeleniumMethods
{
    public static class SeleniumSetMethods
    {
        public static void setElementValue(this IWebElement pElement, string pValue, ElementType pElementType)
        {
            switch (pElementType)
            {
                case ElementType.TextInput:
                    pElement.SendKeys(pValue);
                    break;
                case ElementType.Ddl:
                    new SelectElement(pElement).SelectByText(pValue);
                    break;
                case ElementType.RadioBtn:
                    break;
                case ElementType.Btn:
                    break;
                case ElementType.CheckBox:
                    break;
                default:
                    break;
            }
        }
    }
}
