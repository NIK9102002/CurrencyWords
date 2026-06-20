using CurrencyWords.Configurations;

namespace CurrencyWords.Utilities
{
    public static class CurrencyHelper
    {
        public static bool IsSupported(string currencyCode, CurrencyConfiguration configuration)
        {
            return configuration.Currencies.ContainsKey(
                currencyCode.ToUpperInvariant());
        }

        public static IReadOnlyCollection<string>GetSupportedCurrencies(CurrencyConfiguration configuration)
        {
            return configuration.Currencies.Keys.ToList();
        }
    }
}
