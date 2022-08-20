using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

namespace SeleniumChains;
public abstract class SeleniumChainBase
{
	protected static IWebDriver? Driver { get; set; }

}
