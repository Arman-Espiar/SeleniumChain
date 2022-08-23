using OpenQA.Selenium;
using SeleniumChain.SeleniumChainClasses.Base;
using SeleniumExtensionMethods.SeleniumExtensions.WebElementExtensions;

namespace SeleniumChain.ChainBuilderPatterns.WebElementBuilderPatterns.InteractingWithWebElementsBuilderPatterns;
public interface IWriteBuilder
{
	IWriteBuilder WriteInElementById(string id, string text);
	IWriteBuilder WriteAppendInElementById(string id, string text);
	IWriteBuilder WritePrependInElementById(string id, string text);
	IWriteBuilder ClearTextInputElementById(string id);
	IWriteBuilder WriteInElementById(string text);
	IWriteBuilder WriteAppendInElementById(string text);
	IWriteBuilder WritePrependInElementById(string text);
	IWriteBuilder ClearTextInputElementById();

}

public class WriteBuilder : SeleniumChainBase, IWriteBuilder
{


	private IWebElement? Element { get; set; }

	public IWriteBuilder WriteInElementById(string id, string text)
	{
		Element ??= Driver?.FindElementIfExistsById(id);

		Driver?.FindElementIfExistsById(id)?.WriteInElement(text);
		return this;
	}
	public IWriteBuilder WriteInElementById(string text)
	{
		Element?.WriteInElement(text);

		return this;
	}

	public IWriteBuilder WriteAppendInElementById(string id, string text)
	{
		Element ??= Driver?.FindElementIfExistsById(id);

		Driver?.FindElementIfExistsById(id)?.WriteAppendInElement(text);
		return this;
	}
	public IWriteBuilder WriteAppendInElementById(string text)
	{
		Element?.WriteAppendInElement(text);
		return this;
	}

	public IWriteBuilder WritePrependInElementById(string id, string text)
	{
		Element ??= Driver?.FindElementIfExistsById(id);
		Driver?.FindElementIfExistsById(id)?.WritePrependInElement(text);
		return this;
	}

	public IWriteBuilder WritePrependInElementById(string text)
	{
		Element?.WritePrependInElement(text);
		return this;
	}

	public IWriteBuilder ClearTextInputElementById(string id)
	{
		Element ??= Driver?.FindElementIfExistsById(id);
		Driver?.FindElementIfExistsById(id)?.ClearTextInputElement();
		return this;
	}
	public IWriteBuilder ClearTextInputElementById()
	{
		Element?.ClearTextInputElement();
		return this;
	}
}
