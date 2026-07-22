using System;
using System.Collections.Generic;
using System.Text;

namespace playwright
{
    public  class mouse_Actions
    {

        //print All Rows
        [Test]
        public async Task WabTable()
        {
            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var page = await nanda1.NewPageAsync();

            await page.GotoAsync("https://testautomationpractice.blogspot.com/");

            var rows = page.Locator("//table[@name=\"BookTable\"]");

            int count = await rows.CountAsync();

            for (int i = 0; i < count; i++)
            {

                string rowtext = await rows.Nth(i).InnerTextAsync();


                if (!string.IsNullOrWhiteSpace(rowtext))
                {
                    Console.WriteLine(rowtext);
                }


            }

        }


    }
}
