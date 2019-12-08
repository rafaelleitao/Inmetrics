using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.POM
{
    class LandingPage
    {

        [FindsBy(How = How.Id, Using = "//a[.='confira nossas vagas']")]
        private IWebElement botaoPaginaVagas;
        public bool Displayed => botaoPaginaVagas.Displayed;
        public void ClickBotaoPaginaVagas()
        {
            botaoPaginaVagas.Click();
        }
        public void AcessaPaginaVagas(string name, string password)
        {
            ClickBotaoPaginaVagas();
        }
    }

}
