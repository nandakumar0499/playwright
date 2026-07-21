using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace playwright
{
    public class Frames
    {

        [Test]
         public async Task Frame1()
        {

            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });

            var page = await nanda1.NewPageAsync();



            await page.GotoAsync("https://www.naukri.com/mnjuser/profile?id=&altresid");



        }



    }
}
