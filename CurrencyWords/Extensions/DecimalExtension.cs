using CurrencyWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyWords.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToCurrencyWords(this decimal amount, string currencyCode, ICurrencyWordConverter converter)
        {
            return converter.Convert(
                amount,
                currencyCode);
        }
    }
}
