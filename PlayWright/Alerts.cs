using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace playwright
{
    public class Alerts
    {

        [Test]
        public async Task Alert()
        {
            using var nanda = await Playwright.CreateAsync();
           await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
        
            var page = await nanda1.NewPageAsync();



            await page.GotoAsync("https://testautomationpractice.blogspot.com/");

            

            page.Dialog += async (_, dialog) =>
            {
                Console.WriteLine($"Alert Message : {dialog.Message}");
                await dialog.AcceptAsync();

                 
            };

            await page.Locator("//button[@id=\"confirmBtn\"]").ClickAsync();
            await page.WaitForTimeoutAsync(3000);
        }






        [Test]
        public async Task Confirm()
        {
            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var page = await nanda1.NewPageAsync();



            await page.GotoAsync("https://testautomationpractice.blogspot.com/");

            page.Dialog += async (_, dialog) =>
            {
                Console.WriteLine($"Alert Message : {dialog.Message}");
                await dialog.AcceptAsync();


            };

            await page.Locator("//button[@id=\"confirmBtn\"]").ClickAsync();
            await page.WaitForTimeoutAsync(3000);

        }






        [Test]
        public async Task Confirmm()
        {
            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var page = await nanda1.NewPageAsync();



            await page.GotoAsync("https://github.com/nandakumar0499");


            await page.WaitForTimeoutAsync(5000);



        }



        }
}