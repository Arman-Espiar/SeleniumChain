using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
public interface IElementsFindersBuilder
{

    IElementsFindersBuilder FindElementsIfExistsById(string id);
    IElementsFindersBuilder FindElementsIfExistsByTagName(string tagName);
    IElementsFindersBuilder FindElementsIfExistsByClassName(string className);
    IElementsFindersBuilder FindElementsIfExistsByCssSelector(string cssSelector);
    IElementsFindersBuilder FindElementsIfExistsByLinkText(string linkText);
    IElementsFindersBuilder FindElementsIfExistsByName(string name);
    IElementsFindersBuilder FindElementsIfExistsByPartialLinkText(string partialLinkText);
    IElementsFindersBuilder FindElementsIfExistsByXPath(string xPath);

}

public class ElementsFindersBuilder :SeleniumChainBase, IElementsFindersBuilder
{

	public IElementsFindersBuilder FindElementsIfExistsById(string id)
    {
        Driver?.FindElementsIfExistsById(id);
        return this;
    }



    public IElementsFindersBuilder FindElementsIfExistsByTagName(string tagName)
    {
        Driver?.FindElementsIfExistsByTagName(tagName);
        return this;
    }



    public IElementsFindersBuilder FindElementsIfExistsByClassName(string className)
    {
        Driver?.FindElementsIfExistsByClassName(className);
        return this;
    }



    public IElementsFindersBuilder FindElementsIfExistsByCssSelector(string cssSelector)
    {
        Driver?.FindElementsIfExistsByCssSelector(cssSelector);
        return this;
    }



    public IElementsFindersBuilder FindElementsIfExistsByLinkText(string linkText)
    {
        Driver?.FindElementsIfExistsByLinkText(linkText);
        return this;
    }



    public IElementsFindersBuilder FindElementsIfExistsByName(string name)
    {
        Driver?.FindElementsIfExistsByName(name);
        return this;
    }



    public IElementsFindersBuilder FindElementsIfExistsByPartialLinkText(string partialLinkText)
    {
        Driver?.FindElementsIfExistsByPartialLinkText(partialLinkText);
        return this;
    }



    public IElementsFindersBuilder FindElementsIfExistsByXPath(string xPath)
    {
        Driver?.FindElementsIfExistsByXPath(xPath);
        return this;
    }

}
