using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        public IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver(); 
            _driver.Manage().Window.Maximize();
            
        }

        [Test]
        public void LaunchApplication()
        {
            _driver.Navigate().GoToUrl("https://www.google.co.in/");
           String title= _driver.Title;
            Console.WriteLine(title);
            _driver.Quit();
            Assert.Pass();
        }
       
    }
}