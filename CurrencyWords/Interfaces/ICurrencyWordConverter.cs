using CurrencyWords.Enum;

namespace CurrencyWords.Interfaces
{
    public interface ICurrencyWordConverter
    {
        string Convert(decimal amount, CurrencyCode currencyCode);
    }
}
