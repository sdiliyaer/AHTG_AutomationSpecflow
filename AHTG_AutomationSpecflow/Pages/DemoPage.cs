using AHTG_AutomationSpecflow.Utilies;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHTG_AutomationSpecflow.Pages
{
    class DemoPage : UtilityLib
    {
        public IWebDriver Driver { get; }
        public DemoPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement NameInput => Driver.FindElement(By.Id("Full-Name"));

        public IWebElement EmailInput => Driver.FindElement(By.Id("Email"));

        public IWebElement AboutUsBtn => Driver.FindElement(By.XPath("//div[@class='dropdown-text' and text()='about us']"));
        public IWebElement OurTeamBtn => Driver.FindElement(By.XPath("//a[@href='/our-team' and contains(text(),'team')]"));


        public String GetNameInputText()
        {
            return NameInput.GetAttribute("placeholder").ToString();
        }
        public String GetEmailInputText()
        {
            return EmailInput.GetAttribute("placeholder").ToString();
        }


        public void GoToOurTeamPage()
        {
            AboutUsBtn.Click();
            OurTeamBtn.Click();
        }

    }
}
