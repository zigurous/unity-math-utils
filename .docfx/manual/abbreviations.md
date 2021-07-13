# Number Abbreviations

The Math Utils package comes with methods to convert numbers to abbreviated strings. This is very useful in games that display floating combat text, for example. By default, numbers are abbreviated to the thousands ("K"), millions ("M"), billions ("B"), and trillions ("T").

```csharp
1_000.ToAbbreviatedString(); // "1K"
1_000_000.ToAbbreviatedString(); // "1M"
1_000_000_000.ToAbbreviatedString(); // "1B"
1_000_000_000_000.ToAbbreviatedString(); // "1T"
```

### Custom Abbreviations

You can also provide your own custom abbreviations by creating a new [NumberAbbreviation](xref:Zigurous.Math.NumberAbbreviation).

```csharp
NumberAbbreviation abbreviation = new NumberAbbreviation(factor, format);
string display = abbreviation.Format(number);
```

You can provide an array of number abbreviations to the `ToAbbreviatedString` function and it will select the first abbreviation possible. With this in mind, you usually want to order the abbreviations from largest to smallest.

```csharp
NumberAbbreviation[] abbreviations;
number.ToAbbreviatedString(abbreviations);
```
