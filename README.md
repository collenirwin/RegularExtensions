# RegularExtensions
C# extension methods for Regular Expressions

This small project aims to provide extension method versions of every `static` method in the [`System.Text.RegularExpressions.Regex`](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=netframework-4.7.1) class. Wrapped methods include `IsMatch`, `Match`, `Matches`, `Replace` (use `RegexReplace`), and `Split` (use `RegexSplit`) with all of their overloads.

`EnumerateMatches` is currently the only addition. It simply casts the result of `Matches` to `IEnumerable<Match>`.

# Installation

### [NuGet Package](https://www.nuget.org/packages/RegularExtensions)
`Install-Package RegularExtensions`

# Examples

### IsMatch
Wraps [`Regex.IsMatch`](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.ismatch?view=netframework-4.7.1)
```csharp
"1234".IsMatch(@"\d{4}"); // true
"Hello, world!".IsMatch("hello", RegexOptions.IgnoreCase); // true
```

### Match
Wraps [`Regex.Match`](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.match?view=netframework-4.7.1)
```csharp
"123abc".Match("[a-z]"); // "a"
```

### Matches
Wraps [`Regex.Matches`](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.matches?view=netframework-4.7.1)
```csharp
"123abc".Matches("[a-z]"); // "a", "b", "c"
```

### EnumerateMatches
Casts result of `Matches` to `IEnumerable<Match>`
```csharp
// LINQ ready
"123abc".EnumerateMatches(@"\d").Select(x => int.Parse(x.Value)); // 1, 2, 3
```

### RegexReplace
Wraps [`Regex.Replace`](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.replace?view=netframework-4.7.1)
```csharp
"123abc".RegexReplace("[a-z]+", "321"); // "123321"
"123abc".RegexReplace(@"\d", m => (int.Parse(m.Value) + 1).ToString()); // "234abc"
```

### RegexSplit
Wraps [`Regex.Split`](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.split?view=netframework-4.7.1)
```csharp
"Wow     here's  lots of\nspace".RegexSplit(@"\s+"); // "wow", "here's", "lots", "of", "space"
```
