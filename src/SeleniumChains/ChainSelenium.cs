﻿using OpenQA.Selenium;
using SeleniumChain.ChainBuilderPatterns.WebDriverBuilderPatterns.BrowserBuilderPatterns;
using SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns;
using SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsBuilderPatterns;
using SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.FindingWebElementsWithResultBuilderPatterns;
using SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;
using SeleniumChain.SeleniumChainClasses.Base;
using SeleniumExtensionMethods.SeleniumExtensions.WebDriverExtensions;
using SeleniumExtensionMethods.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChain;
public class ChainSelenium : SeleniumChainBase
{
	public ChainSelenium()
	{
		ChainBase.SetSeleniumChain(this);
	}
	public ChainSelenium SetDriver(IWebDriver? driver)
	{
		Driver = driver;
		return this;
	}
	public ChainSelenium Goto(string url)
	{
		Driver?.GotoUrl(url);
		return this;
	}
	public ChainSelenium Goto(Uri url)
	{
		Driver?.GotoUrl(url);
		return this;
	}
	public ChainSelenium ImplicitWaitingForEachPageToLoad(TimeSpan timeout)
	{
		Driver?.WaitingForEachPageToLoad(timeout);
		return this;
	}

	public ChainSelenium PageScrollDown()
	{
		Driver?.FindElementIfExistsByTagName("html")?.ScrollDownElement();
		return this;
	}
	public ChainSelenium PageScrollUp()
	{
		Driver?.FindElementIfExistsByTagName("html")?.ScrollUpElement();
		return this;
	}

	public ChainSelenium ScrollDownElementIfExistsById(string id)
	{
		Driver?.FindElementIfExistsById(id).ScrollDownElement();
		return this;
	}
	public ChainSelenium ScrollUpElementIfExistsById(string id)
	{
		Driver?.FindElementIfExistsById(id).ScrollUpElement();
		return this;
	}

	public ChainSelenium PageNavigation(Action<IPageNavigationBuilder> configure)
	{
		var pageNavigationBuilder = new PageNavigationBuilder();
		configure(pageNavigationBuilder);
		return this;
	}

	public ChainSelenium BrowserNavigation(Action<IBrowserNavigationBuilder> configure)
	{
		var browserNavigationBuilder = new BrowserNavigationBuilder();
		configure(browserNavigationBuilder);
		return this;
	}

	public ChainSelenium ClickOnElement(Action<IClickOnElementBuilder> configure)
	{
		var webElementBuilder = new ClickOnElementBuilder();
		configure(webElementBuilder);
		return this;
	}

	public ChainSelenium WriteInElement(Action<IWriteBuilder> configure)
	{
		var writeBuilder = new WriteBuilder();
		configure(writeBuilder);
		return this;
	}

	public ChainSelenium FindElement(Action<IElementsFindersBuilder> configure)
	{
		var webElementBuilder = new ElementsFindersBuilder();
		configure(webElementBuilder);
		return this;
	}
	public ChainSelenium FindElements(Action<IElementsFindersBuilder> configure)
	{
		var webElementsBuilder = new ElementsFindersBuilder();
		configure(webElementsBuilder);
		return this;
	}
	public ChainSelenium FindElementWithResult(Action<IElementsFindersWithResultBuilder> configure)
	{
		var webElementWithResultBuilder = new ElementsFindersWithResultBuilder();
		configure(webElementWithResultBuilder);
		return this;
	}
	public ChainSelenium FindElementsWithResult(Action<IElementsFindersWithResultBuilder> configure)
	{
		var webElementsWithResultBuilder = new ElementsFindersWithResultBuilder();
		configure(webElementsWithResultBuilder);
		return this;
	}
	#region FindElementsBy
	public ChainSelenium FindElementsIfExistsById(string id)
	{
		return ChainBase.FindElementsBy.Id(id);
	}
	public ChainSelenium FindElementsIfExistsByClassName(string className)
	{
		return ChainBase.FindElementsBy.ClassName(className);
	}
	public ChainSelenium FindElementsIfExistsByCssSelector(string cssSelector)
	{
		return ChainBase.FindElementsBy.CssSelector(cssSelector);
	}
	public ChainSelenium FindElementsIfExistsByLinkText(string linkText)
	{
		return ChainBase.FindElementsBy.LinkText(linkText);
	}
	public ChainSelenium FindElementsIfExistsByName(string name)
	{
		return ChainBase.FindElementsBy.Name(name);
	}
	public ChainSelenium FindElementsIfExistsByPartialLinkText(string partialLinkText)
	{
		return ChainBase.FindElementsBy.PartialLinkText(partialLinkText);
	}
	public ChainSelenium FindElementsIfExistsByTagName(string tagName)
	{
		return ChainBase.FindElementsBy.TagName(tagName);
	}
	public ChainSelenium FindElementsIfExistsByXPath(string xPath)
	{
		return ChainBase.FindElementsBy.XPath(xPath);
	}
	#endregion End FindElementsBy

	#region FindElementsWithResultBy
	public ChainSelenium FindElementsIfExistsWithResultById(string id, out IList<IWebElement>? webElements)
	{
		return ChainBase.FindElementsWithResultBy.Id(id,out webElements);
	}
	public ChainSelenium FindElementsIfExistsWithResultByClassName(string className, out IList<IWebElement>? webElements)
	{
		return ChainBase.FindElementsWithResultBy.ClassName(className, out webElements);
	}
	public ChainSelenium FindElementsIfExistsWithResultByCssSelector(string cssSelector, out IList<IWebElement>? webElements)
	{
		return ChainBase.FindElementsWithResultBy.CssSelector(cssSelector, out webElements);
	}
	public ChainSelenium FindElementsIfExistsWithResultByLinkText(string linkText, out IList<IWebElement>? webElements)
	{
		return ChainBase.FindElementsWithResultBy.LinkText(linkText, out webElements);
	}
	public ChainSelenium FindElementsIfExistsWithResultByName(string name, out IList<IWebElement>? webElements)
	{
		return ChainBase.FindElementsWithResultBy.Name(name, out webElements);
	}
	public ChainSelenium FindElementsIfExistsWithResultByPartialLinkText(string partialLinkText, out IList<IWebElement>? webElements)
	{
		return ChainBase.FindElementsWithResultBy.PartialLinkText(partialLinkText, out webElements);
	}
	public ChainSelenium FindElementsIfExistsWithResultByTagName(string tagName, out IList<IWebElement>? webElements)
	{
		return ChainBase.FindElementsWithResultBy.TagName(tagName, out webElements);
	}
	public ChainSelenium FindElementsIfExistsWithResultByXPath(string xPath, out IList<IWebElement>? webElements)
	{
		return ChainBase.FindElementsWithResultBy.XPath(xPath, out webElements);
	}
	#endregion End FindElementsWithResultBy

	#region FindElementBy
	public ChainSelenium FindElementIfExistsById(string id)
	{
		return ChainBase.FindElementBy.Id(id);
	}
	public ChainSelenium FindElementIfExistsByClassName(string className)
	{
		return ChainBase.FindElementBy.ClassName(className);
	}
	public ChainSelenium FindElementIfExistsByCssSelector(string cssSelector)
	{
		return ChainBase.FindElementBy.CssSelector(cssSelector);
	}
	public ChainSelenium FindElementIfExistsByLinkText(string linkText)
	{
		return ChainBase.FindElementBy.LinkText(linkText);
	}
	public ChainSelenium FindElementIfExistsByName(string name)
	{
		return ChainBase.FindElementBy.Name(name);
	}
	public ChainSelenium FindElementIfExistsByPartialLinkText(string partialLinkText)
	{
		return ChainBase.FindElementBy.PartialLinkText(partialLinkText);
	}
	public ChainSelenium FindElementIfExistsByTagName(string tagName)
	{
		return ChainBase.FindElementBy.TagName(tagName);
	}
	public ChainSelenium FindElementIfExistsByXPath(string xPath)
	{
		return ChainBase.FindElementBy.XPath(xPath);
	}
	#endregion End FindElementBy

	#region FindElementWithResultBy
	public ChainSelenium FindElementIfExistsWithResultById(string id, out IWebElement? webElement)
	{
		return ChainBase.FindElementWithResultBy.Id(id,out webElement);
	}
	public ChainSelenium FindElementIfExistsWithResultByClassName(string className, out IWebElement? webElement)
	{
		return ChainBase.FindElementWithResultBy.ClassName(className, out webElement);
	}
	public ChainSelenium FindElementIfExistsWithResultByCssSelector(string cssSelector, out IWebElement? webElement)
	{
		return ChainBase.FindElementWithResultBy.CssSelector(cssSelector, out webElement);
	}
	public ChainSelenium FindElementIfExistsWithResultByLinkText(string linkText, out IWebElement? webElement)
	{
		return ChainBase.FindElementWithResultBy.LinkText(linkText, out webElement);
	}
	public ChainSelenium FindElementIfExistsWithResultByName(string name, out IWebElement? webElement)
	{
		return ChainBase.FindElementWithResultBy.Name(name, out webElement);
	}
	public ChainSelenium FindElementIfExistsWithResultByPartialLinkText(string partialLinkText, out IWebElement? webElement)
	{
		return ChainBase.FindElementWithResultBy.PartialLinkText(partialLinkText, out webElement);
	}
	public ChainSelenium FindElementIfExistsWithResultByTagName(string tagName, out IWebElement? webElement)
	{
		return ChainBase.FindElementWithResultBy.TagName(tagName, out webElement);
	}
	public ChainSelenium FindElementIfExistsWithResultByXPath(string xPath, out IWebElement? webElement)
	{
		return ChainBase.FindElementWithResultBy.XPath(xPath, out webElement);
	}
	#endregion End FindElementWithResultBy

	#region ClickOnElementBy
	public ChainSelenium ClickOnElementById(string id)
	{
		return ChainBase.ClickOnElementBy.Id(id);
	}
	public ChainSelenium ClickOnElementByClassName(string className)
	{
		return ChainBase.ClickOnElementBy.ClassName(className);
	}
	public ChainSelenium ClickOnElementByCssSelector(string cssSelector)
	{
		return ChainBase.ClickOnElementBy.CssSelector(cssSelector);
	}
	public ChainSelenium ClickOnElementByLinkText(string linkText)
	{
		return ChainBase.ClickOnElementBy.LinkText(linkText);
	}
	public ChainSelenium ClickOnElementByName(string name)
	{
		return ChainBase.ClickOnElementBy.Name(name);

	}
	public ChainSelenium ClickOnElementByPartialLinkText(string partialLinkText)
	{
		return ChainBase.ClickOnElementBy.PartialLinkText(partialLinkText);
	}
	public ChainSelenium ClickOnElementByTagName(string tagName)
	{
		return ChainBase.ClickOnElementBy.TagName(tagName);
	}
	public ChainSelenium ClickOnElementByXPath(string xPath)
	{
		return ChainBase.ClickOnElementBy.XPath(xPath);
	}
	#endregion End ClickOnElementBy
	public void CloseBrowser() => Driver?.Close();
}