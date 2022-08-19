using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumChains.SeleniumExtensions.WebDriverExtensions;

/// <summary>
/// Warning: Do not mix implicit and explicit waits. Doing so can cause unpredictable wait times.
/// For example, setting an implicit wait of 10 seconds and an explicit wait of 15 seconds could cause a timeout to occur after 20 seconds.
/// </summary>
public static class LoadingExtensions
{

	/// <summary>
	/// فقط یکبار بعد ساخت نمونه درایور فراخوانی شود. روی بارگذاری تمامی صفحات اعمال خواهد شد
	/// <see cref="https://stackoverflow.com/a/36590395/10905290"/>
	/// </summary>
	/// <param name="webDriver"></param>
	/// <param name="timeout"></param>
	/// <returns></returns>
	public static IWebDriver WaitingForEachPageToLoad(this IWebDriver webDriver, TimeSpan timeout)
	{
		webDriver.Manage().Timeouts().ImplicitWait = timeout;
		return webDriver;
	}
	/// <summary>
	/// default selenium 4 pageLoadStrategy with time out
	/// </summary>
	/// <param name="webDriver"></param>
	/// <param name="timeout"></param>
	/// <see cref="https://www.selenium.dev/documentation/webdriver/capabilities/shared/"/>
	/// <returns></returns>
	public static IWebDriver WaitingForPageFullyLoadedByJavaScript(this IWebDriver webDriver, TimeSpan timeout)
	{
		new WebDriverWait(webDriver, timeout).Until(
			d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
		return webDriver;
	}
	public static IWebDriver WaitingForPageLoad(this IWebDriver webDriver, TimeSpan timeout)
	{
		webDriver.Manage().Timeouts().PageLoad = timeout;
		return webDriver;
	}
	public static IWebDriver AsynchronousJavaScriptLoad(this IWebDriver webDriver, TimeSpan timeout)
	{
		webDriver.Manage().Timeouts().AsynchronousJavaScript = timeout;
		return webDriver;
	}
	public static IWebDriver JavaScriptLoad(this IWebDriver webDriver, string script)
	{
		webDriver.ExecuteJavaScript(script);
		return webDriver;
	}
	public static IWebDriver JavaScriptLoad(this IWebDriver webDriver, string script, params object[] args)
	{
		webDriver.ExecuteJavaScript(script, args);
		return webDriver;
	}
}
