using Playwright_SpecFlow_MSTest_UI.Pages.MyAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Playwright_SpecFlow_MSTest_UI.Steps.MyAccount
{
    [Binding]
    public class MyAccountSteps(MyAccountPage myAccountPage)
    {

        [Then(@"User must see My account page with account name displayed")]
        public async Task ThenUserMustSeeMyAccountPageWithAccountNameDislayed()
        {
            await myAccountPage.VerifyMyAccountPageForUser();
        }

    }
}
