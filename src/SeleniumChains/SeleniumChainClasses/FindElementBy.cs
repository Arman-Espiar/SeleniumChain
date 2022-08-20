using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;

namespace SeleniumChains.SeleniumChainClasses;
public class FindElementBy:SeleniumChainBase
{
	public void Id(string id)
	{
		new ElementFindersBuilder().FindElementIfExistsById(id);
	}
	public void ClassName(string className)
	{
		new ElementFindersBuilder().FindElementIfExistsByClassName(className);
	}
	public void CssSelector(string cssSelector)
	{
		new ElementFindersBuilder().FindElementIfExistsByCssSelector(cssSelector);
	}
	public void LinkText(string linkText)
	{
		new ElementFindersBuilder().FindElementIfExistsByLinkText(linkText);
	}
	public void Name(string name)
	{
		new ElementFindersBuilder().FindElementIfExistsByName(name);
	}
	public void PartialLinkText(string partialLinkText)
	{
		new ElementFindersBuilder().FindElementIfExistsByPartialLinkText(partialLinkText);
	}
	public void TagName(string tagName)
	{
		new ElementFindersBuilder().FindElementIfExistsByTagName(tagName);
	}
	public void XPath(string xPath)
	{
		new ElementFindersBuilder().FindElementIfExistsByXPath(xPath);
	}
}
