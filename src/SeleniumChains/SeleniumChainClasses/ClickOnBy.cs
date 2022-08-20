using SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;

namespace SeleniumChains.SeleniumChainClasses;
public class ClickOnBy:SeleniumChainBase
{

	public void Id(string id)
	{
		new ClickOnElementBuilder().ClickOnElementById(id);
	}
	public void ClassName(string className)
	{
		new ClickOnElementBuilder().ClickOnElementByClassName(className);
	}
	public void CssSelector(string cssSelector)
	{
		new ClickOnElementBuilder().ClickOnElementByCssSelector(cssSelector);
	}
	public void LinkText(string linkText)
	{
		new ClickOnElementBuilder().ClickOnElementByLinkText(linkText);
	}
	public void Name(string name)
	{
		new ClickOnElementBuilder().ClickOnElementByName(name);
	}
	public void PartialLinkText(string partialLinkText)
	{
		new ClickOnElementBuilder().ClickOnElementByPartialLinkText(partialLinkText);
	}
	public void TagName(string tagName)
	{
		new ClickOnElementBuilder().ClickOnElementByTagName(tagName);
	}
	public void XPath(string xPath)
	{
		new ClickOnElementBuilder().ClickOnElementByXPath(xPath);
	}

	
}
