using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YnovShop.UITests
{
    [TestClass]
    public class UnitTest1
    {
        private static IWebDriver _driverChrome;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            _driverChrome = new ChromeDriver(@"C:\chromedriver");
        }

        [TestMethod]
        public void TestMethod1()
        {
            _driverChrome.Navigate().GoToUrl("https://www.google.com");
            _driverChrome.FindElement(By.Id("lst-ib")).SendKeys("ynov.com");
            _driverChrome.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }
    }
}
