using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PageObjects
{
    public abstract class PageObjectsBase
    {
        private IWebDriver WebDriver;
       
        public PageObjectsBase(int browser = 2)
        {
            WebDriver = WebDriverFactory.CreateWebDriver(browser, "D:\\DESENVOLVIMENTO\\ESTUDOS\\APIDeTest\\PageObjects\\PageObjects\\PageObjects\\bin\\Debug\\netcoreapp2.2", false);
        }

        protected void NavegueParaPagina(string url, int segundosDeEspera = 0)
        {
            WebDriver.Navigate().GoToUrl(url);

            Thread.Sleep(segundosDeEspera * 1000);  
        }

        protected void PreenchaOCampoPorTag(By tag, string value = "")
        {
            WebDriver.FindElement(tag).SendKeys(value);
        }

        protected void ClickNoElementoDeTag(By tag)
        {
            WebDriver.FindElement(tag).Click();
        }






    }
}
