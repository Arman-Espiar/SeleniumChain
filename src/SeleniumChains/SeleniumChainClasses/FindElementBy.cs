using SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
using SeleniumChain.SeleniumChainClasses.Base;

namespace SeleniumChain.SeleniumChainClasses;
public class FindElementBy : SeleniumChainBase, IFindElementBy
{
	private readonly ChainSelenium _chainSelenium;

	public FindElementBy(ChainSelenium chainSelenium)
	{
		_chainSelenium = chainSelenium;
	}
	public ChainSelenium Id(string id)
	{
		new ElementFindersBuilder().FindElementIfExistsById(id);
		return _chainSelenium;
	}
	public ChainSelenium ClassName(string className)
	{
		new ElementFindersBuilder().FindElementIfExistsByClassName(className);
		return _chainSelenium;
	}
	public ChainSelenium CssSelector(string cssSelector)
	{
		new ElementFindersBuilder().FindElementIfExistsByCssSelector(cssSelector);
		return _chainSelenium;
	}
	public ChainSelenium LinkText(string linkText)
	{
		new ElementFindersBuilder().FindElementIfExistsByLinkText(linkText); 
		return _chainSelenium;
	}
	public ChainSelenium Name(string name)
	{
		new ElementFindersBuilder().FindElementIfExistsByName(name);
		return _chainSelenium;
	}
	public ChainSelenium PartialLinkText(string partialLinkText)
	{
		new ElementFindersBuilder().FindElementIfExistsByPartialLinkText(partialLinkText);
		return _chainSelenium;
	}
	public ChainSelenium TagName(string tagName)
	{
		new ElementFindersBuilder().FindElementIfExistsByTagName(tagName);
		return _chainSelenium;
	}
	public ChainSelenium XPath(string xPath)
	{
		new ElementFindersBuilder().FindElementIfExistsByXPath(xPath);
		return _chainSelenium;
	}
}
