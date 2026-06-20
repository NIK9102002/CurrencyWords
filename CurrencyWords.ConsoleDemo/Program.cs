using CurrencyWords.DependenyInjection;
using CurrencyWords.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("currencies.json")
    .Build();

var services = new ServiceCollection();

services.AddCurrencyWords(configuration);

var provider = services.BuildServiceProvider();

var converter =
    provider.GetRequiredService<ICurrencyWordConverter>();

Console.WriteLine(converter.Convert(1000000m, "INR"));

Console.WriteLine(converter.Convert(1000000m, "USD"));

Console.WriteLine(converter.Convert(12345678m, "INR"));

Console.WriteLine(converter.Convert(1234.56m, "USD"));

Console.WriteLine(converter.Convert(-500m, "USD"));