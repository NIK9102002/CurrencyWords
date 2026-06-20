using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyWords.Configurations
{
    public sealed class CurrencyMetadata
    {
        public string MajorUnit { get; init; } = string.Empty;

        public string MinorUnit { get; init; } = string.Empty;

        public int DecimalPlaces { get; init; }

        public NumberingSystem NumberingSystem { get; init; }
    }
}
