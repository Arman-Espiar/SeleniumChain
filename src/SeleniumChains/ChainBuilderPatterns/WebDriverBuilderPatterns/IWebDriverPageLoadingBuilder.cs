using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebDriverExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebDriverBuilderPatterns;

public interface IWebDriverPageLoadingBuilder 
{
    IWebDriverPageLoadingBuilder WaitingForPageFullyLoadedByJavaScript(TimeSpan timeout);
    IWebDriverPageLoadingBuilder WaitingForPageLoad(TimeSpan timeout);
}

public class WebDriverPageLoadingBuilder :SeleniumChainBase, IWebDriverPageLoadingBuilder
{
	


	public IWebDriverPageLoadingBuilder WaitingForPageFullyLoadedByJavaScript(TimeSpan timeout)
    {
        Driver?.WaitingForPageFullyLoadedByJavaScript(timeout);
        return this;
    }

    public IWebDriverPageLoadingBuilder WaitingForPageLoad(TimeSpan timeout)
    {
        Driver?.WaitingForPageLoad(timeout);
        return this;
    }
}