using CurrencyWords.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyWords.Formatters
{
    public sealed class InternationalNumberFormatter
    : INumberFormatter
    {
        private static readonly string[] Ones =
        {
        "",
        "One",
        "Two",
        "Three",
        "Four",
        "Five",
        "Six",
        "Seven",
        "Eight",
        "Nine",
        "Ten",
        "Eleven",
        "Twelve",
        "Thirteen",
        "Fourteen",
        "Fifteen",
        "Sixteen",
        "Seventeen",
        "Eighteen",
        "Nineteen"
    };

        private static readonly string[] Tens =
        {
        "",
        "",
        "Twenty",
        "Thirty",
        "Forty",
        "Fifty",
        "Sixty",
        "Seventy",
        "Eighty",
        "Ninety"
    };

        private static readonly string[] Scales =
        {
        "",
        "Thousand",
        "Million",
        "Billion",
        "Trillion",
        "Quadrillion"
    };

        public string Convert(long number)
        {
            if (number == 0)
                return "Zero";

            var parts = new List<string>();

            int scale = 0;

            while (number > 0)
            {
                int chunk = (int)(number % 1000);

                if (chunk > 0)
                {
                    string words =
                        ConvertBelowThousand(chunk);

                    if (!string.IsNullOrWhiteSpace(
                        Scales[scale]))
                    {
                        words +=
                            $" {Scales[scale]}";
                    }

                    parts.Insert(0, words);
                }

                number /= 1000;
                scale++;
            }

            return string.Join(" ", parts);
        }

        private static string ConvertBelowThousand(
            int number)
        {
            var result = "";

            if (number >= 100)
            {
                result += Ones[number / 100] +
                          " Hundred ";

                number %= 100;
            }

            if (number >= 20)
            {
                result += Tens[number / 10] +
                          " ";

                number %= 10;
            }

            if (number > 0)
            {
                result += Ones[number];
            }

            return result.Trim();
        }
    }
}
