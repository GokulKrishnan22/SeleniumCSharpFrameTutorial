using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpFrameWork.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
        //[OneTimeSetUp] Execute Once and create browser instance and use for all Test execution.
        [SetUp] //Execute for every Test Execution.
        public void open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
        }

        //[OneTimeTearDown] Execute after all Test execution completed.
        [TearDown]
        public void close()
        {
            driver.Quit();
        }
    }
}
