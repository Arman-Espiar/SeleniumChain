using OpenQA.Selenium;

namespace SeleniumChains.SeleniumExtensions.WebElementExtensions;
public static class PageNavigation
{
	public static IWebElement? ScrollDownElement(this IWebElement? webElement)
	{
		if (webElement.IsElementDisplayedAndEnabled())
		{
			webElement?.SendKeys(Keys.End);
		}

		return webElement;
	}
	public static IWebElement? ScrollUpElement(this IWebElement? webElement)
	{
		if (webElement.IsElementDisplayedAndEnabled())
		{
			webElement?.SendKeys(Keys.Home);
		}

		return webElement;
	}
}
