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

public class ClickOnElementBuilder : IClickOnElementBuilder
{
	private  readonly IWebDriver _driver;

	public ClickOnElementBuilder(IWebDriver driver)
	{
		_driver = driver;
	}
	public IClickOnElementBuilder ClickOnElementById(string id)
	{
		_driver.FindElementIfExistsById(id)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByTagName(string tagName)
	{
		_driver.FindElementIfExistsByTagName(tagName)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByClassName(string className)
	{
		_driver.FindElementIfExistsByClassName(className)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByCssSelector(string cssSelector)
	{
		_driver.FindElementIfExistsByCssSelector(cssSelector)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByLinkText(string linkText)
	{
		_driver.FindElementIfExistsByLinkText(linkText)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByName(string name)
	{
		_driver.FindElementIfExistsByName(name)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByPartialLinkText(string partialLinkText)
	{
		_driver.FindElementIfExistsByPartialLinkText(partialLinkText)?.ClickOnElement();
		return this;
	}
	public IClickOnElementBuilder ClickOnElementByXPath(string xPath)
	{
		_driver.FindElementIfExistsByXPath(xPath)?.ClickOnElement();
		return this;
	}

}
