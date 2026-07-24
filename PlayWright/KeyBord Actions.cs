using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace playwright
{
    internal class KeyBord_Actions
    {



        [Test]

        public async Task KEYBORD_ACTIONS()
        {
            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });

            var page = await nanda1.NewPageAsync();



            await page.GotoAsync("https://welcometotesting7.blogspot.com/2024/01/Seleniumjava.html");




        }
    }
}