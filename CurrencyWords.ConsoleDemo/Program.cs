using CurrencyWords.DependenyInjection;
using CurrencyWords.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddCurrencyWords();

var provider = services.BuildServiceProvider();

var converter =
    provider.GetRequiredService<ICurrencyWordConverter>();

Console.WriteLine(converter.Convert(1000000m, "INR"));

Console.WriteLine(converter.Convert(1000000m, "USD"));

Console.WriteLine(converter.Convert(12345678m, "INR"));

Console.WriteLine(converter.Convert(1234.56m, "USD"));

Console.WriteLine(converter.Convert(-500m, "USD"));