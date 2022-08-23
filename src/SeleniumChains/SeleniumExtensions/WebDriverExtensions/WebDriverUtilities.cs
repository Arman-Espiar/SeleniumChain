using OpenQA.Selenium;

namespace SeleniumChain.SeleniumExtensions.WebDriverExtensions;
public static class WebDriverUtilities
{
	public static IWebElement? FindElementIfExists(this IWebDriver driver, By by)
	{
		var elements = driver?.FindElements(by);
		return elements?.Count >= 1 ? elements.First() : null;
	}
	public static List<IWebElement>? FindElementsIfExists(this IWebDriver driver, By by)
	{
		var elements = driver?.FindElements(by);
		return elements?.Count >= 1 ? elements.ToList() : null;
	}

	//public static bool ElementIsExists(this IWebDriver driver, By by)
	//{
	//	var elements = Driver?.FindElements(by);
	//	return elements.Count >= 1 ? true : false;
	//}
	public static bool IsElementExists(this IWebDriver driver, By by)
	{
		var elements = driver?.FindElementIfExists(by);
		return elements is not null ? true : false;
	}
	public static bool AreElementsExists(this IWebDriver driver, By by)
	{
		var elements = driver?.FindElementsIfExists(by);
		return elements is not null && elements.Any() ? true : false;
	}


}
