namespace CurrencyWords.Interfaces
{
    public interface ICurrencyWordConverter
    {
        string Convert(decimal amount, string currencyCode);
    }
}
