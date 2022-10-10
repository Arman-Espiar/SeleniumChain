using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

using SeleniumChain;

IWebDriver driver = new FirefoxDriver();

string webUrl = "https://www.wikipedia.org/";


var chineSelenium = new ChainSelenium().SetDriver(driver)
	.ImplicitWaitingForEachPageToLoad(TimeSpan.FromSeconds(3))
	.Goto(webUrl)
	.PageScrollDown()
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
	.PageScrollDown()
	.ClickOnElement(config => config
		.ClickOnElementByCssSelector("#mw-normal-catlinks > ul:nth-child(2) > li:nth-child(1) > a:nth-child(1)")
	)
	.WriteInElement(config => config
		.WriteInElementById("searchInput", "ljklkjfdfdjkfasdfl")
		.ClearTextInputElementById()
		.WriteInElementById("Order of Assassins" + Keys.Enter)
	)
	.ClickOnElement(config => config
		.ClickOnElementByXPath("/html/body/div[3]/div[3]/div[5]/div[1]/div[4]/ul/li[5]/a"))
	.ClickOnElementById("p-logo")
	.ClickOnElementById("ca-viewsource")
	.ScrollDownElementIfExistsById("wpTextbox1")
	.FindElementIfExistsWithResultById("dummyid", out var result)
	;

if (result is null)
{
	chineSelenium.CloseBrowser();
}