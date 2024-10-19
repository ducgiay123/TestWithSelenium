using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
namespace TestWithSelenium.Service
{
    public class ChromeService 
    {
        private IWebDriver _driver ;
        public ChromeService(IWebDriver driver)
        {
            _driver = driver;
        }
        public void ShutDownDriver()
        {
            _driver.Quit();
            _driver.Dispose();
        }
        public void WaitToFullyLoadedURL()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(x =>
            {
                return ((IJavaScriptExecutor)_driver).ExecuteScript("return document.readyState").ToString() == "complete";
            });
        }
        public  bool GoToURLFullyLoaded(string url) {
            try
            {
                _driver.Navigate().GoToUrl(url);
                WaitToFullyLoadedURL();
                return true;
            }
            catch { return false; }
        }
        public  IWebElement WaitUntilElementExists(By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementExists(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
    }
}
