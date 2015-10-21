using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.SeleniumMethods
{
    public static class SeleniumGetMethods
    {
        public static string getElementValue(this IWebElement pElement, ElementType pElementType)
        {
            string result;
            switch (pElementType)
            {
                case ElementType.TextInput:
                    result = pElement.GetAttribute("value");
                    break;
                case ElementType.Ddl:
                    result = new SelectElement(pElement).SelectedOption.Text;
                    break;
                case ElementType.RadioBtn:
                    result = "";
                    break;
                case ElementType.Btn:
                    result = "";
                    break;
                case ElementType.CheckBox:
                    result = "";
                    break;
                default:
                    result = "";
                    break;
            }

            return result;

        }
    }
}
