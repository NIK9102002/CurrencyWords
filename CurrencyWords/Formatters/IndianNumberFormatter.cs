using CurrencyWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyWords.Formatters
{
    public sealed class IndianNumberFormatter
    : INumberFormatter
    {
        private readonly InternationalNumberFormatter
            _baseFormatter = new();

        public string Convert(long number)
        {
            if (number == 0)
                return "Zero";

            long crore = number / 10000000;

            long lakh =
                (number % 10000000) / 100000;

            long thousand =
                (number % 100000) / 1000;

            long remainder =
                number % 1000;

            var parts = new List<string>();

            if (crore > 0)
                parts.Add(
                    $"{_baseFormatter.Convert(crore)} Crore");

            if (lakh > 0)
                parts.Add(
                    $"{_baseFormatter.Convert(lakh)} Lakh");

            if (thousand > 0)
                parts.Add(
                    $"{_baseFormatter.Convert(thousand)} Thousand");

            if (remainder > 0)
                parts.Add(
                    _baseFormatter.Convert(remainder));

            return string.Join(" ", parts);
        }
    }
}
