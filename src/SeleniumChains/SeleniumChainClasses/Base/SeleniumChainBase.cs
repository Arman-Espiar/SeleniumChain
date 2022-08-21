using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

namespace SeleniumChains.SeleniumChainClasses.Base;
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
