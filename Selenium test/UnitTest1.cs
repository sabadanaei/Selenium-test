using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Selenium_test
{
	
	[TestClass]
	public class UnitTest1
	{
		string email = "ssabadanaei@gmail.com";
		IWebDriver driver;

		[TestInitialize]
		public void Init() {
			// Create an instanse of webdriver
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
			driver.Manage().Window.Maximize();
		}

		[TestCategory("SampleTeast")]
		[TestMethod]
		public void TestMethod1()
		{

			try
			{
				string title = driver.Title;
				Assert.AreEqual(title, "Demo Web Shop");
				driver.FindElement(By.CssSelector(".ico-register")).Click();
				string registerTitle = driver.Title;
				Assert.AreEqual(registerTitle, "Demo Web Shop. Register");
				driver.FindElement(By.Id("gender-female")).Click();
				driver.FindElement(By.Id("FirstName")).SendKeys("Saba");
				driver.FindElement(By.Id("LastName")).SendKeys("Danaei");
				driver.FindElement(By.Id("Email")).SendKeys("ssabadanaei@gmail.com");
				driver.FindElement(By.Id("Password")).SendKeys("saba123456");
				driver.FindElement(By.Id("ConfirmPassword")).SendKeys("saba123456");
				driver.FindElement(By.Id("register-button")).Click();
				string message = driver.FindElement(By.ClassName("result")).Text;
				Assert.AreEqual(message, "Your registration completed");

				IWebElement emailAccount = driver.FindElement(By.XPath("//*[text()='" + email + "']"));
				Assert.IsTrue(emailAccount.Displayed);
				driver.FindElement(By.CssSelector(".ico-logout")).Click();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		[TestCleanup]
		public void CloseBrowser()
		{
			driver.Close();
		}
	}
}
