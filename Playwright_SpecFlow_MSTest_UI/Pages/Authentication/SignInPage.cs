using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_SpecFlow_MSTest_UI.Pages.Authentication
{
    public class SignInPage(Hooks.Hook hook)
    {
        private readonly IPage Page = hook.Page;

        private ILocator SignInPageHeader_lbl => Page.GetByRole(AriaRole.Heading, new() { Name = "Authentication" });
        private ILocator EmailAddress_txt => Page.Locator("#email");
        private ILocator Password_txt => Page.GetByLabel("Password");
        private ILocator SignIn_btn => Page.GetByRole(AriaRole.Button, new () { Name = " Sign in" });

        public async Task VerifyAutheticationPageDisplayed()
        {
            await Assertions.Expect(SignInPageHeader_lbl).ToBeVisibleAsync();
        }

        public async Task TypeSignInDetailsAndClickSignInBtn()
        {
            await EnterSignInDetails();
            await SignIn_btn.ClickAsync();
        }

        private async Task EnterSignInDetails()
        {
            string emailAddr = "venuu6@gmail.com";
            string pwd = "Test@1234";
            await EmailAddress_txt.FillAsync(emailAddr);
            await Password_txt.FillAsync(pwd);
        }

        private async Task EnterSignInDetails(string emailAddr, string pwd)
        {
            await EmailAddress_txt.FillAsync(emailAddr);
            await Password_txt.FillAsync(pwd);
        }
    }
}
