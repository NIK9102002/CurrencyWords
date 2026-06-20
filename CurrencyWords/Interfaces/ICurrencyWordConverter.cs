using CurrencyWords.Enums;

namespace CurrencyWords.Interfaces
{
    public interface ICurrencyWordConverter
    {
        string Convert(decimal amount, CurrencyCode currencyCode);
        string Convert(decimal amount, string currencyCode);
    }
}
