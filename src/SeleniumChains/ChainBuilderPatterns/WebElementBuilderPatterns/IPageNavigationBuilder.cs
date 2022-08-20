using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebElementBuilderPatterns;
public interface IPageNavigationBuilder
{
	IPageNavigationBuilder ScrollDown();
	IPageNavigationBuilder ScrollUp();

}

public class PageNavigationBuilder :SeleniumChainBase, IPageNavigationBuilder
{
	
	public IPageNavigationBuilder ScrollDown()
	{
		Driver?.FindElementIfExistsByTagName("html")?.ScrollDownElement();
		return this;
	}

	public IPageNavigationBuilder ScrollUp()
	{
		Driver?.FindElementIfExistsByTagName("body")?.ScrollUpElement();
		return this;
	}
	
}
