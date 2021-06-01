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
    public class AssertTest
    {

        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        [Test]
        public void assertTestfn()

        {
            test = rep.CreateTest("assertTest");
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
