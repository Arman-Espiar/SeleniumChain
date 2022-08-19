using OpenQA.Selenium;
using SeleniumChains.ChainBuilderPatterns.WebDriverBuilderPatterns.BrowserBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;
using SeleniumChains.SeleniumExtensions.WebDriverExtensions;

namespace SeleniumChains;
public class SeleniumChain
{
	private readonly IWebDriver _driver;

	public SeleniumChain(IWebDriver driver):base()
	{
		_driver = driver;
	}


	public SeleniumChain Goto(string url)
	{
		_driver.GotoUrl(url);
		return this;
	}
	public SeleniumChain Goto(Uri url)
	{
		_driver.GotoUrl(url);
		return this;
	}
	public SeleniumChain ImplicitWaitingForEachPageToLoad(TimeSpan timeout)
	{
		_driver.WaitingForEachPageToLoad(timeout);
		return this;
	}
	public SeleniumChain PageNavigation(Action<IPageNavigationBuilder> configure)
	{
		var pageNavigationBuilder = new PageNavigationBuilder(_driver);	
		configure(pageNavigationBuilder);
		return this;
	}
	public SeleniumChain BrowserNavigation(Action<IBrowserNavigationBuilder> configure)
	{
		var browserNavigationBuilder = new BrowserNavigationBuilder(_driver);
		configure(browserNavigationBuilder);
		return this;
	}

	public SeleniumChain ClickOnElement(Action<IClickOnElementBuilder> configure)//Todo dorost shavad. man faghat interface chagh ro sabok kardam
	{
		var webElementBuilder = new ClickOnElementBuilder(_driver);
		configure(webElementBuilder);
		return this;
	}

	public SeleniumChain WriteInElement(Action<IWriteBuilder> configure)
	{
		var writeBuilder = new WriteBuilder(_driver);
		configure(writeBuilder);
		return this;
	}

	public SeleniumChain FindElement(Action<IFindersBuilder> configure)
	{
		var webElementBuilder = new FindersBuilder(_driver);
		configure(webElementBuilder);
		return this;
	}
	public SeleniumChain FindElements(Action<IFindersBuilder> configure)
	{
		var webElementsBuilder = new FindersBuilder(_driver);
		configure(webElementsBuilder);
		return this;
	}

	public void CloseBrowser() => _driver.Close();
}