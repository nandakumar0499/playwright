using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace playwright
{
    public class mouse_Actions
    {

            [Test]




            public async Task MOUSEACTIONS()
            {

                using var nanda = await Playwright.CreateAsync();
                await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false,
                });

                var page = await nanda1.NewPageAsync();

                await page.GotoAsync("https://testautomationpractice.blogspot.com/");

            await page.Locator("//input[@id=\"name\"]").FillAsync("nanda kumar");

            await page.Locator("//input[@id=\"name\"]").DblClickAsync();

            await page.Locator("//input[@id=\"email\"]").ClickAsync(new LocatorClickOptions { Button = MouseButton.Right });
            await page.WaitForTimeoutAsync(3000);

            await page.Locator("//input[@id=\"phone\"]").ClickAsync(new LocatorClickOptions { Button = MouseButton.Left });

            await page.WaitForTimeoutAsync(3000);


            await page.Locator("//div[@class=\"date-picker-box\"]").HoverAsync();


            await page.Locator("//div[@id=\"draggable\"]").DragToAsync(page.Locator("//div[@id=\"droppable\"]"));

            await page.WaitForTimeoutAsync(3000);


            await page.Mouse.MoveAsync(300, 300);
            await page.WaitForTimeoutAsync(3000);



            // Mouse Down and UP


            await page.Mouse.DownAsync();
            await page.WaitForTimeoutAsync(3000);
            await page.Mouse.MoveAsync(100, 100);
            await page.WaitForTimeoutAsync(3000);
            await page.Mouse.UpAsync();
            await page.WaitForTimeoutAsync(3000);
            await page.Mouse.MoveAsync(300, 300);

            await page.Mouse.WheelAsync(100, 1000);

        }





    }
    }
