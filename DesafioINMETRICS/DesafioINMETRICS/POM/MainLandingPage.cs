using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestProject.SDK.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Desafio.POM
{
    class MainLandingPage
    {
        private IWebDriver driver;

        public MainLandingPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using ="//a[.='confira nossas vagas']")]
        private IWebElement vagas;


        public void goToPageMainPage()
        {
            driver.Navigate().GoToUrl("https://www.inmetrics.com.br/");
        }

        public void AcessarPaginaDeVagas()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            var ButtonAcessarVagas = driver.FindElement(By.XPath("/html/body/main/section[8]/div/div/div/a"));
            Actions action = new Actions(driver);
            action.MoveToElement(ButtonAcessarVagas);
            action.Perform();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/main/section[8]/div/div/div/a")));
            ButtonAcessarVagas.Click();

        }

    }
}

 
