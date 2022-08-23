using SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;
using SeleniumChain.SeleniumChainClasses.Base;

namespace SeleniumChain.SeleniumChainClasses;
public class ClickOnElementBy:SeleniumChainBase, IClickOnElementBy
{

	private readonly ChainSelenium _chainSelenium;

	public ClickOnElementBy(ChainSelenium chainSelenium)
	{
		_chainSelenium = chainSelenium;
	}
	public ChainSelenium Id(string id)
	{
		new ClickOnElementBuilder().ClickOnElementById(id);
		return _chainSelenium;
	}
	public ChainSelenium ClassName(string className)
	{
		new ClickOnElementBuilder().ClickOnElementByClassName(className);
		return _chainSelenium;
	}
	public ChainSelenium CssSelector(string cssSelector)
	{
		new ClickOnElementBuilder().ClickOnElementByCssSelector(cssSelector);
		return _chainSelenium;
	}
	public ChainSelenium LinkText(string linkText)
	{
		new ClickOnElementBuilder().ClickOnElementByLinkText(linkText);
		return _chainSelenium;
	}
	public ChainSelenium Name(string name)
	{
		new ClickOnElementBuilder().ClickOnElementByName(name);
		return _chainSelenium;
	}
	public ChainSelenium PartialLinkText(string partialLinkText)
	{
		new ClickOnElementBuilder().ClickOnElementByPartialLinkText(partialLinkText);
		return _chainSelenium;
	}
	public ChainSelenium TagName(string tagName)
	{
		new ClickOnElementBuilder().ClickOnElementByTagName(tagName);
		return _chainSelenium;
	}
	public ChainSelenium XPath(string xPath)
	{
		new ClickOnElementBuilder().ClickOnElementByXPath(xPath);
		return _chainSelenium;
	}


}
