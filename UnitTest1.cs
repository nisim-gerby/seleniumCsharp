using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharp.NetCore
{
    public class Tests
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("setup");
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {

            //driver.Navigate().GoToUrl("http://executeautomation.com");
            driver.Navigate().GoToUrl("http://demowf.aspnetawesome.com");
            driver.FindElement(By.XPath("//div[text()='Celery']")).Click();
            driver.FindElement(By.XPath("//div[@class='awe - display combobox']//button[@aria-label='open']")).Click();
            driver.FindElement(By.XPath("")).

            Console.WriteLine("test1 check");
            Assert.Pass();
        }
    }
}