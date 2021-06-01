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
    public class RegisterationData
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;
        [Test,TestCaseSource("RegisterData")]
        public void TestMethod(string un, string pw, string email, string city)
        {
            test = rep.CreateTest("RegisterationData");
            // TODO: Add your test code here
            //selenium code
            //username
            //password
            //city
            Console.WriteLine(un);
            Console.WriteLine(pw);
            Console.WriteLine(email);
            Console.WriteLine(city);

            // TODO: Add your test code here
            test.Log(Status.Info, "Starting the extentreporttest test");
            test.Log(Status.Info, "in the extentreporttest test");
            // TODO: Add your test code here
            Console.WriteLine("in the test");
            test.Log(Status.Pass, "Test Passed");

            rep.Flush();
        }


        //Data source
        public static Object[] RegisterData()
        {
            object[][] data = new object[3][];
            //row - no of times test has to be run
            // cols -  no of params

            //first row
            data[0] = new object[4];
            data[0][0] = "user1";
            data[0][1] = "pass1";
            data[0][2] = "email1";
            data[0][3] = "city1";

            data[1] = new object[4];
            data[1][0] = "user2";
            data[1][1] = "pass2";
            data[1][2] = "email2";
            data[1][3] = "city2";

            data[2] = new object[4];
            data[2][0] = "user3";
            data[2][1] = "pass3";
            data[2][2] = "email3";
            data[2][3] = "city2";

            return data;

        }

    }
}
