using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.Pages
{
    class LoginElement
    {
        protected IWebDriver driver;
        //protected int timeout = Config.timeout;


        [CacheLookup]
        protected IWebElement IngDNI =>
        driver.FindElement(By.Id("field_userName__input "));

        [CacheLookup]
        protected IWebElement IngPass =>
        driver.FindElement(By.Id("field_password__input"));

        [CacheLookup]
        protected IWebElement BtnIngresar =>
        driver.FindElement(By.Id("login-insured"));


        public readonly string pageLoadedText = "San Cristóbal";

        public readonly string pageUrl = "/ingresar";

    }
}
