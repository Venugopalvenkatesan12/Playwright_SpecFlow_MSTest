using Playwright_SpecFlow_MSTest_UI.Pages.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Playwright_SpecFlow_MSTest_UI.Steps.Search
{
    [Binding]
    public class SearchResultGridSteps(SearchResultGridPage searchResultGridPage)
    {
        [Then(@"User must see '([^']*)' text in results grid in Search page")]
        public async Task ThenUserMustSeeTextInResultsGridInSearchPage(string searchText)
        {
            await searchResultGridPage.VerifyCountInResultGrid(searchText);
        }

        [Then(@"User must see text '([^']*)' in the product description in Search page")]
        public async Task ThenUserMustSeeTextInTheProductDescriptionInSearchPage(string searchText)
        {
            await searchResultGridPage.VerifySearchTextInProductDescription(searchText);
        }

        [Then(@"User must see result page count '([^']*)' text in results grid in Search page")]
        public async Task ThenUserMustSeeResultPageCountTextInResultsGridInSearchPage(string showingText)
        {
            await searchResultGridPage.VerifyResultShowingCountInResultGrid(showingText);
        }

    }
}
