using CurrencyWords.Enums;
using CurrencyWords.Interfaces;

namespace CurrencyWords.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToCurrencyWords(this decimal amount, CurrencyCode currencyCode, ICurrencyWordConverter converter)
        {
            return converter.Convert(
                amount,
                currencyCode);
        }
        public static string ToCurrencyWords(this decimal amount, string currencyCode, ICurrencyWordConverter converter)
        {
            return converter.Convert(
                amount,
                currencyCode);
        }
    }
}
