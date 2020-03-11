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

            var char_sel_path = "/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt'][2]/div/div[@class='v-data-table elevation-1 theme--light']/div[@class='v-data-table__wrapper']/table/tbody/tr[4]/td[@class='text-start'][1]/div[@class='v-data-table__checkbox v-simple-checkbox']/i[@class='v-icon notranslate mdi mdi-checkbox-blank-outline theme--light']";

            var char_sel = mDriver.FindElement(By.XPath(char_sel_path));

            char_sel.Click();

            var Pre_det_path = "/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt'][2]/div/div[@class='v-data-table elevation-1 theme--light']/div[@class='v-data-table__wrapper']/table/tbody/tr[1]/td[@class='text-start'][7]/button[@class='v-icon notranslate v-data-table__expand-icon v-icon--link mdi mdi-chevron-down theme--light']";

            var Pre_det = mDriver.FindElement(By.XPath(Pre_det_path));

            Pre_det.Click();





            Thread.Sleep(30000); //Wait for 30 seconds.

            mDriver.Close();
        }
    }
}
