# 💰 CurrencyWords

[![NuGet](https://img.shields.io/nuget/v/CurrencyWords)](https://www.nuget.org/packages/CurrencyWords)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com)

A lightweight and extensible .NET library for converting monetary amounts into words across multiple currencies and numbering systems.

---

## 🚀 Why CurrencyWords?

Many number-to-word libraries focus only on generic number conversion.

Financial systems often require:

* Currency-aware formatting
* Indian numbering system support (Lakh, Crore)
* International numbering system support (Million, Billion)
* Decimal currency handling
* Finance-friendly outputs

CurrencyWords was built specifically to address these requirements.

---

## ✨ Features

* Multi-currency support
* Indian Numbering System
* International Numbering System
* Decimal currency conversion
* Dependency Injection support
* Configuration-driven design
* CurrencyCode Enum support
* Extension Method support
* MIT Licensed
* .NET 8 Compatible

---

## 🌍 Supported Currencies

| Code | Currency          |
| ---- | ----------------- |
| INR  | Indian Rupee      |
| USD  | US Dollar         |
| EUR  | Euro              |
| GBP  | British Pound     |
| AED  | UAE Dirham        |
| SGD  | Singapore Dollar  |
| HKD  | Hong Kong Dollar  |
| CAD  | Canadian Dollar   |
| AUD  | Australian Dollar |
| JPY  | Japanese Yen      |

---

## 🏗 Architecture

CurrencyWords follows a strategy-based architecture.

```text
CurrencyWordConverter
        │
        ▼
 Currency Metadata
        │
 ┌──────┴──────┐
 │             │
 ▼             ▼

Indian      International
Formatter     Formatter
```

Benefits:

* Extensible
* Maintainable
* Testable
* SOLID compliant

---

## 📦 Clone Repository

```bash
git clone https://github.com/NIK9102002/CurrencyWords.git

cd CurrencyWords
```

---

## 🛠 Build Locally

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

---

## 🚀 Roadmap

### Version 1.1.0

* Additional Currency Support
* Validation APIs
* Enhanced Formatting

### Version 1.2.0

* Localization Support
* Custom Currency Registration
* Cheque Formatting

### Version 2.0.0

* Multi-language Support
* Banking Templates
* BigInteger Support

---

## 📝 Release Notes

### v1.0.2

#### Added

* CurrencyCode Enum support
* Enum-based converter overloads
* Extension Method support

Example:

```csharp
1000000m.ToCurrencyWords(
    CurrencyCode.INR,
    converter);
```

#### Improved

* Strongly typed currency handling
* Better developer experience
* Reduced risk of currency code typos

---

## 🤝 Contributing

Contributions are welcome.

Please:

1. Fork the repository
2. Create a feature branch
3. Commit changes
4. Open a Pull Request

---

## 📄 License

MIT License

---

## ⭐ Support

If you find this project useful, please consider giving it a star.
