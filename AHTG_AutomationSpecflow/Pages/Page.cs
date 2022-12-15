using AHTG_AutomationSpecflow.StepDefinitions;
using AHTG_AutomationSpecflow.Utilies;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHTG_AutomationSpecflow.Pages
{
    class Page:Hooks
    {
        public IWebDriver Driver { get; }
        public Page(IWebDriver driver)
        {
            Driver = driver;
        }
        public HomePage homePage = new HomePage(driver);
        public DemoPage demoPage = new DemoPage(driver);
        public OurTeamPage ourTeamPage = new OurTeamPage(driver);
        public OurProductPage ourProductPage = new OurProductPage(driver);
    }
}
