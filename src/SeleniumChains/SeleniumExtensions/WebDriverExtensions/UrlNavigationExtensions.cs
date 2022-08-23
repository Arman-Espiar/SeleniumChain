using OpenQA.Selenium;

namespace SeleniumChain.SeleniumExtensions.WebDriverExtensions;
public static class UrlNavigationExtensions
{
	public static IWebDriver? GotoUrl(this IWebDriver? webDriver, string url)
	{
		webDriver?.Navigate().GoToUrl(url);
		return webDriver;
	}
	public static IWebDriver? GotoUrl(this IWebDriver? webDriver, Uri url)
	{
		webDriver?.Navigate().GoToUrl(url);
		return webDriver;
	}
	
	/// <summary>
	/// Refresh page
	/// </summary>
	/// <param name="webDriver"></param>
	/// <returns></returns>
	public static IWebDriver? RefreshUrl(this IWebDriver? webDriver)
	{
		webDriver?.Navigate().Refresh();
		return webDriver;
	}
	/// <summary>
	/// Navigate Forward in browser history
	/// </summary>
	/// <param name="webDriver"></param>
	/// <returns></returns>
	public static IWebDriver? BrowserHistoryForward(this IWebDriver? webDriver)
	{
		webDriver?.Navigate().Forward();
		return webDriver;
	}
	/// <summary>
	/// Navigate backward in browser history
	/// </summary>
	/// <param name="webDriver"></param>
	/// <returns></returns>
	public static IWebDriver? BrowserHistoryBackward(this IWebDriver? webDriver)
	{
		webDriver?.Navigate().Back();
		return webDriver;
	}


}
