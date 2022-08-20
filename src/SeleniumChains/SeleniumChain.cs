using OpenQA.Selenium;
using SeleniumChains.ChainBuilderPatterns.WebDriverBuilderPatterns.BrowserBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;
using SeleniumChains.SeleniumChainClasses;
using SeleniumChains.SeleniumExtensions.WebDriverExtensions;
using SeleniumChains.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChains;
public class SeleniumChain:SeleniumChainBase
{
	public SeleniumChain SetDriver(IWebDriver? driver)
	{
		Driver = driver;
		return this;
	}
	public SeleniumChain Goto(string url)
	{
		Driver?.GotoUrl(url);
		return this;
	}
	public SeleniumChain Goto(Uri url)
	{
		Driver?.GotoUrl(url);
		return this;
	}
	public SeleniumChain ImplicitWaitingForEachPageToLoad(TimeSpan timeout)
	{
		Driver?.WaitingForEachPageToLoad(timeout);
		return this;
	}

	public SeleniumChain PageScrollDown()
	{
		Driver?.FindElementIfExistsByTagName("html")?.ScrollDownElement();
		return this;
	}
	public SeleniumChain PageScrollUp()
	{
		Driver?.FindElementIfExistsByTagName("html")?.ScrollUpElement();
		return this;
	}

	public SeleniumChain ScrollDownElementIfExistsById(string id)
	{
		Driver?.FindElementIfExistsById(id).ScrollDownElement();
		return this;
	}
	public SeleniumChain ScrollUpElementIfExistsById(string id)
	{
		Driver?.FindElementIfExistsById(id).ScrollUpElement();
		return this;
	}

	public SeleniumChain PageNavigation(Action<IPageNavigationBuilder> configure)
	{
		var pageNavigationBuilder = new PageNavigationBuilder();	
		configure(pageNavigationBuilder);
		return this;
	}

	public SeleniumChain BrowserNavigation(Action<IBrowserNavigationBuilder> configure)
	{
		var browserNavigationBuilder = new BrowserNavigationBuilder();
		configure(browserNavigationBuilder);
		return this;
	}

	public SeleniumChain ClickOnElement(Action<IClickOnElementBuilder> configure)
	{
		var webElementBuilder = new ClickOnElementBuilder();
		configure(webElementBuilder);
		return this;
	}
	#region ClickOneElementBy

	public SeleniumChain ClickOnElementById(string id)
	{
		new ClickOnBy().Id(id);
		return this;
	}
	public SeleniumChain ClickOnElementByClassName(string className)
	{
		new ClickOnBy().ClassName(className);
		return this;
	}
	public SeleniumChain ClickOnElementByCssSelector(string cssSelector)
	{
		new ClickOnBy().CssSelector(cssSelector);
		return this;
	}
	public SeleniumChain ClickOnElementByLinkText(string linkText)
	{
		new ClickOnBy().LinkText(linkText);
		return this;
	}
	public SeleniumChain ClickOnElementByName(string name)
	{
		new ClickOnBy().Name(name);
		return this;
	}
	public SeleniumChain ClickOnElementByPartialLinkText(string partialLinkText)
	{
		new ClickOnBy().PartialLinkText(partialLinkText);
		return this;
	}
	public SeleniumChain ClickOnElementByTagName(string tagName)
	{
		new ClickOnBy().TagName(tagName);
		return this;
	}
	public SeleniumChain ClickOnElementByXPath(string xPath)
	{
		new ClickOnBy().XPath(xPath);
		return this;
	}
	#endregion End ClickOneElementBy


	public SeleniumChain WriteInElement(Action<IWriteBuilder> configure)
	{
		var writeBuilder = new WriteBuilder();
		configure(writeBuilder);
		return this;
	}

	public SeleniumChain FindElement(Action<IElementsFindersBuilder> configure)
	{
		var webElementBuilder = new ElementsFindersBuilder();
		configure(webElementBuilder);
		return this;
	}
	public SeleniumChain FindElements(Action<IElementsFindersBuilder> configure)
	{
		var webElementsBuilder = new ElementsFindersBuilder();
		configure(webElementsBuilder);
		return this;
	}
	#region FindElementsBy
	public SeleniumChain FindElementsIfExistsById(string id)
	{
		new FindElementsBy().Id(id);
		return this;
	}
	public SeleniumChain FindElementsIfExistsByClassName(string className)
	{
		new FindElementsBy().ClassName(className);
		return this;
	}
	public SeleniumChain FindElementsIfExistsByCssSelector(string cssSelector)
	{
		new FindElementsBy().CssSelector(cssSelector);
		return this;
	}
	public SeleniumChain FindElementsIfExistsByLinkText(string linkText)
	{
		new FindElementsBy().LinkText(linkText);
		return this;
	}
	public SeleniumChain FindElementsIfExistsByName(string name)
	{
		new FindElementsBy().Name(name);
		return this;
	}
	public SeleniumChain FindElementsIfExistsByPartialLinkText(string partialLinkText)
	{
		new FindElementsBy().PartialLinkText(partialLinkText);
		return this;
	}
	public SeleniumChain FindElementsIfExistsByTagName(string tagName)
	{
		new FindElementsBy().TagName(tagName);
		return this;
	}
	public SeleniumChain FindElementsIfExistsByXPath(string xPath)
	{
		new FindElementsBy().XPath(xPath);
		return this;
	}
	#endregion End FindElementsBy

	#region FindElementBy
	public SeleniumChain FindElementIfExistsById(string id)
	{
		new FindElementBy().Id(id);
		return this;
	}
	public SeleniumChain FindElementIfExistsByClassName(string className)
	{
		new FindElementBy().ClassName(className);
		return this;
	}
	public SeleniumChain FindElementIfExistsByCssSelector(string cssSelector)
	{
		new FindElementBy().CssSelector(cssSelector);
		return this;
	}
	public SeleniumChain FindElementIfExistsByLinkText(string linkText)
	{
		new FindElementBy().LinkText(linkText);
		return this;
	}
	public SeleniumChain FindElementIfExistsByName(string name)
	{
		new FindElementBy().Name(name);
		return this;
	}
	public SeleniumChain FindElementIfExistsByPartialLinkText(string partialLinkText)
	{
		new FindElementBy().PartialLinkText(partialLinkText);
		return this;
	}
	public SeleniumChain FindElementIfExistsByTagName(string tagName)
	{
		new FindElementBy().TagName(tagName);
		return this;
	}
	public SeleniumChain FindElementIfExistsByXPath(string xPath)
	{
		new FindElementBy().XPath(xPath);
		return this;
	}
	#endregion End FindElementBy

	public void CloseBrowser() => Driver?.Close();
}