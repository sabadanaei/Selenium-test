using NLog;
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
		private static NLog.Logger logger = LogManager.GetCurrentClassLogger();
		public static IWebDriver driver;
		public static void EnterText(this IWebDriver driver, By locator, string value, string name)
		{
			try
			{
				IWebElement ele = driver.FindElement(locator);
				if (ele.Displayed && ele.Enabled)
				{
					logger.Info("Enter {0}, {1} :", name, value);
					ele.Clear();
					ele.SendKeys(value);
				}
			}
			catch (Exception e) {
				logger.Error("Inable to enter in {0}", name + ":" + e.Message);
				throw;
			}
		}

		public static void Click(this IWebDriver driver, By locator, string name)
		{
			try
			{
				IWebElement ele = driver.FindElement(locator);
				if (ele.Displayed && ele.Enabled)
				{
					logger.Info("Click on {0}", name);
					ele.Click();
				}
			}
			catch (Exception e)
			{
				logger.Error("Unable to click {0}", name + ":" + e.Message);
				throw;
			}
			
		}

		public static bool IselementDisplayed(this IWebDriver driver, By locator, string name)
		{
			IWebElement ele = driver.FindElement(locator);
			if (ele.Displayed)
			{
				logger.Info(name + "Element is displayed");
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
