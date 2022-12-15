using AHTG_AutomationSpecflow.Utilies;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHTG_AutomationSpecflow.Pages
{
    class OurProductPage : UtilityLib
    {
        public IWebDriver Driver;
        public OurProductPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement ProductTrio => FluentWait(By.XPath("(//div[@class='subtitle small']/..//h2)[1]"));
        public IWebElement ProductInsight => FluentWait(By.XPath("(//div[@class='subtitle small']/..//h2)[2]"));

        public IWebElement RequestDemoBtn => FluentWait(By.XPath("//h2[text()='Request a Demo Today']/..//a[@href='/request-demo']"));
        public void GetText(String product)
        {
            Assert.True(product.Contains(ProductTrio.Text) || product.Contains(ProductInsight.Text), "product table : '" + product + "=" + ProductTrio.Text + " or " + ProductInsight.Text);
        }

        public void VerifyRequestDemoBtn()
        {
            Assert.IsTrue(RequestDemoBtn.Size != null);
            Assert.IsTrue(RequestDemoBtn.Enabled);
        }
    }
}
