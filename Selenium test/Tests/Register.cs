using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium_test.Base_Page;
using Selenium_test.Pages;
using System;

namespace Selenium_test.Tests
{
	[TestClass]
	public class Register : Base_Class
	{
		public Home_Page homepage;
		public Register_Page registerpage;
		[TestCategory("Smoke")]
		[TestMethod]
		public void verifyRegisterFunctionalityWithValidData()
		{
			String email = "sabadanaei@gmail.com";
			homepage = new Home_Page(driver);
			registerpage = new Register_Page(driver);
			Assert.AreEqual(homepage.getTitle(), "Demo Web Shop");
			homepage.ClickRegisterLink();
			Assert.AreEqual(registerpage.getTitle(), "Demo Web Shop. Register");
			registerpage.SelectFemaleGender();
			registerpage.enterfirstName("Saba");
			registerpage.enterLastName("Danaei");
			registerpage.enterEmail(email);
			registerpage.enterPassword("123456");
			registerpage.EnterconfirmPassword("123456");
			registerpage.clickRegisterBtn();
			String result = registerpage.getSuccessfullMessage();
			Assert.AreEqual(result, "Your registration completed");
			bool isTrue =  registerpage.IsEmailAccountDisplayed(email);
			Assert.IsTrue(isTrue);
			registerpage.clickLogOut();
		}

		[TestCategory("UnitTest")]
		[TestMethod]
		public void verifyAppLogoDisplayed()
		{

		}
	}
}
