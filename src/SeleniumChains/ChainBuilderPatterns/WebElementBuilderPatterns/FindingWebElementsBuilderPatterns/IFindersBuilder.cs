using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
public interface IFindersBuilder
{

    IFindersBuilder FindElementsIfExistsById(string id);
    IFindersBuilder FindElementsIfExistsByTagName(string tagName);
    IFindersBuilder FindElementsIfExistsByClassName(string className);
    IFindersBuilder FindElementsIfExistsByCssSelector(string cssSelector);
    IFindersBuilder FindElementsIfExistsByLinkText(string linkText);
    IFindersBuilder FindElementsIfExistsByName(string name);
    IFindersBuilder FindElementsIfExistsByPartialLinkText(string partialLinkText);
    IFindersBuilder FindElementsIfExistsByXPath(string xPath);

}

public class FindersBuilder : IFindersBuilder
{
    private readonly IWebDriver _driver;

    public FindersBuilder(IWebDriver driver)
    {
        _driver = driver;
    }



    public IFindersBuilder FindElementsIfExistsById(string id)
    {
        _driver.FindElementsIfExistsById(id);
        return this;
    }



    public IFindersBuilder FindElementsIfExistsByTagName(string tagName)
    {
        _driver.FindElementsIfExistsByTagName(tagName);
        return this;
    }



    public IFindersBuilder FindElementsIfExistsByClassName(string className)
    {
        _driver.FindElementsIfExistsByClassName(className);
        return this;
    }



    public IFindersBuilder FindElementsIfExistsByCssSelector(string cssSelector)
    {
        _driver.FindElementsIfExistsByCssSelector(cssSelector);
        return this;
    }



    public IFindersBuilder FindElementsIfExistsByLinkText(string linkText)
    {
        _driver.FindElementsIfExistsByLinkText(linkText);
        return this;
    }



    public IFindersBuilder FindElementsIfExistsByName(string name)
    {
        _driver.FindElementsIfExistsByName(name);
        return this;
    }



    public IFindersBuilder FindElementsIfExistsByPartialLinkText(string partialLinkText)
    {
        _driver.FindElementsIfExistsByPartialLinkText(partialLinkText);
        return this;
    }



    public IFindersBuilder FindElementsIfExistsByXPath(string xPath)
    {
        _driver.FindElementsIfExistsByXPath(xPath);
        return this;
    }

}
