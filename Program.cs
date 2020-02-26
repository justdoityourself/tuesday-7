using System;
using System.Collections.Generic;
using EchoPractice4Test.Framework;
using EchoPractice4Test.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EchoPractice4Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test( new List<TestInstruction> { new Login() } );

            Collection collection = new Collection();
            collection.AddTest(test);

            Runner runner = new Runner(collection);

            runner.Start();
        }
    }
}
