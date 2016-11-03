using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Selenium_3_Sample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Environment.SetEnvironmentVariable("PATH", Path.GetFullPath("../../"));

            IWebDriver fireFoxDriver = new FirefoxDriver();

            fireFoxDriver.Navigate().GoToUrl("http://google.com");

            Assert.AreEqual("Google", fireFoxDriver.Title);

            fireFoxDriver.FindElement(By.LinkText("Images")).Click();

            Assert.AreEqual("Google Images", fireFoxDriver.Title);
        }
    }
}
