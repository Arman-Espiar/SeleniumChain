using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebDriverExtensions;

namespace SeleniumChains.SeleniumExtensions.WebElementExtensions;
public static class LocatorExtensions
{
    public static IWebElement? FindElementIfExistsById(this IWebDriver driver, string id)
    {
        var element = driver.FindElementIfExists(By.Id(id));
        return element;
    }
    public static IList<IWebElement>? FindElementsIfExistsById(this IWebDriver driver, string id)
    {
        var element = driver.FindElementsIfExists(By.Id(id));
        return element;
    }
    public static IWebElement? FindElementIfExistsByTagName(this IWebDriver driver, string tagName)
    {
        var element = driver.FindElementIfExists(By.TagName(tagName));
        return element;
    }
    public static IList<IWebElement>? FindElementsIfExistsByTagName(this IWebDriver driver, string tagName)
    {
        var element = driver.FindElementsIfExists(By.TagName(tagName));
        return element;
    }
    public static IWebElement? FindElementIfExistsByClassName(this IWebDriver driver, string className)
    {
        var element = driver.FindElementIfExists(By.ClassName(className));
        return element;
    }
    public static IList<IWebElement>? FindElementsIfExistsByClassName(this IWebDriver driver, string className)
    {
        var element = driver.FindElementsIfExists(By.ClassName(className));
        return element;
    }
    public static IWebElement? FindElementIfExistsByCssSelector(this IWebDriver driver, string cssSelector)
    {
        var element = driver.FindElementIfExists(By.CssSelector(cssSelector));
        return element;
    }
    public static IList<IWebElement>? FindElementsIfExistsByCssSelector(this IWebDriver driver, string cssSelector)
    {
        var element = driver.FindElementsIfExists(By.CssSelector(cssSelector));
        return element;
    }
    public static IWebElement? FindElementIfExistsByLinkText(this IWebDriver driver, string linkText)
    {
        var element = driver.FindElementIfExists(By.LinkText(linkText));
        return element;
    }
    public static IList<IWebElement>? FindElementsIfExistsByLinkText(this IWebDriver driver, string linkText)
    {
        var element = driver.FindElementsIfExists(By.LinkText(linkText));
        return element;
    }
    public static IWebElement? FindElementIfExistsByName(this IWebDriver driver, string name)
    {
        var element = driver.FindElementIfExists(By.Name(name));
        return element;
    }
    public static IList<IWebElement>? FindElementsIfExistsByName(this IWebDriver driver, string name)
    {
        var element = driver.FindElementsIfExists(By.Name(name));
        return element;
    }
    public static IWebElement? FindElementIfExistsByPartialLinkText(this IWebDriver driver, string partialLinkText)
    {
        var element = driver.FindElementIfExists(By.PartialLinkText(partialLinkText));
        return element;
    }
    public static IList<IWebElement>? FindElementsIfExistsByPartialLinkText(this IWebDriver driver, string partialLinkText)
    {
        var element = driver.FindElementsIfExists(By.PartialLinkText(partialLinkText));
        return element;
    }
    public static IWebElement? FindElementIfExistsByXPath(this IWebDriver driver, string xPath)
    {
        var element = driver.FindElementIfExists(By.XPath(xPath));
        return element;
    }
    public static IList<IWebElement>? FindElementsIfExistsByXPath(this IWebDriver driver, string xPath)
    {
        var element = driver.FindElementsIfExists(By.XPath(xPath));
        return element;
    }
}
