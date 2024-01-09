using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Selenium_test.WebDriverExtention
{
	public static class WebDriverExtention
	{
		public static IWebDriver driver;
		public static void EnterText(this IWebDriver driver, By locator, string value)
		{
			IWebElement ele = driver.FindElement(locator);
			if(ele.Displayed && ele.Enabled)
			{
				ele.Clear();
				ele.SendKeys(value);
			}
		}

		public static void Click(this IWebDriver driver, By locator)
		{
			IWebElement ele = driver.FindElement(locator);
			if(ele.Displayed && ele.Enabled)
			{
				ele.Click();
			}
		}

		public static bool IselementDisplayed(this IWebDriver driver, By locator)
		{
			IWebElement ele = driver.FindElement(locator);
			if (ele.Displayed)
			{
				return true;
			}
			return true;

		}

		public static string getText(this IWebDriver driver, By locator)
		{
			IWebElement ele = driver.FindElement(locator);
			var text = "";
			if (ele.Displayed)
			{
				text = ele.Text;
			}
			return text;
		}

		public static bool getTextWithValueDisplayed(this IWebDriver driver, string value)
		{
			var text = "";
			IWebElement ele = driver.FindElement(By.XPath("//*[text()='" + value + "']"));
			if (ele.Displayed)
			{
				return true;
			}
			return true;
		}

		public static void IsAlertPeresent()
		{

		}
		public static void SelectByVisibleTextFromDropDown() {
		}
	}
}
