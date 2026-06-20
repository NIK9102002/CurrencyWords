using System.Reflection;
using System.Text.Json;

namespace CurrencyWords.Configurations
{
    public static class CurrencyConfigurationLoader
    {
        public static CurrencyConfiguration Load()
        {
            var assembly = Assembly.GetExecutingAssembly();            

            using Stream? stream =
                assembly.GetManifestResourceStream(
                    "CurrencyWords.Resources.Currencies.json");

            if (stream is null)
            {
                throw new InvalidOperationException(
                    "Embedded resource 'Currencies.json' was not found.");
            }

            var configuration =
                JsonSerializer.Deserialize<CurrencyConfiguration>(stream);

            return configuration ??
                   throw new InvalidOperationException(
                       "Failed to load currency configuration.");
        }
    }
}
