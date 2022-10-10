using OpenQA.Selenium;
using SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsWithResultBuilderPatterns;
using SeleniumChain.SeleniumChainClasses.Base;

namespace SeleniumChain.SeleniumChainClasses;
public class FindElementsWithResultBy: SeleniumChainBase, IFindElementsWithResultBy
{
	private readonly ChainSelenium _chainSelenium;

	public FindElementsWithResultBy(ChainSelenium chainSelenium)
	{
		_chainSelenium = chainSelenium;
	}

	public ChainSelenium Id(string id, out IList<IWebElement>? webElements)
	{
		new ElementsFindersWithResultBuilder().FindElementsIfExistsById(id, out webElements);
		return _chainSelenium;
	}

	public ChainSelenium ClassName(string className, out IList<IWebElement>? webElements)
	{
		new ElementsFindersWithResultBuilder().FindElementsIfExistsByClassName(className, out webElements);
		return _chainSelenium;
	}

	public ChainSelenium CssSelector(string cssSelector, out IList<IWebElement>? webElements)
	{
		new ElementsFindersWithResultBuilder().FindElementsIfExistsByCssSelector(cssSelector, out webElements);
		return _chainSelenium;
	}

	public ChainSelenium LinkText(string linkText, out IList<IWebElement>? webElements)
	{
		new ElementsFindersWithResultBuilder().FindElementsIfExistsByLinkText(linkText, out webElements);
		return _chainSelenium;
	}

	public ChainSelenium Name(string name, out IList<IWebElement>? webElements)
	{
		new ElementsFindersWithResultBuilder().FindElementsIfExistsByName(name, out webElements);
		return _chainSelenium;
	}

	public ChainSelenium PartialLinkText(string partialLinkText, out IList<IWebElement>? webElements)
	{
		new ElementsFindersWithResultBuilder().FindElementsIfExistsByPartialLinkText(partialLinkText, out webElements);
		return _chainSelenium;
	}

	public ChainSelenium TagName(string tagName, out IList<IWebElement>? webElements)
	{
		new ElementsFindersWithResultBuilder().FindElementsIfExistsByTagName(tagName, out webElements);
		return _chainSelenium;
	}

	public ChainSelenium XPath(string xPath, out IList<IWebElement>? webElements)
	{
		new ElementsFindersWithResultBuilder().FindElementsIfExistsByXPath(xPath, out webElements);
		return _chainSelenium;
	}
}
