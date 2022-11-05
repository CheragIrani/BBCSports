using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BBCWebsite.Tests
{
    public class TestSetup
    {
        public IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver(".");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }
    }
}
