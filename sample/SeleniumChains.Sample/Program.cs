using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumChains;

IWebDriver driver = new FirefoxDriver();

string webUrl = "https://www.wikipedia.org/";


new SeleniumChain(driver)
	.ImplicitWaitingForEachPageToLoad(TimeSpan.FromSeconds(3))
	.Goto(webUrl)
	.PageNavigation(builder => builder.ScrollDown())
	.ClickOnElement(builder => builder
		.ClickOnElementById("searchLanguage")
		.ClickOnElementByCssSelector("#searchLanguage > option:nth-child(21)")
	)
	.WriteInElement(builder => builder
		.WriteInElementById("searchInput", "کوروش")
		.WriteAppendInElementById(" بزرگ")
		.WritePrependInElementById("پادشاه " + Keys.Enter))
	.ClickOnElement(builder => builder
		.ClickOnElementByLinkText("کوروش بزرگ"))
	.ClickOnElement(builder => builder
		.ClickOnElementById("p-lang-btn")
		.ClickOnElementByXPath("/html/body/div[1]/div[2]/div[1]/div/ul[2]/li[3]/a")
	)
	.PageNavigation(builder => builder.ScrollDown())
	.ClickOnElement(builder => builder
		.ClickOnElementByCssSelector("#mw-normal-catlinks > ul:nth-child(2) > li:nth-child(1) > a:nth-child(1)")
	)
	.WriteInElement(builder => builder
		.WriteInElementById("searchInput", "ljklkjfdfdjkfasdfl")
		.ClearTextInputElementById()
		.WriteInElementById("Order of Assassins" + Keys.Enter)
	)
	;