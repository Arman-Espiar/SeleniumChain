using OpenQA.Selenium;

namespace SeleniumChains.SeleniumExtensions.WebElementExtensions;
public static class InputExtensions
{
    public static IWebElement ClearTextInputElement(this IWebElement webElement)
    {
        if (webElement.ClickOnElement() != null)
        {
            if (webElement.Text != null)
            {
                webElement.Clear();
            }
        }

        return webElement;
    }

    public static IWebElement WriteInElement(this IWebElement webElement, string str)
    {
        webElement.ClickOnElement()?.ClearTextInputElement().SendKeys(str);
        return webElement;
    }
    public static IWebElement WriteAppendInElement(this IWebElement webElement, string str)
    {
        webElement.ClickOnElement()?.SendKeys(Keys.End + str);
        return webElement;
    }
    public static IWebElement WritePrependInElement(this IWebElement webElement, string str)
    {
        webElement.ClickOnElement()?.SendKeys(Keys.Home + str);
        return webElement;
    }
}
