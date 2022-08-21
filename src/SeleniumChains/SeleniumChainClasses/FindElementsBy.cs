using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;
using SeleniumChains.SeleniumChainClasses.Base;

namespace SeleniumChains.SeleniumChainClasses;
public class FindElementsBy:SeleniumChainBase, IFindElementsBy
{
	private readonly SeleniumChain _seleniumChain;

	public FindElementsBy(SeleniumChain seleniumChain)
	{
		_seleniumChain = seleniumChain;
	}

	public SeleniumChain Id(string id)
	{
		new ElementsFindersBuilder().FindElementsIfExistsById(id);
		return _seleniumChain;
	}
	public SeleniumChain ClassName(string className)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByClassName(className);
		return _seleniumChain;
	}
	public SeleniumChain CssSelector(string cssSelector)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByCssSelector(cssSelector);
		return _seleniumChain;
	}
	public SeleniumChain LinkText(string linkText)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByLinkText(linkText);
		return _seleniumChain;
	}
	public SeleniumChain Name(string name)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByName(name);
		return _seleniumChain;
	}
	public SeleniumChain PartialLinkText(string partialLinkText)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByPartialLinkText(partialLinkText);
		return _seleniumChain;
	}
	public SeleniumChain TagName(string tagName)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByTagName(tagName);
		return _seleniumChain;
	}
	public SeleniumChain XPath(string xPath)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByXPath(xPath);
		return _seleniumChain;
	}
}
