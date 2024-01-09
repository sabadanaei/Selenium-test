using OpenQA.Selenium;
using Selenium_test.WebDriverExtention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_test.Pages
{
	public class Home_Page 
	{
		//create instance of webdriver
		public static IWebDriver driver;
		// create costructor

		public Home_Page(IWebDriver driver) {
			Home_Page.driver = driver;
		}

		public string getTitle()
		{
			return driver.Title;
		}

		public static readonly By RegisterLink = By.ClassName("ico-register");
		public static readonly By LoginLink = By.ClassName("ico-login");

		public void ClickRegisterLink() {
			driver.Click(RegisterLink);
		}
		public void ClickLoginLink() {
			driver.Click(LoginLink);
		}

	}
}
	