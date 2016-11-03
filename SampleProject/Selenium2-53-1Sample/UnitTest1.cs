using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Selenium2_53_1Sample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver fireFoxDriver = new FirefoxDriver();

            fireFoxDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            fireFoxDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));

            fireFoxDriver.Navigate().GoToUrl("http://google.com");

            Assert.AreEqual("Google", fireFoxDriver.Title);

            fireFoxDriver.FindElement(By.LinkText("Images")).Click();

            Assert.AreEqual("Google Images", fireFoxDriver.Title);
        }
    }
}
