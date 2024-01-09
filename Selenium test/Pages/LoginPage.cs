using OpenQA.Selenium;
using Selenium_test.WebDriverExtention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_test.Pages
{
	public class LoginPage
	{
		public static IWebDriver driver;
		public LoginPage(IWebDriver driver) {
			LoginPage.driver = driver;
		}

		public static string getTitle()
		{
			return driver.Title;
		}
		public static readonly By emailtxt = By.Id("Email");
		public static readonly By passwordtxt = By.Id("Password");
		public static readonly By Loginbtn = By.CssSelector("input.button-1.login-button");


		public void EnterEmailAddress(String email)
		{
			driver.EnterText(emailtxt, email);
		}

		public void EnterPassword(String password)
		{
			driver.EnterText(passwordtxt, password);
		}

		public void ClickLoginButton()
		{
			driver.Click(Loginbtn);
		}
	}
}
