using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium_test.Base_Page;
using Selenium_test.Pages;
using System;
using System.Configuration;

namespace Selenium_test.Tests
{
	[TestClass]
	public class Login : Base_Class
	{
		Home_Page homePage;
		LoginPage loginPage;
		[TestCategory("Smoke")]
		[TestMethod]
		public void VerifiedLoginFunctionalityWithValidData()
		{
			string username = ConfigurationManager.AppSettings["Email"];
			string password = ConfigurationManager.AppSettings["Password"];
			loginPage = new LoginPage(driver);
			homePage = new Home_Page(driver);
			homePage.ClickLoginLink();
			string title = homePage.getTitle();
			Assert.AreEqual (title, "Demo Web Shop. Login");
			loginPage.EnterEmailAddress(username);
			loginPage.EnterPassword(password);
			loginPage.ClickLoginButton();
		}
	}
}
