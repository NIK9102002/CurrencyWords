namespace CurrencyWords.Configurations
{
    public sealed class CurrencyConfiguration
    {
        public Dictionary<string, CurrencyMetadata> Currencies { get; init; } = new (StringComparer.OrdinalIgnoreCase);
    }
}
