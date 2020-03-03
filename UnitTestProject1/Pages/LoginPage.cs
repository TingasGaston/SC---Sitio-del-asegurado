using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.Pages
{
    class LoginPage : LoginElement
    {
        protected int timeout = 50;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage ClickIngresar()
        {
            BtnIngresar.Click();
            Console.WriteLine("Click ingresar.");
            return this;

        }

        public LoginPage SetContrasenia(string contraseaValue)
        {
            IngPass.SendKeys(contraseaValue);
            Console.WriteLine("Contraseña ingresada.");
            return this;
        }

        public LoginPage SetDNI(string dni)
        {
            IngDNI.SendKeys(dni);
            return this;
        }

        public LoginPage VerifyPageLoaded()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
            {
                return d.PageSource.Contains(pageLoadedText);
            });
            return this;
        }


        public LoginPage VerifyPageUrl()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
            {
                return d.Url.Contains(pageUrl);
            });
            return this;
        }
    }
}
