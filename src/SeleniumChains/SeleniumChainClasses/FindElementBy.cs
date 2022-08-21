using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;
using SeleniumChains.SeleniumChainClasses.Base;

namespace SeleniumChains.SeleniumChainClasses;
public class FindElementBy : SeleniumChainBase, IFindElementBy
{
	private readonly SeleniumChain _seleniumChain;

	public FindElementBy(SeleniumChain seleniumChain)
	{
		_seleniumChain = seleniumChain;
	}
	public SeleniumChain Id(string id)
	{
		new ElementFindersBuilder().FindElementIfExistsById(id);
		return _seleniumChain;
	}
	public SeleniumChain ClassName(string className)
	{
		new ElementFindersBuilder().FindElementIfExistsByClassName(className);
		return _seleniumChain;
	}
	public SeleniumChain CssSelector(string cssSelector)
	{
		new ElementFindersBuilder().FindElementIfExistsByCssSelector(cssSelector);
		return _seleniumChain;
	}
	public SeleniumChain LinkText(string linkText)
	{
		new ElementFindersBuilder().FindElementIfExistsByLinkText(linkText); 
		return _seleniumChain;
	}
	public SeleniumChain Name(string name)
	{
		new ElementFindersBuilder().FindElementIfExistsByName(name);
		return _seleniumChain;
	}
	public SeleniumChain PartialLinkText(string partialLinkText)
	{
		new ElementFindersBuilder().FindElementIfExistsByPartialLinkText(partialLinkText);
		return _seleniumChain;
	}
	public SeleniumChain TagName(string tagName)
	{
		new ElementFindersBuilder().FindElementIfExistsByTagName(tagName);
		return _seleniumChain;
	}
	public SeleniumChain XPath(string xPath)
	{
		new ElementFindersBuilder().FindElementIfExistsByXPath(xPath);
		return _seleniumChain;
	}
}
