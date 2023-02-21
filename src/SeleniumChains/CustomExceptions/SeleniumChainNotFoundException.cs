namespace SeleniumChain.CustomExceptions
{
	public class SeleniumChainNotFoundException : Exception
	{
		public SeleniumChainNotFoundException()
		{
		}

		public SeleniumChainNotFoundException(string message = $"{nameof(ChainSelenium)} must be set from SetSeleniumChain")
			: base(message)
		{
		}

		public SeleniumChainNotFoundException(string? message, Exception? innerException) : base(message, innerException)
		{
		}
	}
}
