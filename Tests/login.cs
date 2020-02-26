using EchoPractice4Test.Framework;
using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EchoPractice4Test.Tests
{
    class Login : TestInstruction
    {
        public Login() {}

        override public void Run(State state)
        {
            try
            {
                IWebElement link = state.XPATH("/html/body/div[@id='app']/div[@class='v-dialog__content v-dialog__content--active']/div[@class='v-dialog v-dialog--active v-dialog--persistent']/div[@id='license_input_dialog']/div[@class='v-card__text']/div[@class='v-input v-text-field v-input--is-focused theme--light primary--text']/div[@class='v-input__control']/div[@class='v-input__slot']/div[@class='v-text-field__slot']/input[@id='email_address']");
                link.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                
            }
        }
    }
}
