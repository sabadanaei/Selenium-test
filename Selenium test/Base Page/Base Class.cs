using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Selenium_test.Base_Page
{
	//initialize driver - set up driver
	//re usable methods

	public class Base_Class
	{
		public static IWebDriver driver;
		[TestInitialize]
		public void Init()
		{
			// Create an instanse of webdriver
			string siteurl = ConfigurationManager.AppSettings["url"];
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl(siteurl);
			driver.Manage().Window.Maximize();
		}

	

		[TestCleanup]
		public void Cleanup()
		{
			driver.Close();
		}
	}
}
