using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace Playwright_SpecFlow_MSTest_UI.Hooks
{
    [Binding]
    public sealed class Hook
    {
        public IPage Page { get; set; } = null!;

        [BeforeScenario]
        public async Task RegisterSingleInstance()
        {
            // Initialize the playwright driver.
            var pw = await Playwright.CreateAsync();

            // Launch the browser instance.
            var browser = await pw.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            // Setup browser context.
            var browserContext = await browser.NewContextAsync();

            // Create the page in the browser context.
            Page = await browserContext.NewPageAsync();
        }
    }
}