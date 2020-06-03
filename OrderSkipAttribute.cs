// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpFrameWork.BaseClass;
using System.Threading;

namespace SeleniumCSharpFrameWork
{
    [TestFixture]
    public class OrderSkipAttribute
    {
       

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("SM-002");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";

            IWebElement email = driver.FindElement(By.XPath("//input[@id='email']"));
            email.SendKeys("Password");
            IWebElement password = driver.FindElement(By.XPath("//input[@id='pass']"));
            password.SendKeys("Password");

            driver.Close();
        }

       
        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";

            IWebElement email = driver.FindElement(By.XPath("//input[@id='email']"));
            email.SendKeys("Password");
            IWebElement password = driver.FindElement(By.XPath("//input[@id='pass']"));
            password.SendKeys("Password");

            driver.Close();
        }
    }
}
