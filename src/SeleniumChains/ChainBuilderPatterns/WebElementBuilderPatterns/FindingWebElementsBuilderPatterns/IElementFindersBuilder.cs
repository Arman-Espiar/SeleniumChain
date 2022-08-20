using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
public interface IElementFindersBuilder
{

    IElementFindersBuilder FindElementIfExistsById(string id);
    IElementFindersBuilder FindElementIfExistsByTagName(string tagName);
    IElementFindersBuilder FindElementIfExistsByClassName(string className);
    IElementFindersBuilder FindElementIfExistsByCssSelector(string cssSelector);
    IElementFindersBuilder FindElementIfExistsByLinkText(string linkText);
    IElementFindersBuilder FindElementIfExistsByName(string name);
    IElementFindersBuilder FindElementIfExistsByPartialLinkText(string partialLinkText);
    IElementFindersBuilder FindElementIfExistsByXPath(string xPath);

}

public class ElementFindersBuilder :SeleniumChainBase, IElementFindersBuilder
{

	public IElementFindersBuilder FindElementIfExistsById(string id)
    {
        Driver?.FindElementIfExistsById(id);
        return this;
    }



    public IElementFindersBuilder FindElementIfExistsByTagName(string tagName)
    {
        Driver?.FindElementIfExistsByTagName(tagName);
        return this;
    }



    public IElementFindersBuilder FindElementIfExistsByClassName(string className)
    {
        Driver?.FindElementIfExistsByClassName(className);
        return this;
    }



    public IElementFindersBuilder FindElementIfExistsByCssSelector(string cssSelector)
    {
        Driver?.FindElementIfExistsByCssSelector(cssSelector);
        return this;
    }



    public IElementFindersBuilder FindElementIfExistsByLinkText(string linkText)
    {
        Driver?.FindElementIfExistsByLinkText(linkText);
        return this;
    }



    public IElementFindersBuilder FindElementIfExistsByName(string name)
    {
        Driver?.FindElementIfExistsByName(name);
        return this;
    }



    public IElementFindersBuilder FindElementIfExistsByPartialLinkText(string partialLinkText)
    {
        Driver?.FindElementIfExistsByPartialLinkText(partialLinkText);
        return this;
    }



    public IElementFindersBuilder FindElementIfExistsByXPath(string xPath)
    {
        Driver?.FindElementIfExistsByXPath(xPath);
        return this;
    }

}
