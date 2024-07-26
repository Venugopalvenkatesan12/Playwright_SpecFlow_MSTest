using Microsoft.Playwright;
using Playwright_SpecFlow_MSTest_UI.Pages.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Playwright_SpecFlow_MSTest_UI.Steps.MainPage
{
    [Binding]
    public class LandingPageSteps(LandingPage lndgPage)
    {
        private readonly LandingPage landingPage = lndgPage;

        [Given(@"User browses the application url")]
        public async Task GivenUserBrowseTheApplicationUrl()
        {
            await landingPage.BrowseApplicationURL();

            await landingPage.VerifyLandingPageDisplayed();
        }

        [When(@"User clicks on Sign in link in Landing page")]
        public async Task WhenUserClickOnSignInLinkInLandingPage()
        {
            await landingPage.ClickOnSignInLink();
        }
        [When(@"User provides search text '([^']*)' in Landing page")]
        public async void WhenUserProvidesSearchTextInLandingPage(string searchTxt)
        {
            await landingPage.FillSearchTextInLandingPage(searchTxt);
        }

        [When(@"User clicks on Search icon in Landing page")]
        public async void WhenUserClicksOnSearchIconInLandingPage()
        {
            await landingPage.ClickOnSearchIconInLandingPage();
        }

    }
}
