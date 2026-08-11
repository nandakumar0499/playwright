using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace playwright
{
    class Codegen_1
    {

        [Test]
        public async Task codegen()
        {
            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var page = await nanda1.NewPageAsync();

            await page.GotoAsync("https://testautomationpractice.blogspot.com/");

        }
    }
}