using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;


namespace Guru99Demo
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\testing\\TAF");
            driver.Url = "http://www.epam.com";
            driver.Manage().Window.Maximize();
            IWebElement el = driver.FindElement(By.XPath("/ html / body / div[1] / div[1] / div / div / div[2] / button"));
            el.Click();
        }

        [Test]
        public void test1()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/button"));
            element.Click();
            element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[8]/a"));
            while (element.Displayed == false) { }
            element.Click();

        }

        [Test]

        public void test2()
        {
            driver.Url = "https://careers.epam.ua/company";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div/header/div/nav/ul/li[1]/span/a"));
            element.Click();
            
        }
        [Test]

        public void test3()
        {
            driver.Url = "https://careers.epam.ua/company";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div/header/div/nav/ul/li[2]/span/a"));
            element.Click();
        }

        [Test]
        public void test4()
        {
            driver.Url = "https://careers.epam.ua/vacancies";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[2]/section/div/div[2]/div/form/div[1]/input"));
            element.SendKeys("McDonald`s");
            element = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[2]/section/div/div[2]/div/form/button"));
            element.Click();
        }
        [Test]
        public void test5()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[1]/footer/div/div[2]/ul[1]/li[3]/a"));
            element.Click();
        }
        [Test]
        public void test6()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[3]/div/button"));
            element.Click();
            element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[3]/div/div/form/div/input"));
            element.SendKeys("Blockchain");
            element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[3]/div/div/form/button"));
            element.Click();

        }
        [Test]
        public void test7()
        {
            driver.Url = "https://careers.epam.ua/contact";
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[6]/section/div/div[3]/div/a/span[1]"));

        }
        [Test]
        public void test8()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/nav/ul/li[3]/span[1]/a"));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
            element = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/nav/ul/li[3]/div/ul[2]/li[4]/a"));
            element.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
    
}
