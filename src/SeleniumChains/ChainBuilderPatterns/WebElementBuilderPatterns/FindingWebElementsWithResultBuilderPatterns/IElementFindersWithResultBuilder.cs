using SeleniumChain.SeleniumChainClasses.Base;

using SeleniumExtensionMethods.SeleniumExtensions.WebElementExtensions;
using OpenQA.Selenium;

namespace SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsWithResultBuilderPatterns;
public interface IElementFindersWithResultBuilder
{
	IElementFindersWithResultBuilder FindElementIfExistsById(string id, out IWebElement? webElement);
	IElementFindersWithResultBuilder FindElementIfExistsByTagName(string tagName, out IWebElement? webElement);
	IElementFindersWithResultBuilder FindElementIfExistsByClassName(string className, out IWebElement? webElement);
	IElementFindersWithResultBuilder FindElementIfExistsByCssSelector(string cssSelector, out IWebElement? webElement);
	IElementFindersWithResultBuilder FindElementIfExistsByLinkText(string linkText, out IWebElement? webElement);
	IElementFindersWithResultBuilder FindElementIfExistsByName(string name, out IWebElement? webElement);
	IElementFindersWithResultBuilder FindElementIfExistsByPartialLinkText(string partialLinkText, out IWebElement? webElement);
	IElementFindersWithResultBuilder FindElementIfExistsByXPath(string xPath, out IWebElement? webElement);
}

public class ElementFindersWithResultBuilder : SeleniumChainBase, IElementFindersWithResultBuilder
{
	public IElementFindersWithResultBuilder FindElementIfExistsById(string id, out IWebElement? webElement)
	{
		webElement = Driver?.FindElementIfExistsById(id);
		return this;
	}



	public IElementFindersWithResultBuilder FindElementIfExistsByTagName(string tagName, out IWebElement? webElement)
	{
		webElement = Driver?.FindElementIfExistsByTagName(tagName);
		return this;
	}



	public IElementFindersWithResultBuilder FindElementIfExistsByClassName(string className, out IWebElement? webElement)
	{
		webElement = Driver?.FindElementIfExistsByClassName(className);
		return this;
	}



	public IElementFindersWithResultBuilder FindElementIfExistsByCssSelector(string cssSelector, out IWebElement? webElement)
	{
		webElement = Driver?.FindElementIfExistsByCssSelector(cssSelector);
		return this;
	}



	public IElementFindersWithResultBuilder FindElementIfExistsByLinkText(string linkText, out IWebElement? webElement)
	{
		webElement = Driver?.FindElementIfExistsByLinkText(linkText);
		return this;
	}



	public IElementFindersWithResultBuilder FindElementIfExistsByName(string name, out IWebElement? webElement)
	{
		webElement = Driver?.FindElementIfExistsByName(name);
		return this;
	}



	public IElementFindersWithResultBuilder FindElementIfExistsByPartialLinkText(string partialLinkText, out IWebElement? webElement)
	{
		webElement = Driver?.FindElementIfExistsByPartialLinkText(partialLinkText);
		return this;
	}



	public IElementFindersWithResultBuilder FindElementIfExistsByXPath(string xPath, out IWebElement? webElement)
	{
		webElement = Driver?.FindElementIfExistsByXPath(xPath);
		return this;
	}
}
