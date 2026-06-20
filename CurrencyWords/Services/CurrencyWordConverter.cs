using CurrencyWords.Configurations;
using CurrencyWords.Enum;
using CurrencyWords.Formatters;
using CurrencyWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
