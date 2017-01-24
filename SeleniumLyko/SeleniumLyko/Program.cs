using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumLyko
{
    class Program
    {
        static IWebDriver driver;
        static IWait<IWebDriver> wait;
        static void Main(string[] args)
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.lyko.se");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
            driver.FindElement(By.Name("q")).SendKeys("Schampoo");
            Thread.Sleep(5000);
            driver.FindElement(By.ClassName("A69wSs")).Click();
            driver.FindElement(By.CssSelector("div._1Nvacq:nth-child(1) > button:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector("._1w9fSZ")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("a._3itYIP:nth-child(1)")).Click();
            Thread.Sleep(15000);
            for (int i = 0; i < 9; i++)
            {
                driver.FindElement(By.CssSelector(".YwJvmF")).Click();
                Thread.Sleep(1000);
            }

            bool lykologo = driver.FindElement(By.CssSelector(".jmb20U")).Displayed;
            if (lykologo)
            {
                Console.WriteLine("Loggan existerar");
                driver.FindElement(By.CssSelector(".jmb20U")).Click();
            }
            else
            {
                Console.WriteLine("Loggan existerar inte");
            }
        }
    }
}
