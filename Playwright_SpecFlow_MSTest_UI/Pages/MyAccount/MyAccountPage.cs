using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_SpecFlow_MSTest_UI.Pages.MyAccount
{
    public class MyAccountPage(Hooks.Hook hook)
    {
        private readonly IPage Page = hook.Page;

        private ILocator MyAccountHeader_lbl => Page.Locator("h1");
        private ILocator AccountName_lbl => Page.GetByRole(AriaRole.Navigation);

        public async Task VerifyMyAccountPageForUser()
        {
            string expUserName = "Venu v";
            await Assertions.Expect(MyAccountHeader_lbl).ToBeVisibleAsync();
            await Assertions.Expect(AccountName_lbl).ToContainTextAsync(expUserName);
        }
    }
}
