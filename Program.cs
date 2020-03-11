using System;
using System.Collections.Generic;
using Tuesday7.Framework;
using Tuesday7.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System.Threading;

namespace Tuesday7
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver mDriver;

            mDriver = new ChromeDriver(@"c:\selenium\chrome80");
            mDriver.Url = "https://habitsmasher.d8data.io";
            mDriver.Manage().Window.Maximize();

            var main_screen_path = "/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt']";

            var main_screen = mDriver.FindElement(By.XPath(main_screen_path));

            main_screen.Click();



            Thread.Sleep(30000); //Wait for 30 seconds.

            mDriver.Close();
        }
    }
}
