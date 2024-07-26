using Microsoft.Playwright;

namespace Playwright_SpecFlow_MSTest_UI.Pages.MainPage
{
    public class LandingPage(Hooks.Hook hook)
    {
        private readonly IPage Page = hook.Page;

        private ILocator LandingPageHeader_lbl => Page.GetByRole(AriaRole.Link, new() { Name = "My Shop" });
        private ILocator SignIn_lnk => Page.GetByRole(AriaRole.Link, new() { Name = "Sign in" });      
        private ILocator Search_txt => Page.GetByPlaceholder("Search");      
        private ILocator Search_icn => Page.GetByRole(AriaRole.Button, new() { Name = "" });

        public async Task VerifyLandingPageDisplayed()
        {
            await Assertions.Expect(LandingPageHeader_lbl).ToBeVisibleAsync();
        }
        public async Task ClickOnSignInLink()
        {
            await SignIn_lnk.ClickAsync();
        }

        public async Task BrowseApplicationURL()
        {
            string url = "http://www.automationpractice.pl/index.php";
            await Page.GotoAsync(url);
        }

        public async Task FillSearchTextInLandingPage(string text)
        {
            await Search_txt.FillAsync(text);
        }
        public async Task ClickOnSearchIconInLandingPage()
        {
            await Search_icn.ClickAsync();
        }
    }
}
