using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace AHTG_AutomationSpecflow.Utilies
{
    [Binding]
    public class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public static IWebDriver driver;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Before Test Run...");
            driver = new ChromeDriver();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["PageLoad"]));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["ImplicitWait"]));
            driver.Manage().Window.Maximize();

        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Thread.Sleep(1000);
            if (driver != null)
            {
            driver.Close();
            driver.Quit();
            }
        
            Console.WriteLine("After Test Run...");
        }
    }
}
