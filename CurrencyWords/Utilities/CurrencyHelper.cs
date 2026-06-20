namespace CurrencyWords.Utilities
{
    public static class CurrencyHelper
    {
        private static readonly HashSet<string> SupportedCurrencies =
        [
            "INR",
            "USD",
            "EUR",
            "GBP",
            "AED",
            "SGD",
            "HKD",
            "JPY",
            "CAD",
            "AUD"
        ];

        public static bool IsSupported(string currencyCode)
        {
            return SupportedCurrencies.Contains(
                currencyCode.ToUpperInvariant());
        }
        public static IReadOnlyCollection<string>GetSupportedCurrencies()
        {
            return SupportedCurrencies;
        }
    }
}
