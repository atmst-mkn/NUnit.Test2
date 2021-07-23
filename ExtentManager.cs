using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;

        private static ExtentReports extent;

        private ExtentManager()
        {

        }

        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                filePath = Directory.GetParent(Directory.GetParent(filePath).FullName).FullName;
                string reportPath = @"C:\SeleniumJ\ExtentReports\NUnit_Tests2\report.html";
                //string reportFile = DateTime.Now.ToString().Replace("/", "_").Replace(":", "_").Replace(" ", "_").Replace("-", "_") + ".html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("Host Name", "manis");
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("UserName", "manis");
                


                //string extentConfigPath = @"D:\gunjan\Recording\NUnit\TestFramework\TestFramework\extent-config.xml";
                string extentConfigPath = filePath + "\\extent-config.xml";
                //Console.WriteLine(filePath);
                htmlReporter.LoadConfig(extentConfigPath);
            }
            return extent;
        }
    }
}
