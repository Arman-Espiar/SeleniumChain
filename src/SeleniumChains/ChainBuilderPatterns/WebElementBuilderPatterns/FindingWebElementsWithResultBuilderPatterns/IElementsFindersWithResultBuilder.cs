using OpenQA.Selenium;

using SeleniumChain.SeleniumChainClasses.Base;

using SeleniumExtensionMethods.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsWithResultBuilderPatterns;
public interface IElementsFindersWithResultBuilder
{
	IElementsFindersWithResultBuilder FindElementsIfExistsById(string id, out IList<IWebElement>? wereTheyFound);
	IElementsFindersWithResultBuilder FindElementsIfExistsByTagName(string tagName, out IList<IWebElement>? wereTheyFound);
	IElementsFindersWithResultBuilder FindElementsIfExistsByClassName(string className, out IList<IWebElement>? wereTheyFound);
	IElementsFindersWithResultBuilder FindElementsIfExistsByCssSelector(string cssSelector, out IList<IWebElement>? wereTheyFound);
	IElementsFindersWithResultBuilder FindElementsIfExistsByLinkText(string linkText, out IList<IWebElement>? wereTheyFound);
	IElementsFindersWithResultBuilder FindElementsIfExistsByName(string name, out IList<IWebElement>? wereTheyFound);
	IElementsFindersWithResultBuilder FindElementsIfExistsByPartialLinkText(string partialLinkText, out IList<IWebElement>? wereTheyFound);
	IElementsFindersWithResultBuilder FindElementsIfExistsByXPath(string xPath, out IList<IWebElement>? wereTheyFound);

}

public class ElementsFindersWithResultBuilder : SeleniumChainBase, IElementsFindersWithResultBuilder
{
	public IElementsFindersWithResultBuilder FindElementsIfExistsById(string id, out IList<IWebElement>? wereTheyFound)
	{
		wereTheyFound = Driver?.FindElementsIfExistsById(id);
		return this;
	}



	public IElementsFindersWithResultBuilder FindElementsIfExistsByTagName(string tagName, out IList<IWebElement>? wereTheyFound)
	{
		wereTheyFound = Driver?.FindElementsIfExistsByTagName(tagName);
		return this;
	}



	public IElementsFindersWithResultBuilder FindElementsIfExistsByClassName(string className, out IList<IWebElement>? wereTheyFound)
	{
		wereTheyFound = Driver?.FindElementsIfExistsByClassName(className);
		return this;
	}



	public IElementsFindersWithResultBuilder FindElementsIfExistsByCssSelector(string cssSelector, out IList<IWebElement>? wereTheyFound)
	{
		wereTheyFound = Driver?.FindElementsIfExistsByCssSelector(cssSelector);
		return this;
	}



	public IElementsFindersWithResultBuilder FindElementsIfExistsByLinkText(string linkText, out IList<IWebElement>? wereTheyFound)
	{
		wereTheyFound = Driver?.FindElementsIfExistsByLinkText(linkText);
		return this;
	}



	public IElementsFindersWithResultBuilder FindElementsIfExistsByName(string name, out IList<IWebElement>? wereTheyFound)
	{
		wereTheyFound = Driver?.FindElementsIfExistsByName(name);
		return this;
	}



	public IElementsFindersWithResultBuilder FindElementsIfExistsByPartialLinkText(string partialLinkText, out IList<IWebElement>? wereTheyFound)
	{
		wereTheyFound = Driver?.FindElementsIfExistsByPartialLinkText(partialLinkText);
		return this;
	}



	public IElementsFindersWithResultBuilder FindElementsIfExistsByXPath(string xPath, out IList<IWebElement>? wereTheyFound)
	{
		wereTheyFound = Driver?.FindElementsIfExistsByXPath(xPath);
		return this;
	}
}
