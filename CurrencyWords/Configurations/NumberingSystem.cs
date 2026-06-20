using System.Text.Json.Serialization;

namespace CurrencyWords.Configurations
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NumberingSystem
    {
        Indian,
        International
    }
}
