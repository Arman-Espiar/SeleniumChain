using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebDriverExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebDriverBuilderPatterns;
public interface IWebDriverBuilder 
{
	IWebDriverBuilder AsynchronousJavaScriptLoad(TimeSpan timeout);
    IWebDriverBuilder JavaScriptLoad(string script);
    IWebDriverBuilder JavaScriptLoad(string script, params object[] args);
}

public class WebDriverBuilder : SeleniumChainBase, IWebDriverBuilder
{
	
	public IWebDriverBuilder AsynchronousJavaScriptLoad(TimeSpan timeout)
    {
        Driver?.AsynchronousJavaScriptLoad(timeout);
        return this;
    }

    public IWebDriverBuilder JavaScriptLoad(string script)
    {
        Driver?.JavaScriptLoad(script);
        return this;
    }

    public IWebDriverBuilder JavaScriptLoad(string script, params object[] args)
    {
        Driver?.JavaScriptLoad(script, args);
        return this;
    }
}
