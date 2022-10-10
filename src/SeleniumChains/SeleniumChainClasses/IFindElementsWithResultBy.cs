using OpenQA.Selenium;

namespace SeleniumChain.SeleniumChainClasses;
public interface IFindElementsWithResultBy
{
	ChainSelenium Id(string id, out IList<IWebElement>? webElements);
	ChainSelenium ClassName(string className, out IList<IWebElement>? webElements);
	ChainSelenium CssSelector(string cssSelector, out IList<IWebElement>? webElements);
	ChainSelenium LinkText(string linkText, out IList<IWebElement>? webElements);
	ChainSelenium Name(string name, out IList<IWebElement>? webElements);
	ChainSelenium PartialLinkText(string partialLinkText, out IList<IWebElement>? webElements);
	ChainSelenium TagName(string tagName, out IList<IWebElement>? webElements);
	ChainSelenium XPath(string xPath, out IList<IWebElement>? webElements);
}
