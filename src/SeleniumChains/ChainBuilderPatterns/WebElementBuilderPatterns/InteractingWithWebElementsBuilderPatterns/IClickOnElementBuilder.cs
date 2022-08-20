using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;
public interface IClickOnElementBuilder
{
	IClickOnElementBuilder ClickOnElementById(string id);
	IClickOnElementBuilder ClickOnElementByTagName(string tagName);
	IClickOnElementBuilder ClickOnElementByClassName(string className);
	IClickOnElementBuilder ClickOnElementByCssSelector(string cssSelector);
	IClickOnElementBuilder ClickOnElementByLinkText(string linkText);
	IClickOnElementBuilder ClickOnElementByName(string name);
	IClickOnElementBuilder ClickOnElementByPartialLinkText(string partialLinkText);
	IClickOnElementBuilder ClickOnElementByXPath(string xPath);
}

public class ClickOnElementBuilder :SeleniumChainBase, IClickOnElementBuilder
{

	public IClickOnElementBuilder ClickOnElementById(string id)
	{
		Driver?.FindElementIfExistsById(id)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByTagName(string tagName)
	{
		Driver?.FindElementIfExistsByTagName(tagName)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByClassName(string className)
	{
		Driver?.FindElementIfExistsByClassName(className)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByCssSelector(string cssSelector)
	{
		Driver?.FindElementIfExistsByCssSelector(cssSelector)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByLinkText(string linkText)
	{
		Driver?.FindElementIfExistsByLinkText(linkText)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByName(string name)
	{
		Driver?.FindElementIfExistsByName(name)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByPartialLinkText(string partialLinkText)
	{
		Driver?.FindElementIfExistsByPartialLinkText(partialLinkText)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByXPath(string xPath)
	{
		Driver?.FindElementIfExistsByXPath(xPath)?.ClickOnElement();
		return this;
	}

}
