# \# 💰 CurrencyWords

# 

# > Convert monetary amounts into words across multiple currencies and numbering systems using .NET.

# 

# !\[.NET](https://img.shields.io/badge/.NET-8.0-blue)

# !\[License](https://img.shields.io/badge/License-MIT-green)

# !\[Status](https://img.shields.io/badge/Status-Active-success)

# !\[Open Source](https://img.shields.io/badge/Open%20Source-Yes-orange)

# 

# \---

# 

# \## 🚀 Why CurrencyWords?

# 

# Financial applications frequently need to display amounts in words for:

# 

# \* 🏦 Banking Systems

# \* 📄 Invoice Generation

# \* 🧾 ERP Applications

# \* 💵 Cheque Printing

# \* 📊 Financial Reporting

# \* 💳 Payment Processing Platforms

# 

# Examples:

# 

# ```text

# 1,000,000 INR

# → Ten Lakh Rupees Only

# 

# 1,000,000 USD

# → One Million Dollars Only

# 

# 1,234.56 USD

# → One Thousand Two Hundred Thirty Four Dollars And Fifty Six Cents Only

# ```

# 

# Most available libraries convert numbers to words but do not understand:

# 

# \* Currency-specific terminology

# \* Indian numbering formats (Lakh/Crore)

# \* Financial document formatting

# \* Extensible currency metadata

# 

# CurrencyWords solves these problems through a configurable and extensible architecture.

# 

# \---

# 

# \## ✨ Features

# 

# \### 🌎 Multi-Currency Support

# 

# | Currency          | Code |

# | ----------------- | ---- |

# | Indian Rupee      | INR  |

# | US Dollar         | USD  |

# | Euro              | EUR  |

# | British Pound     | GBP  |

# | UAE Dirham        | AED  |

# | Singapore Dollar  | SGD  |

# | Hong Kong Dollar  | HKD  |

# | Japanese Yen      | JPY  |

# | Canadian Dollar   | CAD  |

# | Australian Dollar | AUD  |

# 

# \---

# 

# \### 🔢 Multiple Numbering Systems

# 

# \#### Indian Numbering

# 

# ```text

# 10,00,000

# → Ten Lakh

# ```

# 

# ```text

# 1,00,00,000

# → One Crore

# ```

# 

# \#### International Numbering

# 

# ```text

# 1,000,000

# → One Million

# ```

# 

# ```text

# 1,000,000,000

# → One Billion

# ```

# 

# \---

# 

# \### 🛠 Additional Features

# 

# \* ✅ Decimal Amount Support

# \* ✅ Negative Amount Support

# \* ✅ Dependency Injection Ready

# \* ✅ JSON-Based Configuration

# \* ✅ Extension Methods

# \* ✅ Open Source

# \* ✅ MIT Licensed

# \* ✅ .NET 8 Compatible

# 

# \---

# 

# \# 🏗 Architecture

# 

# CurrencyWords follows a Strategy Pattern implementation.

# 

# ```text

# &#x20;               CurrencyWordConverter

# &#x20;                         │

# &#x20;                         ▼

# &#x20;               Currency Metadata

# &#x20;                         │

# &#x20;         ┌───────────────┴───────────────┐

# &#x20;         │                               │

# &#x20;         ▼                               ▼

# 

# &#x20;IndianNumberFormatter     InternationalNumberFormatter

# 

# &#x20;         │                               │

# &#x20;         └───────────────┬───────────────┘

# &#x20;                         ▼

# 

# &#x20;                Amount In Words

# ```

# 

# \---

# 

# \# 📂 Solution Structure

# 

# ```text

# CurrencyWords

# 

# ├── Configurations

# ├── Interfaces

# ├── Formatters

# ├── Services

# ├── Extensions

# ├── DependencyInjection

# └── Resources

# ```

# 

# \---

# 

# \# ⚡ Quick Start

# 

# \## Clone Repository

# 

# ```bash

# git clone https://github.com/yourusername/CurrencyWords.git

# 

# cd CurrencyWords

# ```

# 

# \## Build

# 

# ```bash

# dotnet restore

# 

# dotnet build

# ```

# 

# \---

# 

# \# 💡 Usage

# 

# ```csharp

# var result =

# &#x20;   converter.Convert(

# &#x20;       1000000m,

# &#x20;       "INR");

# ```

# 

# Output:

# 

# ```text

# Ten Lakh Rupees Only

# ```

# 

# \---

# 

# ```csharp

# var result =

# &#x20;   converter.Convert(

# &#x20;       1000000m,

# &#x20;       "USD");

# ```

# 

# Output:

# 

# ```text

# One Million Dollars Only

# ```

# 

# \---

# 

# ```csharp

# var result =

# &#x20;   converter.Convert(

# &#x20;       1234.56m,

# &#x20;       "USD");

# ```

# 

# Output:

# 

# ```text

# One Thousand Two Hundred Thirty Four Dollars And Fifty Six Cents Only

# ```

# 

# \---

# 

# \# 📸 Demo

# 

# Add a screenshot here after publishing.

# 

# ```text

# INR  -> Ten Lakh Rupees Only

# USD  -> One Million Dollars Only

# AED  -> One Million Dirhams Only

# ```

# 

# \---

# 

# \# 🎯 Engineering Highlights

# 

# This project demonstrates:

# 

# \* C#

# \* .NET 8

# \* Dependency Injection

# \* Strategy Pattern

# \* Configuration-Driven Development

# \* SOLID Principles

# \* NuGet Package Design

# \* Open Source Development

# 

# \---

# 

# \# 🧪 Testing

# 

# ```bash

# dotnet test

# ```

# 

# Unit tests cover:

# 

# \* Indian Numbering System

# \* International Numbering System

# \* Decimal Values

# \* Negative Values

# \* Currency Validation

# 

# \---

# 

# \# 🗺 Roadmap

# 

# \## Version 1.1

# 

# \* Additional ISO Currency Support

# \* Improved Formatting Rules

# \* Enhanced Validation

# 

# \## Version 1.2

# 

# \* Localization Support

# \* French

# \* German

# \* Spanish

# \* Arabic

# 

# \## Version 2.0

# 

# \* BigInteger Support

# \* Custom Numbering Systems

# \* Banking/Cheque Templates

# 

# \---

# 

# \# 🤝 Contributing

# 

# Contributions are welcome.

# 

# Feel free to:

# 

# \* Open Issues

# \* Submit Pull Requests

# \* Suggest Improvements

# 

# \---

# 

# \# ⭐ Support

# 

# If you find this project useful, please consider giving it a star.

# 

# It helps increase visibility and encourages further development.

# 

# \---

# 

# \# 📜 License

# 

# Distributed under the MIT License.

# 

# \---

# 

# \# 👨‍💻 Author

# 

# \### Nikhil Badhe

# 

# Software Engineer | .NET Developer | Open Source Contributor

# 

# Building practical solutions for finance, enterprise applications, and developer productivity.



