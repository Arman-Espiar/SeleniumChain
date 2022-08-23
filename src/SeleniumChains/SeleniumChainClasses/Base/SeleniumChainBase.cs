using OpenQA.Selenium;

namespace SeleniumChain.SeleniumChainClasses.Base;
public abstract class SeleniumChainBase
{
    protected SeleniumChainBase()
    {
        ChainBase = new ChainBase();
    }

    [field: ThreadStatic]
    protected static IWebDriver? Driver { get; set; }

    protected IChainBase ChainBase { get; }

}
