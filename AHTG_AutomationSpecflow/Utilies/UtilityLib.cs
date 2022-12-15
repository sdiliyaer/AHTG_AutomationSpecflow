using AHTG_AutomationSpecflow.StepDefinitions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHTG_AutomationSpecflow.Utilies
{
    class UtilityLib : Hooks
    {


        public IWebElement Wait(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Element = wait.Until(e => e.FindElement(by));
            return Element;
        }

        public IWebElement FluentWait(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(30))
            {
                PollingInterval = TimeSpan.FromSeconds(5),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            var Element = wait.Until(drv => drv.FindElement(by));
            return Element;
        }

        public static String GetConfigurationValue(String key)
        {
            var value = ConfigurationManager.AppSettings[key];
            return value;
        }
        public Boolean VerifyIfImageExist(IWebElement element)
        {
            // Javascript executor to check image
            Boolean imageExist = (Boolean)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].complete " + "&& typeof arguments[0].naturalWidth != \"undefined\" " + "&& arguments[0].naturalWidth > 0", element);
            return imageExist;
        }


    }
}
