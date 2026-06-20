# 💰 CurrencyWords

Convert monetary amounts into words across multiple currencies and numbering systems.

Supports:

* Indian Numbering System (Lakh, Crore)
* International Numbering System (Million, Billion)
* Decimal Currency Conversion
* CurrencyCode Enum Support
* Dependency Injection Integration

---

## 📦 Installation

```bash
dotnet add package CurrencyWords
```

---

## ⚙️ Registration

```csharp
using CurrencyWords.DependencyInjection;

var services = new ServiceCollection();

services.AddCurrencyWords();
```

---

## 🚀 Usage

Resolve converter:

```csharp
var provider =
    services.BuildServiceProvider();

var converter =
    provider.GetRequiredService<ICurrencyWordConverter>();
```

---

## Convert Currency

```csharp
var result =
    converter.Convert(
        1000000m,
        CurrencyCode.INR);
```

Output:

```text
Ten Lakh Rupees Only
```

---

## Convert USD

```csharp
var result =
    converter.Convert(
        1000000m,
        CurrencyCode.USD);
```

Output:

```text
One Million Dollars Only
```

---

## Extension Method

```csharp
var result =
    1000000m.ToCurrencyWords(
        CurrencyCode.INR,
        converter);
```

Output:

```text
Ten Lakh Rupees Only
```

---

## Supported Currencies

* INR
* USD
* EUR
* GBP
* AED
* SGD
* HKD
* CAD
* AUD
* JPY

---

## 🆕 What's New in v1.0.2

* CurrencyCode Enum Support
* Strongly Typed Currency Conversion
* Extension Method Support
* Improved Developer Experience

---

## 📄 License

MIT License
