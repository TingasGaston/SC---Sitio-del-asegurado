using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Pages;

namespace UnitTestProject1.Test
{
    [TestClass]
    class Login : TC_Base
    {
        #region Page
        LoginPage pLogin;
        #endregion

        #region TestSettings
        public void PagesInit()
        {

            pLogin = new LoginPage(driver);

        }

        [TestInitialize]
        public void TestInit()
        {
            InitChrome();
            PagesInit();
        }

        #endregion

        [TestMethod]
        [Description("This is a test just to login!")]

        public void Loguearse()
        {
            try
            {
                pLogin
                      .SetDNI("32779710")
                      .SetContrasenia("test")
                      .ClickIngresar();
                       
            }

            catch (System.Exception e)
            {
                throw;
            }



        }
    }
}
