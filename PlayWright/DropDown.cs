using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;
using Microsoft.VisualBasic.FileIO;

namespace playwright
{
    public class DropDown
    {

        [Test]
        public async Task SingleDropdown()
        {
            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var page = await nanda1.NewPageAsync();


            await page.GotoAsync("https://testautomationpractice.blogspot.com/");


           await page.Locator("//select[@id=\"country\"]").SelectOptionAsync(new SelectOptionValue { Value= "australia" });


            await page.WaitForTimeoutAsync(5000);

            var option = page.Locator("//select[@id=\"country\"]");

            int count = await option.CountAsync();

            Console.WriteLine(count);


            for (int i = 0; i < count; i++)
            {
                string text = await option.Nth(i).InnerTextAsync();

                Console.WriteLine(text);


            }

            await option.SelectOptionAsync(new SelectOptionValue { Index = 3, });


            


        }

        [Test]
        public async Task multiSelectionDropdown()
        {
            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var page = await nanda1.NewPageAsync();


            await page.GotoAsync("https://testautomationpractice.blogspot.com/");


            await page.Locator("//select[@id=\"colors\"]").SelectOptionAsync(new[] {new SelectOptionValue { Index = 2 },
                                                                                   new SelectOptionValue { Index=4} 
             
                                                                                                                         });


            var option = page.Locator("//select[@id=\"colors\"]");


            int count = await option.CountAsync();

            Console.WriteLine(count);


            for (int i = 0; i < count; i++)
            {
                string text = await option.Nth(i).InnerTextAsync();

                Console.WriteLine(text);


            }

        }


        }
}
