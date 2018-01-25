using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YnovShop.UITests
{
    [TestClass]
    public class AccountTest
    {
        private static IWebDriver _driverChrome;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            _driverChrome = new ChromeDriver(@"C:\chromedriver");
        }

        [TestMethod]
        public void AddAcount()
        {
            _driverChrome.Navigate().GoToUrl("http://localhost:52331/");

            _driverChrome.FindElement(By.LinkText("Créer un compte")).Click();

            _driverChrome.FindElement(By.Id("register-firstname")).SendKeys("Quentin");
            _driverChrome.FindElement(By.Id("register-lastname")).SendKeys("Jaillet");
            _driverChrome.FindElement(By.Id("register-email")).SendKeys("quentn.jaillet@gmail.com");
            _driverChrome.FindElement(By.Id("register-password")).SendKeys("Azerty123_");
            _driverChrome.FindElement(By.Id("register-confirm-password")).SendKeys("Azerty123_");

            _driverChrome.FindElement(By.Id("register-submit")).Submit();
        }
    }
}
