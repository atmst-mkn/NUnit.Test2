

using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework;

namespace NUnit.Tests2
{
    [TestFixture]
    [Parallelizable]
    public class AjaxHandling
    {

        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;


        [Test]
        public void TestMethod()
        {

            test = rep.CreateTest("AjaxHandling");

            string browser = "Mozilla";
            IWebDriver driver = null;

            if (browser == "Mozilla")
            {
                FirefoxDriverService fs = FirefoxDriverService.CreateDefaultService("C:\\SeleniumJ\\drivers", "geckodriver.exe");
                fs.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\\firefox.exe";
                driver = new FirefoxDriver(fs);


            }
            else if (browser == "Chrome")
            {
                driver = new ChromeDriver(@"C:\SeleniumJ\drivers");

            }
            else if (browser == "IE")
            {
                driver = new InternetExplorerDriver(@"C:\SeleniumJ\drivers");
            }
            driver.Url = "http://yahoo.com";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.CssSelector("*[class='_yb_fupma']")).SendKeys("hello");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //6th search _yb_b4hsm
            String text = driver.FindElement(By.CssSelector("*[class='_yb_b4hsm'] li:nth-child(6) span span")).Text;
            Console.WriteLine("6th text is " + text);

            driver.Quit();

            
            //Assert.AreEqual("Hello", "Hello");
            //Assert.IsTrue(6 > 2, " error"); triggers message if the condition inside fails
            Assert.IsFalse(1 > 3, " error mes"); //triggers msg when conisditon passes




            // TODO: Add your test code here
            test.Log(Status.Info, "Starting the extentreporttest test");

            test.Log(Status.Info, "in the extentreporttest test");
            // TODO: Add your test code here
            Console.WriteLine("in the test");

            test.Log(Status.Pass, "Test Passed");

            rep.Flush();


        }
    }
}
