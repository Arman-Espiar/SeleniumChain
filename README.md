# SeleniumChains

SeleniumChains is a library for fluent use and Avoiding repetitive code. This library has many helpful extension methods.

## Usage

```csharp
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumChains;

IWebDriver driver = new FirefoxDriver();

string webUrl = "https://www.wikipedia.org/";


new SeleniumChain(driver)
	.ImplicitWaitingForEachPageToLoad(TimeSpan.FromSeconds(3))
	.Goto(webUrl)
	.PageNavigation(config => config.ScrollDown())
	.ClickOnElement(config => config
		.ClickOnElementById("searchLanguage")
		.ClickOnElementByCssSelector("#searchLanguage > option:nth-child(21)")
	)
	.WriteInElement(config => config
		.WriteInElementById("searchInput", "کوروش")
		.WriteAppendInElementById(" بزرگ")
		.WritePrependInElementById("پادشاه " + Keys.Enter))
	.ClickOnElement(config => config
		.ClickOnElementByLinkText("کوروش بزرگ"))
	.ClickOnElement(config => config
		.ClickOnElementById("p-lang-btn")
		.ClickOnElementByXPath("/html/body/div[1]/div[2]/div[1]/div/ul[2]/li[3]/a")
	)
	.PageNavigation(config => config.ScrollDown())
	.ClickOnElement(config => config
		.ClickOnElementByCssSelector("#mw-normal-catlinks > ul:nth-child(2) > li:nth-child(1) > a:nth-child(1)")
	)
	.WriteInElement(config => config
		.WriteInElementById("searchInput", "ljklkjfdfdjkfasdfl")
		.ClearTextInputElementById()
		.WriteInElementById("Order of Assassins" + Keys.Enter)
	)
	;
```

## wiki
[wiki](https://github.com/Arman-Espiar/SeleniumChains/wiki)
