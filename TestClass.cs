// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation




using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections;
using System.Collections.Generic;
using TestFramework;

namespace NUnit.Tests2
{
    [TestFixture]
    [Parallelizable]
    public class TestClass
    {

        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;


        [Test]
         public  void BaseTest()
            {

            test = rep.CreateTest("NUTestClassquit");
            


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

            /*
             * XPATHS************************
             */
            //driver.Url = "http://facebook.com";

            //IWebElement email = driver.FindElement(By.Id("email"));
            //email.SendKeys("manish.k.negi@gmail.com");

            //ID***********************************

            //IWebElement pass = driver.FindElement(By.Id("pass"));

            //driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("manish.k.negi@gmail.com");
            //driver.FindElement(By.XPath("//*[@id='pass']")).SendKeys("lalala");

            //System.Console.WriteLine("Test ends");
            //driver.Url = "https://edition.cnn.com/";

            // xpath********************** 

            ////driver.FindElement(By.XPath(".//*[@class='sc-cSHVUG bYPcOh']/li[3]")).Click();

            //driver.FindElement(By.XPath(".//*[@data-section='business' and @class='sc-kAzzGY gSIjYi']")).Click();
            /*  
             * CSS************************
             */
            driver.Url = "http://facebook.com";
            driver.FindElement(By.CssSelector("*[class='inputtext _55r1 _6luy']")).SendKeys("manish.k.negi@gmail.com");
            //driver.FindElement(By.CssSelector("*[name = 'pass']")).SendKeys("lalala");
            //driver.FindElement(By.CssSelector("[name='pass']")).SendKeys("lalala");input[name='pass']
            //driver.FindElement(By.CssSelector("[name='pass']")).SendKeys("lalala");
            driver.FindElement(By.CssSelector("input[placeholder='Password']")).SendKeys("lalala");

            driver.Close();

            test.Log(Status.Info, "Starting the extentreporttest test");
            test.Log(Status.Info, "in the extentreporttest test");
            // TODO: Add your test code here
            Console.WriteLine("in the test");
            test.Log(Status.Pass, "Test Passed");


            rep.Flush();


        }

    }
}
