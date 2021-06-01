using AventStack.ExtentReports;
using NUnit.Framework;
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
    public class ExtentReportTest
    {
        ExtentTest test;
        ExtentReports rep = ExtentManager.getInstance();

        [SetUp]
        public static void Start()
        {
            ExtentReports rep = ExtentManager.getInstance();
            
        }
        

        [Test]
        public void ERTTestMethod()
        {
            test = rep.CreateTest("ExtentReportTest");
            test.Log(Status.Info, "Starting the extentreporttest test");

            test.Log(Status.Info, "in the extentreporttest test");
            // TODO: Add your test code here
            Console.WriteLine("in the test");

            test.Log(Status.Pass, "Test Passed");

            rep.Flush();

        }
    }
}
