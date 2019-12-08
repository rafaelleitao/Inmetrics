using Desafio.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RestSharp;
using System;
using System.IO;
using System.Reflection;
using TestProject.SDK;
using TestProject.SDK.PageObjects;
using Newtonsoft.Json;
using RestSharp.Serialization.Json;
using Desafio.DataTypes;
using OpenQA.Selenium.Remote;
using System.Threading;
using System.Net;

namespace Tests
{
    public class TestClass
    {
        private IWebDriver driver;
        

        [SetUp]
        public void SetUp()
        {
            var chromeDriverExePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var driverService = ChromeDriverService.CreateDefaultService(chromeDriverExePath);
            driverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("-no-sandbox");
            driver = new ChromeDriver(driverService, chromeOptions);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void AcessarPaginaVagas()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 100));
            
            MainLandingPage homelandingpage = new MainLandingPage(driver);
            homelandingpage.goToPageMainPage();
            homelandingpage.AcessarPaginaDeVagas();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".header__login")));
            var LoginCandidato = driver.FindElement(By.CssSelector(".header__login")).Text;
            Assert.That(LoginCandidato, Is.Not.Empty);
        }
        

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}