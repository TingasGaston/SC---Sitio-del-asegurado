using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
  [TestClass]
    public class TC_Base
    {
        protected IWebDriver driver;
        private ChromeOptions options;
        public static int timeout;
        protected static string url = "https://autogestion.sancristobal.com.ar/ingresar";

        [AssemblyInitialize]
        public IWebDriver InitChrome()
        {
            try
            {
                options = new ChromeOptions();
                options.AddArguments("disable-infobars");
                options.AddArguments("headless", "--window-size=1920,1080");
                driver = new ChromeDriver(@"C:\Users\rios_\source\repos\UnitTestProject1", options);
                //driver = new ChromeDriver(@"C:\");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                return driver;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("ChromeDriver only supports"))
                {
                    throw new Exception("ChromeDriver incompatible con la versión de Chrome instalada.");
                }
                else
                {
                    throw new Exception("Ocurrió un error inesperado: " + e.Message);
                }
            }
        }

        public void EndTest()
        {
            driver.Quit();
        }
    }   
}






   

