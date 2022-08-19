using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebDriverExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebDriverBuilderPatterns;
public interface IWebDriverBuilder 
{
	IWebDriverBuilder AsynchronousJavaScriptLoad(TimeSpan timeout);
    IWebDriverBuilder JavaScriptLoad(string script);
    IWebDriverBuilder JavaScriptLoad(string script, params object[] args);
}

public class WebDriverBuilder : IWebDriverBuilder
{
    private readonly IWebDriver _driver;
    public WebDriverBuilder(IWebDriver driver)
    {
        _driver = driver;
    }

    public IWebDriverBuilder AsynchronousJavaScriptLoad(TimeSpan timeout)
    {
        _driver.AsynchronousJavaScriptLoad(timeout);
        return this;
    }

    public IWebDriverBuilder JavaScriptLoad(string script)
    {
        _driver.JavaScriptLoad(script);
        return this;
    }

    public IWebDriverBuilder JavaScriptLoad(string script, params object[] args)
    {
        _driver.JavaScriptLoad(script, args);
        return this;
    }
}
