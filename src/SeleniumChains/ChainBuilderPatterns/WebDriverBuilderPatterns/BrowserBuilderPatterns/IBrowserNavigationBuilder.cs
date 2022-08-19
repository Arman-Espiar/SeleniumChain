using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebDriverExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebDriverBuilderPatterns.BrowserBuilderPatterns;
public interface IBrowserNavigationBuilder
{
	IBrowserNavigationBuilder Goto(string url);
	IBrowserNavigationBuilder Goto(Uri url);

	IBrowserNavigationBuilder RefreshUrl();
	IBrowserNavigationBuilder BrowserHistoryForward();
	IBrowserNavigationBuilder BrowserHistoryBackward();

}

public class BrowserNavigationBuilder : IBrowserNavigationBuilder
{
	private readonly IWebDriver _driver;

	public BrowserNavigationBuilder(IWebDriver driver)
	{
		_driver = driver;
	}


	public IBrowserNavigationBuilder Goto(string url)
	{
		_driver.GotoUrl(url);
		return this;
	}

	public IBrowserNavigationBuilder Goto(Uri url)
	{
		_driver.GotoUrl(url);
		return this;
	}

	public IBrowserNavigationBuilder RefreshUrl()
	{
		_driver.RefreshUrl();
		return this;
	}

	public IBrowserNavigationBuilder BrowserHistoryForward()
	{
		_driver.BrowserHistoryForward();
		return this;
	}

	public IBrowserNavigationBuilder BrowserHistoryBackward()
	{
		_driver.BrowserHistoryBackward();
		return this;
	}


}
