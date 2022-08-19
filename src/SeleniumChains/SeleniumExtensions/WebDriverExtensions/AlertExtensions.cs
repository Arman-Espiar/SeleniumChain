using OpenQA.Selenium;

namespace SeleniumChains.SeleniumExtensions.WebDriverExtensions;
public static class AlertExtensions
{
	public static string? AlertGetText(this IWebDriver driver)
	{
		var alertText = driver.SwitchTo().Alert().Text;
		return alertText;
	}
	public static void AlertAccept(this IWebDriver driver)
	{
		driver.SwitchTo().Alert().Accept();
	}
	public static void AlertDismiss(this IWebDriver driver)
	{
		driver.SwitchTo().Alert().Dismiss();
	}
	public static void AlertInput(this IWebDriver driver, string message)
	{
		driver.SwitchTo().Alert().SendKeys(message);
	}
}
