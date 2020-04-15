using System;
using System.Collections.Generic;
using Tuesday7.Framework;
using Tuesday7.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Tuesday7
{
    class Program
    {
        static void Andrew(IWebDriver mDriver)
        {
            var main_screen_path = "/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt']";

            var main_screen = mDriver.FindElement(By.XPath(main_screen_path));

            main_screen.Click();
        }

        static void Luke(IWebDriver mDriver)
        {
            var set_sel_path = "/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt'][3]/button[@class='v-icon notranslate v-icon--link material-icons theme--light']";

            var set_sel = mDriver.FindElement(By.XPath(set_sel_path));

            set_sel.Click();
        }

        static void Jake(IWebDriver mDriver)
        {

            var char_sel_path = "/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt'][2]/div/div[@class='v-data-table elevation-1 theme--light']/div[@class='v-data-table__wrapper']/table/tbody/tr[4]/td[@class='text-start'][1]/div[@class='v-data-table__checkbox v-simple-checkbox']/i[@class='v-icon notranslate mdi mdi-checkbox-blank-outline theme--light']";

            var char_sel = mDriver.FindElement(By.XPath(char_sel_path));

            char_sel.Click();
        }

        static void HabitSmasherTest()
        {
            IWebDriver mDriver;

            mDriver = new ChromeDriver(@"c:\selenium\chrome80");
            mDriver.Url = "https://habitsmasher.d8data.io";
            mDriver.Manage().Window.Maximize();

            Andrew(mDriver);

            Jake(mDriver);

            var Pre_det_path = "/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt']/div[@class='gvt'][2]/div/div[@class='v-data-table elevation-1 theme--light']/div[@class='v-data-table__wrapper']/table/tbody/tr[1]/td[@class='text-start'][7]/button[@class='v-icon notranslate v-data-table__expand-icon v-icon--link mdi mdi-chevron-down theme--light']";

            var Pre_det = mDriver.FindElement(By.XPath(Pre_det_path));

            Pre_det.Click();

            Luke(mDriver);



            Thread.Sleep(30000); //Wait for 30 seconds.

            mDriver.Close();
        }

        static void AndrewDataBindingTest(IWebDriver mDriver)
        {
            var label_xpath = "/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[5]/div[1]";
            var input_id = "input-31";

            Thread.Sleep(2000);

            var label_handle = mDriver.FindElement(By.XPath(label_xpath));
            var input_handle = mDriver.FindElement(By.Id(input_id));

            Thread.Sleep(1000);

            //input_handle.Clear();
            input_handle.SendKeys("Andrew's Test");

            if(label_handle.Text == "AndrewAndrew's Test")
                Console.WriteLine("Andrew Success");
            else 
                Console.WriteLine("Andrew Failed");
        }

        static void Week2()
        {
            /*var andrew = mDriver.FindElement(By.XPath("/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[5]"));


            if (andrew.Text == "Andrew")
                Console.WriteLine("Andrew Is There");

            var Ed = mDriver.FindElement(By.XPath("/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[3]"));

            if (Ed.Text == "Ed")
                Console.WriteLine("Ed Rock's");
            var caleb = mDriver.FindElement(By.XPath("/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[2]"));

            if (caleb.Text == "caleb")
                Console.WriteLine("caleb is here");

            var Jacob = mDriver.FindElement(By.XPath("/html/body/div[@id='app']/div[@class='v-application--wrap']/main[@class='v-content']/div[@class='v-content__wrap']/div[4]"));

            if (Jacob.Text == "Jacob")
                Console.WriteLine("Jacob is PEBKAK KING");*/
        }

        static void Main(string[] args)
        {
            IWebDriver mDriver;

            mDriver = new ChromeDriver(@"c:\selenium\chrome80");
            mDriver.Url = "https://class.d8data.io";
            mDriver.Manage().Window.Maximize();

            AndrewDataBindingTest(mDriver);
        } 
    }
}
