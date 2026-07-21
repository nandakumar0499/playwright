using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Playwright;

namespace playwright
{
    public class WebTable
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


        //print All Cells


        [Test]
        public async Task PRintALlCELL()
        {
            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var page = await nanda1.NewPageAsync();


            await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            var cell = page.Locator("//table[@name=\"BookTable\"]");

            int count = await cell.CountAsync();


            for (int i = 0; i < count; i++)
            {

                Console.WriteLine(await cell.Nth(i).InnerTextAsync());

            }








        }
        // Search tabell in one name
    
    [Test]
        public async Task SearchSpiciOne()
        {
            using var nanda = await Playwright.CreateAsync();
            await using var nanda1 = await nanda.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var page = await nanda1.NewPageAsync();


            await page.GotoAsync("https://testautomationpractice.blogspot.com/");

            var cell = page.Locator("//table[@name=\"BookTable\"]");

            int count = await cell.CountAsync();


            for (int i = 0; i < count; i++)
            {
                String text = await cell.Nth(i).InnerTextAsync();

                if(text.Contains("Mukesh"))
                Console.WriteLine("Emplay Found");
                 //Console.WriteLine(text);
                break;
            }



        } } }