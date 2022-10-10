using OpenQA.Selenium;
using SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsWithResultBuilderPatterns;
using SeleniumChain.SeleniumChainClasses.Base;

namespace SeleniumChain.SeleniumChainClasses;

public class FindElementWithResultBy : SeleniumChainBase, IFindElementWithResultBy
{
	private readonly ChainSelenium _chainSelenium;

	public FindElementWithResultBy(ChainSelenium chainSelenium)
	{
		_chainSelenium = chainSelenium;
	}

	public ChainSelenium Id(string id, out IWebElement? webElement)
	{
		new ElementFindersWithResultBuilder().FindElementIfExistsById(id, out webElement);
		return _chainSelenium;

	}

	public ChainSelenium ClassName(string className, out IWebElement? webElement)
	{
		new ElementFindersWithResultBuilder().FindElementIfExistsByClassName(className, out webElement);
		return _chainSelenium;
	}

	public ChainSelenium CssSelector(string cssSelector, out IWebElement? webElement)
	{
		new ElementFindersWithResultBuilder().FindElementIfExistsByCssSelector(cssSelector, out webElement);
		return _chainSelenium;
	}

	public ChainSelenium LinkText(string linkText, out IWebElement? webElement)
	{
		new ElementFindersWithResultBuilder().FindElementIfExistsByLinkText(linkText, out webElement);
		return _chainSelenium;
	}

	public ChainSelenium Name(string name, out IWebElement? webElement)
	{
		new ElementFindersWithResultBuilder().FindElementIfExistsByName(name, out webElement);
		return _chainSelenium;
	}

	public ChainSelenium PartialLinkText(string partialLinkText, out IWebElement? webElement)
	{
		new ElementFindersWithResultBuilder().FindElementIfExistsByPartialLinkText(partialLinkText, out webElement);
		return _chainSelenium;
	}

	public ChainSelenium TagName(string tagName, out IWebElement? webElement)
	{
		new ElementFindersWithResultBuilder().FindElementIfExistsByTagName(tagName, out webElement);
		return _chainSelenium;
	}

	public ChainSelenium XPath(string xPath, out IWebElement? webElement)
	{
		new ElementFindersWithResultBuilder().FindElementIfExistsByXPath(xPath, out webElement);
		return _chainSelenium;
	}
}