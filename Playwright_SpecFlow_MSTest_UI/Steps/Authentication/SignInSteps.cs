using Microsoft.Playwright;
using Playwright_SpecFlow_MSTest_UI.Pages.Authentication;
using TechTalk.SpecFlow;

namespace Playwright_SpecFlow_MSTest_UI.Steps.Authentication
{
    [Binding]
    public class SignInSteps(SignInPage sgnInPage)
    {
        private readonly SignInPage signInPage = sgnInPage;

        [Then(@"User must see Authentication page displayed")]
        public async Task ThenUserMustSeeAuthenticationPageDisplayed()
        {
            await signInPage.VerifyAutheticationPageDisplayed();
        }

        [When(@"User provides sign in details and click on SignIn button")]
        public async Task WhenUserProvideSignInDetailsAndClickOnSignInButton()
        {
            await signInPage.TypeSignInDetailsAndClickSignInBtn();
        }
    }
}
