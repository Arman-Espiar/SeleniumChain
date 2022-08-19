using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebDriverExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebDriverBuilderPatterns;

public interface IWebDriverPageLoadingBuilder 
{
    //IWebDriverPageLoadingBuilder WaitingForFullyLoadedInAllPages();
    IWebDriverPageLoadingBuilder WaitingForPageFullyLoadedByJavaScript(TimeSpan timeout);
    IWebDriverPageLoadingBuilder WaitingForPageLoad(TimeSpan timeout);
}

public class WebDriverPageLoadingBuilder : IWebDriverPageLoadingBuilder
{
    private readonly IWebDriver _driver;

    public WebDriverPageLoadingBuilder(IWebDriver driver)
    {
        _driver = driver;
    }


    public IWebDriverPageLoadingBuilder WaitingForPageFullyLoadedByJavaScript(TimeSpan timeout)
    {
        _driver.WaitingForPageFullyLoadedByJavaScript(timeout);
        return this;
    }

    public IWebDriverPageLoadingBuilder WaitingForPageLoad(TimeSpan timeout)
    {
        _driver.WaitingForPageLoad(timeout);
        return this;
    }
}