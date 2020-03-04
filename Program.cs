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

            var element = mDriver.FindElement(By.XPath("/html/body[@id='gsr']/div[@id='viewport']/div[@id='searchform']/form[@id='tsf']/div[2]/div[@class='A8SBwf sbfc']/div[@class='RNNXgb']/div[@class='SDkEP']/div[@class='a4bIc']/input[@class='gLFyf gsfi']"));

            element.SendKeys("Google This");

            Thread.Sleep(30000); //Wait for 30 seconds.

            mDriver.Close();
        }
    }
}
