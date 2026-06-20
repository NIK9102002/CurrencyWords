using CurrencyWords.Configurations;
using CurrencyWords.Formatters;
using CurrencyWords.Interfaces;
using CurrencyWords.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CurrencyWords.DependenyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection
            AddCurrencyWords(this IServiceCollection services, IConfiguration configuration)
            {
                var currencyConfiguration = new CurrencyConfiguration();

                configuration.Bind(currencyConfiguration);

                services.AddSingleton(currencyConfiguration);

                services.AddSingleton<IndianNumberFormatter>();
                services.AddSingleton<InternationalNumberFormatter>();

                services.AddSingleton<ICurrencyWordConverter, CurrencyWordConverter>();

                return services;
        }
    }
}
