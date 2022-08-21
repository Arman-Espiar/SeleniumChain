namespace SeleniumChains.SeleniumChainClasses;

public interface IFindElementBy
{
	SeleniumChain Id(string id);
	SeleniumChain ClassName(string className);
	SeleniumChain CssSelector(string cssSelector);
	SeleniumChain LinkText(string linkText);
	SeleniumChain Name(string name);
	SeleniumChain PartialLinkText(string partialLinkText);
	SeleniumChain TagName(string tagName);
	SeleniumChain XPath(string xPath);
}