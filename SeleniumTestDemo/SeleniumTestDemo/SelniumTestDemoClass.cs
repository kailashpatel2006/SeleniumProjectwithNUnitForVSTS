using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumTestDemo
{
    [TestFixture]
    public class SelniumTestDemoClass
    {

        IWebDriver driver;

        [SetUp]
        public void TestInitializeMethod()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments("--start-maximized");
            chromeOptions.AddArguments("--disable-extensions");
            chromeOptions.AddArguments("--allow-running-insecure-content");
            var chromeService = ChromeDriverService.CreateDefaultService("webdriver.chrome.driver", @"C:\devops_gitcode\Drivers\chromedriver.exe");
            driver = new ChromeDriver(chromeService, chromeOptions);
            driver.Url="https://www.google.com/";
            driver.Manage().Window.Maximize();
            

        }

        [Test]
        public void TestMethodSearchSomething()
        {
            IWebElement element = driver.FindElement(By.ClassName("gsfi"));
            element.SendKeys("automation execution");
            driver.FindElement(By.Name("btnK")).Submit();
            Thread.Sleep(2000);

        }

        [Test]
        public void TestMethodToClickOnGmail()
        {

            IWebElement element = driver.FindElement(By.XPath("//div[@id='gbw']/div/div/div[1]/div[1]/a"));
            element.Click(); 
            Thread.Sleep(2000);
        }

        [Test]
        public void TestMethodToClickOnGoogleMap()
        {
            IWebElement element = driver.FindElement(By.XPath(".//div[@id='gbwa']/div[1]/a"));
            element.Click();
            Thread.Sleep(2000);
            IWebElement element2 = driver.FindElement(By.ClassName("gb_2"));
            element2.Click();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void TestCleanUpMethod()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
