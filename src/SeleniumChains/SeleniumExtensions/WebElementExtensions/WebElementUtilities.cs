using OpenQA.Selenium;

namespace SeleniumChain.SeleniumExtensions.WebElementExtensions;
public static class WebElementUtilities
{

	//Todo مطمعن نسیتم باید تست شود
	public static IWebElement? ClickOnElement(this IWebElement? webElement)
	{
		if (webElement.IsElementDisplayedAndEnabled())
		{
			webElement?.Click();
		}

		return webElement;
	}

	public static bool IsElementDisplayedAndEnabled(this IWebElement? webElement)
	{
		if (webElement is null)
		{
			return false;
		}
		return webElement.Displayed && webElement.Enabled;
	}
}
