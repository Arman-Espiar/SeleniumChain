using OpenQA.Selenium;

using SeleniumChains.ChainBuilderPatterns.WebDriverBuilderPatterns.BrowserBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;
using SeleniumChains.SeleniumChainClasses.Base;
using SeleniumChains.SeleniumExtensions.WebDriverExtensions;
using SeleniumChains.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChains;
public class SeleniumChain : SeleniumChainBase
{
	public SeleniumChain()
	{
		ChainBase.SetSeleniumChain(this);
	}
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
		return ChainBase.FindElementsBy.Id(id);
	}
	public SeleniumChain FindElementsIfExistsByClassName(string className)
	{
		return ChainBase.FindElementsBy.ClassName(className);
	}
	public SeleniumChain FindElementsIfExistsByCssSelector(string cssSelector)
	{
		return ChainBase.FindElementsBy.CssSelector(cssSelector);
	}
	public SeleniumChain FindElementsIfExistsByLinkText(string linkText)
	{
		return ChainBase.FindElementsBy.LinkText(linkText);
	}
	public SeleniumChain FindElementsIfExistsByName(string name)
	{
		return ChainBase.FindElementsBy.Name(name);
	}
	public SeleniumChain FindElementsIfExistsByPartialLinkText(string partialLinkText)
	{
		return ChainBase.FindElementsBy.PartialLinkText(partialLinkText);
	}
	public SeleniumChain FindElementsIfExistsByTagName(string tagName)
	{
		return ChainBase.FindElementsBy.TagName(tagName);
	}
	public SeleniumChain FindElementsIfExistsByXPath(string xPath)
	{
		return ChainBase.FindElementsBy.XPath(xPath);
	}
	#endregion End FindElementsBy

	#region FindElementBy
	public SeleniumChain FindElementIfExistsById(string id)
	{
		return ChainBase.FindElementBy.Id(id);
	}
	public SeleniumChain FindElementIfExistsByClassName(string className)
	{
		return ChainBase.FindElementBy.ClassName(className);
	}
	public SeleniumChain FindElementIfExistsByCssSelector(string cssSelector)
	{
		return ChainBase.FindElementBy.CssSelector(cssSelector);
	}
	public SeleniumChain FindElementIfExistsByLinkText(string linkText)
	{
		return ChainBase.FindElementBy.LinkText(linkText);
	}
	public SeleniumChain FindElementIfExistsByName(string name)
	{
		return ChainBase.FindElementBy.Name(name);
	}
	public SeleniumChain FindElementIfExistsByPartialLinkText(string partialLinkText)
	{
		return ChainBase.FindElementBy.PartialLinkText(partialLinkText);
	}
	public SeleniumChain FindElementIfExistsByTagName(string tagName)
	{
		return ChainBase.FindElementBy.TagName(tagName);
	}
	public SeleniumChain FindElementIfExistsByXPath(string xPath)
	{
		return ChainBase.FindElementBy.XPath(xPath);
	}
	#endregion End FindElementBy

	#region ClickOnElementBy
	public SeleniumChain ClickOnElementById(string id)
	{
		return ChainBase.ClickOnElementBy.Id(id);
	}
	public SeleniumChain ClickOnElementByClassName(string className)
	{
		return ChainBase.ClickOnElementBy.ClassName(className);
	}
	public SeleniumChain ClickOnElementByCssSelector(string cssSelector)
	{
		return ChainBase.ClickOnElementBy.CssSelector(cssSelector);
	}
	public SeleniumChain ClickOnElementByLinkText(string linkText)
	{
		return ChainBase.ClickOnElementBy.LinkText(linkText);
	}
	public SeleniumChain ClickOnElementByName(string name)
	{
		return ChainBase.ClickOnElementBy.Name(name);

	}
	public SeleniumChain ClickOnElementByPartialLinkText(string partialLinkText)
	{
		return ChainBase.ClickOnElementBy.PartialLinkText(partialLinkText);
	}
	public SeleniumChain ClickOnElementByTagName(string tagName)
	{
		return ChainBase.ClickOnElementBy.TagName(tagName);
	}
	public SeleniumChain ClickOnElementByXPath(string xPath)
	{
		return ChainBase.ClickOnElementBy.XPath(xPath);
	}
	#endregion End ClickOnElementBy
	public void CloseBrowser() => Driver?.Close();
}