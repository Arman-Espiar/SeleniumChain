namespace SeleniumChain.SeleniumChainClasses;

public interface IFindElementBy
{
	ChainSelenium Id(string id);
	ChainSelenium ClassName(string className);
	ChainSelenium CssSelector(string cssSelector);
	ChainSelenium LinkText(string linkText);
	ChainSelenium Name(string name);
	ChainSelenium PartialLinkText(string partialLinkText);
	ChainSelenium TagName(string tagName);
	ChainSelenium XPath(string xPath);
}