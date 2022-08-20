﻿using OpenQA.Selenium;
using SeleniumChains.SeleniumExtensions.WebDriverExtensions;

namespace SeleniumChains.ChainBuilderPatterns.WebDriverBuilderPatterns.BrowserBuilderPatterns;
public interface IBrowserNavigationBuilder
{
	IBrowserNavigationBuilder Goto(string url);
	IBrowserNavigationBuilder Goto(Uri url);

	IBrowserNavigationBuilder RefreshUrl();
	IBrowserNavigationBuilder BrowserHistoryForward();
	IBrowserNavigationBuilder BrowserHistoryBackward();

}

public class BrowserNavigationBuilder :SeleniumChainBase, IBrowserNavigationBuilder
{
	

	public IBrowserNavigationBuilder Goto(string url)
	{
		Driver?.GotoUrl(url);
		return this;
	}

	public IBrowserNavigationBuilder Goto(Uri url)
	{
		Driver?.GotoUrl(url);
		return this;
	}

	public IBrowserNavigationBuilder RefreshUrl()
	{
		Driver?.RefreshUrl();
		return this;
	}

	public IBrowserNavigationBuilder BrowserHistoryForward()
	{
		Driver?.BrowserHistoryForward();
		return this;
	}

	public IBrowserNavigationBuilder BrowserHistoryBackward()
	{
		Driver?.BrowserHistoryBackward();
		return this;
	}


}