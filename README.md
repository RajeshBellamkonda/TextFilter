# TextFilter

A .NET 10 console application that filters words from a text file based on configurable rules.

## Projects

| Project | Description |
|---------|-------------|
| **TextFilter.App** | Console application entry point |
| **TextFilter.Core** | Core library containing filter logic |
| **TextFilter.Core.Tests** | Unit tests for the core library |

## Filters

The application removes words that match any of the following built-in filters:

- **MiddleVowelFilter** – removes words whose middle letter is a vowel
- **ShortWordFilter** – removes words shorter than a specified length (default: 3)
- **ContainsLetterFilter** – removes words containing a specified letter (default: `t`)

Custom filters can be created by implementing the `IWordFilter` interface.

## Usage

```bash
dotnet run --project TextFilter.App -- <file-path>
```

If no file path is provided, the application reads from `input.txt` in the current directory.

## Building

```bash
dotnet build
```

## Testing

```bash
dotnet test
```
