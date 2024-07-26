using Microsoft.Playwright;

namespace Playwright_SpecFlow_MSTest_UI.Pages.Search
{
    public class SearchResultGridPage(Hooks.Hook hook)
    {
        private readonly IPage Page = hook.Page;

        private ILocator ResultCount_lbl => Page.Locator("h1");
        private ILocator ResultShowingCount_lbl => Page.Locator("#center_column");

        public async Task VerifyCountInResultGrid(string text)
        {
            await Assertions.Expect(ResultCount_lbl).ToContainTextAsync(text);
        }

        public async Task VerifyResultShowingCountInResultGrid(string text)
        {
            await Assertions.Expect(ResultShowingCount_lbl).ToContainTextAsync(text);
        }

        public async Task VerifySearchTextInProductDescription(string text)
        {
            await Assertions.Expect(ResultShowingCount_lbl).ToContainTextAsync(text);
        }
    }
}
