using AHTG_AutomationSpecflow.Pages;
using AHTG_AutomationSpecflow.Utilies;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AHTG_AutomationSpecflow.StepDefinitions
{
    [Binding]
    public class RequestDemo_FeatureSteps : Hooks
    {
        readonly Page pages = new Page(driver);

        [Given(@"User is at Home Page")]
        public void GivenUserIsAtHomePage()
        {
            pages.homePage.GoToHomePage();
        }

        [When(@"Click Request a demo button")]
        public void WhenClickRequestADemoButton()
        {
            pages.homePage.ClickReqDemoBtn();
        }

        [Then(@"User will be navigate to Request demo page")]
        public void ThenUserWillBeNavigateToRequestDemoPage()
        {
            // ScenarioContext.Current.Pending();
        }

        [Then(@"Name box should have value of ""(.*)"" as default text")]
        public void ThenNameBoxShouldHaveValueOfAsDefaultText(string name)
        {
            Assert.AreEqual(name, pages.demoPage.GetNameInputText());
        }

        [Then(@"Email box should have value of ""(.*)"" as default text")]
        public void ThenEmailBoxShouldHaveValueOfAsDefaultText(string email)
        {
            Assert.AreEqual(email, pages.demoPage.GetEmailInputText());
        }

        [When(@"Click about us button And Click Our team button")]
        public void WhenClickAboutUsButtonAndClickOurTeamButton()
        {
            pages.demoPage.GoToOurTeamPage();
        }


        [Then(@"User should be able to see images for employees")]
        public void ThenUserShouldBeAbleToSeeImagesForEmployees(Table table)
        {
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(pages.ourTeamPage.VerifyImageDisplay(row["FirstName"] + " " + row["LastName"]));
            }

        }

        [When(@"Click view more button under employee ""(.*)""")]
        public void WhenClickViewMoreButtonUnderEmployee(string name)
        {
            pages.ourTeamPage.ClickViewMoreBtn(name);
        }

        [Then(@"User should be able to see a page with more details for ""(.*)""")]
        public void ThenUserShouldBeAbleToSeeAPageWithMoreDetailsFor(string name)
        {
            Assert.IsTrue(pages.ourTeamPage.VerifyMoreDetails(name));
        }

        [When(@"Click our products button")]
        public void WhenClickOurProductsButton()
        {
            pages.ourTeamPage.ClickOurProductBtn();
        }

        [Then(@"Verify the products with a request demo button")]
        public void ThenVerifyTheProductsWithARequestDemoButton(Table table)
        {
            foreach (var row in table.Rows)
            {
                pages.ourProductPage.GetText(row["Product"]);
            }
            pages.ourProductPage.VerifyRequestDemoBtn();
        }

    }
}
