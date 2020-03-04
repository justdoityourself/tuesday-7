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
            mDriver.Url = "https://google.com";
            mDriver.Manage().Window.Maximize();

            var search_input = mDriver.FindElement(By.XPath("/html/body[@id='gsr']/div[@id='viewport']/div[@id='searchform']/form[@id='tsf']/div[2]/div[@class='A8SBwf sbfc']/div[@class='RNNXgb']/div[@class='SDkEP']/div[@class='a4bIc']/input[@class='gLFyf gsfi']"));
            //var do_search_button = mDriver.FindElement(By.XPath("/html/body[@id='gsr']/div[@id='viewport']/div[@id='searchform']/form[@id='tsf']/div[2]/div[@class='A8SBwf']/div[@class='FPdoLc tfB0Bf']/center/input[@class='gNO89b']"));

            search_input.SendKeys("Google This");
            search_input.SendKeys(Keys.Return);

            Thread.Sleep(3);

            //do_search_button.Click();

            Thread.Sleep(30000); //Wait for 30 seconds.

            mDriver.Close();
        }
    }
}
