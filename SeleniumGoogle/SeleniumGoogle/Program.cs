using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SeleniumGoogle
{
    class Program
    {
        static IWebDriver driver;
       static IWait<IWebDriver> wait;

        static void Main(string[] args)
        {

            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
            driver.FindElement(By.Id("lst-ib")).SendKeys("Testautomatisering Stockholm");
            driver.FindElement(By.Id("_fZl")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement resultat = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("resultStats")));
            Console.WriteLine(resultat.Text);
        }
    }
}
