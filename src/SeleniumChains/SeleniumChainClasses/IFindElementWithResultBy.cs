using OpenQA.Selenium;

namespace SeleniumChain.SeleniumChainClasses;
public interface IFindElementWithResultBy
{
	ChainSelenium Id(string id, out IWebElement? webElement);
	ChainSelenium ClassName(string className, out IWebElement? webElement);
	ChainSelenium CssSelector(string cssSelector, out IWebElement? webElement);
	ChainSelenium LinkText(string linkText, out IWebElement? webElement);
	ChainSelenium Name(string name, out IWebElement? webElement);
	ChainSelenium PartialLinkText(string partialLinkText, out IWebElement? webElement);
	ChainSelenium TagName(string tagName, out IWebElement? webElement);
	ChainSelenium XPath(string xPath, out IWebElement? webElement);
}