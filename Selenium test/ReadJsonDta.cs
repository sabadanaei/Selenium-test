using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selenium_test.Base_Page;
using Selenium_test.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Selenium_test
{
	/// <summary>
	/// Summary description for ReadJsonDta
	/// </summary>
	[TestClass]
	public class ReadJsonDta : Base_Class
	{
		public ReadJsonDta()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[TestMethod]
		public void TestMethod1()
		{
			string readdatafromjson = File.ReadAllText(@"C:\Geeks Projects\Selenium\Selenium test\TestData\userdata.json");
			var registerDta = JsonSerializer.Deserialize<RegisterDataModel>(readdatafromjson);

			Console.WriteLine(registerDta.FirstName);
			Console.WriteLine(registerDta.LastName);
			Console.WriteLine(registerDta.Email);
			Console.WriteLine(registerDta.Password);

			string title = driver.Title;
			Assert.AreEqual(title, "Demo Web Shop");
			driver.FindElement(By.CssSelector(".ico-register")).Click();
			string registerTitle = driver.Title;
			Assert.AreEqual(registerTitle, "Demo Web Shop. Register");
			driver.FindElement(By.Id("gender-female")).Click();
			driver.FindElement(By.Id("FirstName")).SendKeys(registerDta.FirstName);
			driver.FindElement(By.Id("LastName")).SendKeys(registerDta.LastName);
			driver.FindElement(By.Id("Email")).SendKeys(registerDta.Email);
			driver.FindElement(By.Id("Password")).SendKeys(registerDta.Password);
			driver.FindElement(By.Id("ConfirmPassword")).SendKeys(registerDta.Password);
			driver.FindElement(By.Id("register-button")).Click();

		}
	}
}
