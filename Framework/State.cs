using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EchoPractice4Test.Framework
{
    class State
    {
        IWebDriver mDriver;

        public State() //Constructor
        {
            mDriver = new ChromeDriver(@"c:\selenium\chrome78");
            mDriver.Url = "http://echopractice.d8data.io";
            mDriver.Manage().Window.Maximize();
        }

        ~State() //Destructor
        {
            mDriver.Close();
        }

        public IWebElement XPATH(string xpath)
        {
            ///LOG Here

            return mDriver.FindElement(By.XPath(xpath));
        }
    }
}
