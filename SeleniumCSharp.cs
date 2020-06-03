using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;

namespace SeleniumCSharpFrameWork
{
    [TestFixture]
    public class SeleniumCSharp
    {
        IWebDriver driver = null;
        [Test]
        [Author("Gokul", "gokul.p@indiumsoft.com")]
        [Description("Facebook Login Verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(string urlName)
        {
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;

                IWebElement email = driver.FindElement(By.XPath("//input[@id='email']"));
                email.SendKeys("Email Content");
                IWebElement password = driver.FindElement(By.XPath("//input[@id='ass']"));
                password.SendKeys("Password");

                driver.Quit();

            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("D:\\Knowledge\\SeleniumCSharpFrameTutorial\\SeleniumCSharpFrameWork\\ScreenShots\\Screenshot.1.png", ScreenshotImageFormat.Png);

                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver != null)
                {
                    driver.Quit();
                }
            }
            
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
           // list.Add("https://www.youtube.com/");

            return list;
        }
    }
}
