﻿using SeleniumChain.CustomExceptions;

namespace SeleniumChain.SeleniumChainClasses.Base;
public interface IChainBase
{
	void SetSeleniumChain(ChainSelenium chainSelenium);
	IClickOnElementBy ClickOnElementBy { get; }
	IFindElementsBy FindElementsBy { get; }
	IFindElementBy FindElementBy { get; }
}

public class ChainBase : IChainBase
{
	private  ChainSelenium? _seleniumChain;

	public void SetSeleniumChain(ChainSelenium chainSelenium)
	{
		_seleniumChain = chainSelenium;
	}

	private IClickOnElementBy? _clickOnElementBy;
	public IClickOnElementBy ClickOnElementBy => _clickOnElementBy ??= new ClickOnElementBy(_seleniumChain?? throw new SeleniumChainNotFoundException());

	private IFindElementsBy? _findElementsBy;
	public IFindElementsBy FindElementsBy =>_findElementsBy??= new FindElementsBy(_seleniumChain?? throw new SeleniumChainNotFoundException());
	
	private IFindElementBy? _findElementBy;
	public IFindElementBy FindElementBy =>_findElementBy??= new FindElementBy(_seleniumChain?? throw new SeleniumChainNotFoundException());

}