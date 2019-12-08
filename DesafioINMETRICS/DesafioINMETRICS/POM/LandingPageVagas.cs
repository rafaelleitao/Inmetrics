using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TestProject.SDK.PageObjects;

namespace Desafio.POM
{
    class LandingPageVagas
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LandingPageVagas(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#sidebar input[class='s']")]
        private IWebElement searchText;

        /*public ResultPage search(string text)
        {
            searchText.SendKeys(text);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#sidebar .searchsubmit"))).Click();
            return new ResultPage(driver);
        }*/
    }
}
