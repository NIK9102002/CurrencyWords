using CurrencyWords.Configurations;
using CurrencyWords.Enums;
using CurrencyWords.Formatters;
using CurrencyWords.Interfaces;

namespace CurrencyWords.Services
{
    public class CurrencyWordConverter : ICurrencyWordConverter
    {
        private readonly CurrencyConfiguration _config;
        private readonly IndianNumberFormatter _indianFormatter;
        private readonly InternationalNumberFormatter _internationalFormatter;

        public CurrencyWordConverter(CurrencyConfiguration config, IndianNumberFormatter indianFormatter, InternationalNumberFormatter internationalFormatter)
        {
            _config = config;
            _indianFormatter = indianFormatter;
            _internationalFormatter = internationalFormatter;
        }
        public string Convert(decimal amount, string currencyCode)
        {
            if (!Enum.TryParse<CurrencyCode>(currencyCode,true,out var parsedCurrency))
            {
                throw new NotSupportedException(
                    $"Currency '{currencyCode}' is not supported.");
            }

            return Convert(
                amount,
                parsedCurrency);
        }
        public string Convert(decimal amount, CurrencyCode currencyCode)
        {
            if (!_config.Currencies.TryGetValue(currencyCode.ToString(), out var currency))
                throw new NotSupportedException();

            bool negative = amount < 0;

            amount = Math.Abs(amount);

            long wholePart = (long)Math.Truncate(amount);

            int fraction =
                (int)((amount - wholePart) *
                (decimal)Math.Pow(10, currency.DecimalPlaces));

            INumberFormatter formatter =
                currency.NumberingSystem ==
                NumberingSystem.Indian
                    ? _indianFormatter
                    : _internationalFormatter;

            string major =
                formatter.Convert(wholePart);

            string result;

            if (fraction == 0)
            {
                result =
                    $"{major} {currency.MajorUnit} Only";
            }
            else
            {
                string minor =
                    formatter.Convert(fraction);

                result =
                    $"{major} {currency.MajorUnit} And {minor} {currency.MinorUnit} Only";
            }

            return negative
                ? $"Minus {result}"
                : result;
        }
    }
}
