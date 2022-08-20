using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;

namespace SeleniumChains.SeleniumChainClasses;
public class FindElementsBy:SeleniumChainBase
{
	public void Id(string id)
	{
		new ElementsFindersBuilder().FindElementsIfExistsById(id);
	}
	public void ClassName(string className)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByClassName(className);
	}
	public void CssSelector(string cssSelector)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByCssSelector(cssSelector);
	}
	public void LinkText(string linkText)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByLinkText(linkText);
	}
	public void Name(string name)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByName(name);
	}
	public void PartialLinkText(string partialLinkText)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByPartialLinkText(partialLinkText);
	}
	public void TagName(string tagName)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByTagName(tagName);
	}
	public void XPath(string xPath)
	{
		new ElementsFindersBuilder().FindElementsIfExistsByXPath(xPath);
	}
}
