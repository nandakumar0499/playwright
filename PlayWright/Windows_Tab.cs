using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace playwright
{
    public class Windows_Tab
    {

        [Test]
        public async Task Window()
        {
            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var page = await nanda1.NewPageAsync();


            await page.GotoAsync("https://www.hyrtutorials.com/p/window-handles-practice.html");



            var newPage = page.Context.WaitForPageAsync(); 
            var aa = page.Locator("//button[@id=\"newWindowBtn\"]");
            aa.ClickAsync();


            var newpage = await nanda1.NewPageAsync();

            await newpage.WaitForLoadStateAsync();

            Console.WriteLine(await newpage.TitleAsync());

            Console.WriteLine(newpage.Url);
            //await page.WaitForTimeoutAsync(5000);

          // await newpage.Locator("//input[@id=\"firstName\"]").FillAsync("nanda kumar");


            await page.WaitForTimeoutAsync(9000);
            



        }
    }
}
