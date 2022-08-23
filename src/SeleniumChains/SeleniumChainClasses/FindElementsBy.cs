using SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
using SeleniumChain.SeleniumChainClasses.Base;

namespace SeleniumChain.SeleniumChainClasses;
public class FindElementsBy:SeleniumChainBase, IFindElementsBy
{
	private readonly ChainSelenium _chainSelenium;

	public FindElementsBy(ChainSelenium chainSelenium)
	{
		_chainSelenium = chainSelenium;
	}

	public ChainSelenium Id(string id)
	{
		new ElementsFindersBuilder().FindElementsIfExistsById(id);
		return _chainSelenium;
	}
	public ChainSelenium ClassName(string className)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByClassName(className);
		return _chainSelenium;
	}
	public ChainSelenium CssSelector(string cssSelector)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByCssSelector(cssSelector);
		return _chainSelenium;
	}
	public ChainSelenium LinkText(string linkText)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByLinkText(linkText);
		return _chainSelenium;
	}
	public ChainSelenium Name(string name)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByName(name);
		return _chainSelenium;
	}
	public ChainSelenium PartialLinkText(string partialLinkText)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByPartialLinkText(partialLinkText);
		return _chainSelenium;
	}
	public ChainSelenium TagName(string tagName)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByTagName(tagName);
		return _chainSelenium;
	}
	public ChainSelenium XPath(string xPath)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByXPath(xPath);
		return _chainSelenium;
	}
}
