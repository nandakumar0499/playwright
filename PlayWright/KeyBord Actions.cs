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



            await page.GotoAsync("https://www.hyrtutorials.com/p/basic-controls.html");
            // await page.Locator("hjdgfyh").ClickAsync()  ;
            await page.GetByRole(AriaRole.Textbox, new() { Name = "Username" }).ClickAsync();
            await page.GetByRole(AriaRole.Textbox, new() { Name = "Username" }).FillAsync("sdfghjk");
            await page.GetByRole(AriaRole.Textbox, new() { Name = "Password" }).ClickAsync();
            await page.GetByRole(AriaRole.Textbox, new() { Name = "Password" }).FillAsync("ertyui");
            await page.GetByRole(AriaRole.Button, new() { Name = "Login" }).ClickAsync();




        }
    }
}