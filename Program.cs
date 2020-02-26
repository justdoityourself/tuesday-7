using System;
using System.Collections.Generic;
using Tuesday7.Framework;
using Tuesday7.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tuesday7
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(new List<TestInstruction> { new Login() });

            Collection collection = new Collection();
            collection.AddTest(test);

            Runner runner = new Runner(collection);

            runner.Start();
        }
    }
}
