using AHTG_AutomationSpecflow.Utilies;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHTG_AutomationSpecflow.Pages
{
    class HomePage : UtilityLib
    {
        public IWebDriver Driver { get; }
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }


        public IWebElement ReqDemoBtn => FluentWait(By.XPath("//div[@class='split-content hero']//a[@href='/request-demo']"));

        public void GoToHomePage()
        {
            Driver.Url = GetConfigurationValue("Url");
        }

        public void ClickReqDemoBtn() => ReqDemoBtn.Click();

    }
}
