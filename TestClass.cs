// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpFrameWork.BaseClass;
using System.Threading;

namespace SeleniumCSharpFrameWork
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Test")]
        public void TestMethod1()
        {

            IWebElement email = driver.FindElement(By.XPath("//input[@id='email']"));
            email.SendKeys("Password");
            IWebElement password = driver.FindElement(By.XPath("//input[@id='pass']"));
            password.SendKeys("Password");
        }

        [Test, Category("Regression Test")]
        public void TestMethod2()
        {
            IWebElement email = driver.FindElement(By.XPath("//input[@id='email']"));
            email.SendKeys("Password");
            IWebElement password = driver.FindElement(By.XPath("//input[@id='pass']"));
            password.SendKeys("Password");
            IWebElement year_drp = driver.FindElement(By.XPath("//select[@id='year']"));
            IWebElement month_drp = driver.FindElement(By.XPath("//select[@id='month']"));
            IWebElement day_drp = driver.FindElement(By.XPath("//select[@id='day']"));
            SelectElement element_day = new SelectElement(day_drp);
            SelectElement element_month = new SelectElement(month_drp);
            SelectElement element_year = new SelectElement(year_drp);
            element_day.SelectByValue("22");
            Thread.Sleep(200);
            element_month.SelectByIndex(3);
            Thread.Sleep(200);
            element_year.SelectByText("2020");
            Thread.Sleep(2000);
        }

        [Test, Category("Smoke Test")]
        public void TestMethod3()
        {
            IWebElement email = driver.FindElement(By.XPath("//input[@id='email']"));
            email.SendKeys("Password");
            IWebElement password = driver.FindElement(By.XPath("//input[@id='pass']"));
            password.SendKeys("Password");
        }
    }
}
