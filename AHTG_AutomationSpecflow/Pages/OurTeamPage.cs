using AHTG_AutomationSpecflow.Utilies;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AHTG_AutomationSpecflow.Pages
{
    class OurTeamPage : UtilityLib
    {

        public IWebDriver Driver;
        public OurTeamPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement EmployeeImage(String name) => FluentWait(By.XPath("//h3[text()='" + name + "']/../..//img[@class='testimonial-picture']"));
        public IWebElement ViewMoreBtns(String name) => FluentWait(By.XPath("//div[text()='View More']/../h3[text()='" + name + "']"));
        public IWebElement Paragraph(String name) => FluentWait(By.XPath("//h1[text()='" + name + "']/..//p"));

        public IWebElement OurProductsBtn => FluentWait(By.XPath("//div[contains(text(),'our products')]"));

        public Boolean VerifyImageDisplay(String name)
        {
            // Javascript executor to check image
            Boolean imageExist = VerifyIfImageExist(EmployeeImage(name));
            // verify if it is exist
            if (imageExist)
            {
                Console.WriteLine("Image present");
            }
            else
            {
                Console.WriteLine("Image not present");
            }
            return imageExist;
        }

        public void ClickViewMoreBtn(String name)
        {
            ViewMoreBtns(name).Click();
        }
        public Boolean VerifyMoreDetails(String name)
        {
            String[] wholeName = name.Split(' ');
            String firstName = wholeName[0].ToLower();
            String LastName = wholeName[1].ToLower();
            // verify the Url contains the first last name
            Assert.IsTrue(Driver.Url.Contains(firstName + "-" + LastName), "Value is: '" + firstName + "-" + LastName);
            // return boolean of whether more details/paragraph displayed with name
            return Paragraph(name).Enabled;
        }
        public void ClickOurProductBtn()
        {
            OurProductsBtn.Click();
        }
    }
}
