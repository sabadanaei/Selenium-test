using OpenQA.Selenium;
using Selenium_test.Base_Page;
using Selenium_test.WebDriverExtention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_test.Pages
{
	public class Register_Page 
	{
		public static IWebDriver driver;
		public Register_Page(IWebDriver driver) {
			Register_Page.driver = driver;
		}

		public string getTitle()
		{
			return driver.Title;
		}

		public static readonly By gendrFemale = By.Id("gender-female");
		public static readonly By firstName = By.Id("FirstName");
		public static readonly By lastName = By.Id("LastName");
		public static readonly By emailAddress = By.Id("Email");
		public static readonly By password = By.Id("Password");
		public static readonly By confirmPassword = By.Id("ConfirmPassword");
		public static readonly By registerButton = By.Id("register-button");
		public static readonly By result = By.ClassName("result");
		public static readonly By Logout = By.ClassName("ico-logout");

		public void SelectFemaleGender()
		{
			driver.Click(gendrFemale, "");
		}

		public void enterfirstName(String value)
		{
			driver.EnterText(firstName, value, "");
		}

		public void enterLastName(String value)
		{
			driver.EnterText(lastName, value, "");
		}

		public void enterEmail(String value)
		{
			driver.EnterText(emailAddress, value, "");
		}

		public void enterPassword(String pass)
		{
			driver.EnterText(password, pass, "");
		}

		public void EnterconfirmPassword(String pass)
		{
			driver.EnterText(confirmPassword, pass, "");
		}

		public void clickRegisterBtn() {
			driver.Click(registerButton, "");
		}

		public String getSuccessfullMessage()
		{
			return driver.getText(result);
		}

		public bool IsEmailAccountDisplayed(String email)
		{
			return driver.getTextWithValueDisplayed(email);
		}

		public void clickLogOut()
		{
			driver.Click(Logout, "");
		}
	}
}
