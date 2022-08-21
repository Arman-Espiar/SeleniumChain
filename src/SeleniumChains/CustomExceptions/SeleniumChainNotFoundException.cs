namespace SeleniumChains.CustomExceptions
{
	public class SeleniumChainNotFoundException:Exception
    {
		public SeleniumChainNotFoundException()
		{
		}

		public SeleniumChainNotFoundException(string message= $"{nameof(SeleniumChain)} must be set from SetSeleniumChain")
			: base(message)
		{
		}
	}
}
