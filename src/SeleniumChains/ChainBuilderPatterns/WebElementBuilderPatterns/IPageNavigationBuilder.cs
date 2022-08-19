using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns;
public interface IPageNavigationBuilder
{
	IPageNavigationBuilder ScrollDown();
	IPageNavigationBuilder ScrollUp();

}

public class PageNavigationBuilder : IPageNavigationBuilder
{
	private readonly IWebDriver _driver;

	public PageNavigationBuilder(IWebDriver driver)
	{
		_driver = driver;
	}
	public IPageNavigationBuilder ScrollDown()
	{
		_driver?.FindElementIfExistsByTagName("html")?.SendKeys(Keys.End);
		return this;
	}

	public IPageNavigationBuilder ScrollUp()
	{
		_driver?.FindElementIfExistsByTagName("body")?.ScrollUpElement();
		return this;
	}
	
}
