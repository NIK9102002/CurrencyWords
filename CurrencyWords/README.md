\# 📦 Installation



Install from NuGet:



```bash

dotnet add package CurrencyWords

```



Or via Package Manager:



```powershell

Install-Package CurrencyWords

```



\---



\# ⚙️ Dependency Injection Setup



Register CurrencyWords in your application:



```csharp

using CurrencyWords.DependencyInjection;



var services = new ServiceCollection();



services.AddCurrencyWords();

```



Resolve the converter:



```csharp

using CurrencyWords.Interfaces;



var provider = services.BuildServiceProvider();



var converter =

&#x20;   provider.GetRequiredService<ICurrencyWordConverter>();

```



\---



\# 🔥 Extension Method Usage



CurrencyWords provides extension methods for a cleaner developer experience.



```csharp

decimal amount = 1000000m;



string result =

&#x20;   amount.ToCurrencyWords("INR");

```



Output:



```text

Ten Lakh Rupees Only

```



\---



\# 📋 Examples



\## Indian Rupee (INR)



```csharp

converter.Convert(1000000m, "INR");

```



Output:



```text

Ten Lakh Rupees Only

```



\---



\## US Dollar (USD)



```csharp

converter.Convert(1000000m, "USD");

```



Output:



```text

One Million Dollars Only

```



\---



\## Decimal Amount



```csharp

converter.Convert(1234.56m, "USD");

```



Output:



```text

One Thousand Two Hundred Thirty Four Dollars And Fifty Six Cents Only

```



\---



\## Negative Amount



```csharp

converter.Convert(-500m, "USD");

```



Output:



```text

Minus Five Hundred Dollars Only

```



\---



\# 🌍 Supported Currencies



| Code | Currency          | Numbering System |

| ---- | ----------------- | ---------------- |

| INR  | Indian Rupee      | Indian           |

| USD  | US Dollar         | International    |

| EUR  | Euro              | International    |

| GBP  | British Pound     | International    |

| AED  | UAE Dirham        | International    |

| SGD  | Singapore Dollar  | International    |

| HKD  | Hong Kong Dollar  | International    |

| JPY  | Japanese Yen      | International    |

| CAD  | Canadian Dollar   | International    |

| AUD  | Australian Dollar | International    |



\---



\# 🏗 Architecture Overview



CurrencyWords follows a Strategy Pattern based architecture.



```text

CurrencyWordConverter

&#x20;       │

&#x20;       ▼

Currency Metadata

&#x20;       │

&#x20;┌──────┴──────┐

&#x20;│             │

&#x20;▼             ▼



Indian      International

Formatter     Formatter



&#x20;       │

&#x20;       ▼



&#x20;Amount In Words

```



Benefits:



\* Easy to add new numbering systems

\* Open for extension

\* Dependency Injection friendly

\* Configuration driven



\---



\# 🛠 Local Development



Clone the repository:



```bash

git clone https://github.com/<your-username>/CurrencyWords.git



cd CurrencyWords

```



Restore packages:



```bash

dotnet restore

```



Build:



```bash

dotnet build

```



Run tests:



```bash

dotnet test

```



Create package:



```bash

dotnet pack -c Release

```



Generated package:



```text

bin/Release/CurrencyWords.1.0.0.nupkg

```



\---



\# 🧪 Testing the Package Locally



Create a local NuGet feed:



```text

C:\\LocalNugetFeed

```



Copy:



```text

CurrencyWords.1.0.0.nupkg

```



into the folder.



Register source:



```bash

dotnet nuget add source C:\\LocalNugetFeed --name LocalCurrencyWords

```



Install:



```bash

dotnet add package CurrencyWords --source LocalCurrencyWords

```



\---



\# 🏆 Why Another Currency Library?



Most number-to-word libraries:



❌ Support only generic numbers



❌ Lack Indian numbering support



❌ Are not finance-oriented



❌ Do not support configurable currencies



CurrencyWords was designed specifically for:



✅ Banking Solutions



✅ ERP Systems



✅ Invoice Generation



✅ Financial Reporting



✅ Cheque Printing



✅ Enterprise Applications



\---



\# 🚀 Future Enhancements



\### Version 1.1



\* Additional ISO Currency Support

\* Enhanced Validation

\* Improved Formatting Rules



\### Version 1.2



\* Localization Support

\* French

\* German

\* Spanish

\* Arabic



\### Version 2.0



\* BigInteger Support

\* Custom Numbering Systems

\* Banking Templates

\* Cheque Formatting Templates



\---



\# ⭐ If You Like This Project



Please consider giving it a star on GitHub.



It helps increase visibility and supports future development.



```text

⭐ Star the Repository

🍴 Fork the Project

🐛 Report Issues

💡 Suggest Features

```



