using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;
using SeleniumChains.SeleniumChainClasses.Base;

namespace SeleniumChains.SeleniumChainClasses;
public class ClickOnElementBy:SeleniumChainBase, IClickOnElementBy
{

	private readonly SeleniumChain _seleniumChain;

	public ClickOnElementBy(SeleniumChain seleniumChain)
	{
		_seleniumChain = seleniumChain;
	}
	public SeleniumChain Id(string id)
	{
		new ClickOnElementBuilder().ClickOnElementById(id);
		return _seleniumChain;
	}
	public SeleniumChain ClassName(string className)
	{
		new ClickOnElementBuilder().ClickOnElementByClassName(className);
		return _seleniumChain;
	}
	public SeleniumChain CssSelector(string cssSelector)
	{
		new ClickOnElementBuilder().ClickOnElementByCssSelector(cssSelector);
		return _seleniumChain;
	}
	public SeleniumChain LinkText(string linkText)
	{
		new ClickOnElementBuilder().ClickOnElementByLinkText(linkText);
		return _seleniumChain;
	}
	public SeleniumChain Name(string name)
	{
		new ClickOnElementBuilder().ClickOnElementByName(name);
		return _seleniumChain;
	}
	public SeleniumChain PartialLinkText(string partialLinkText)
	{
		new ClickOnElementBuilder().ClickOnElementByPartialLinkText(partialLinkText);
		return _seleniumChain;
	}
	public SeleniumChain TagName(string tagName)
	{
		new ClickOnElementBuilder().ClickOnElementByTagName(tagName);
		return _seleniumChain;
	}
	public SeleniumChain XPath(string xPath)
	{
		new ClickOnElementBuilder().ClickOnElementByXPath(xPath);
		return _seleniumChain;
	}


}
