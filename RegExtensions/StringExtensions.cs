using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegExtensions
{
    /// <summary>
    /// Extension versions of the static methods in the
    /// <see cref="System.Text.RegularExpressions.Regex"/> class
    /// </summary>
    public static class StringExtensions
    {
        #region IsMatch

        /// <summary>
        /// Indicates whether the regular expression specified in the Regex constructor finds a match in a specified input string.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <returns>true if the regular expression finds a match; otherwise, false.</returns>
        public static bool IsMatch(this string text, string regex)
        {
            return Regex.IsMatch(text, regex);
        }

        /// <summary>
        /// Indicates whether the specified regular expression finds a match in the specified input string,
        /// using the specified matching options.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>true if the regular expression finds a match; otherwise, false.</returns>
        public static bool IsMatch(this string text, string regex,
            RegexOptions options)
        {
            return Regex.IsMatch(text, regex, options);
        }

        /// <summary>
        /// Indicates whether the specified regular expression finds a match in the specified input string,
        /// using the specified matching options and time-out interval.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="timeout">
        /// A time-out interval, or <see cref="Regex.InfiniteMatchTimeout"/> to indicate that the method should not time out.
        /// </param>
        /// <returns>true if the regular expression finds a match; otherwise, false.</returns>
        public static bool IsMatch(this string text, string regex,
            RegexOptions options, TimeSpan timeout)
        {
            return Regex.IsMatch(text, regex, options, timeout);
        }

        #endregion

        #region Match

        /// <summary>
        /// Searches the specified input string for the first occurrence of the specified regular expression.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <returns>An object that contains information about the match.</returns>
        public static Match Match(this string text, string regex)
        {
            return Regex.Match(text, regex);
        }

        /// <summary>
        /// Searches the input string for the first occurrence of the specified regular expression,
        /// using the specified matching options.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>An object that contains information about the match.</returns>
        public static Match Match(this string text, string regex,
            RegexOptions options)
        {
            return Regex.Match(text, regex, options);
        }

        /// <summary>
        /// Searches the input string for the first occurrence of the specified regular expression,
        /// using the specified matching options and time-out interval.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="timeout">
        /// A time-out interval, or <see cref="Regex.InfiniteMatchTimeout"/> to indicate that the method should not time out.
        /// </param>
        /// <returns>An object that contains information about the match.</returns>
        public static Match Match(this string text, string regex,
            RegexOptions options, TimeSpan timeout)
        {
            return Regex.Match(text, regex, options, timeout);
        }

        #endregion

        #region Matches

        /// <summary>
        /// Searches the specified input string for all occurrences of a specified regular expression.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <returns>
        /// A collection of the Match objects found by the search.
        /// If no matches are found, the method returns an empty collection object.
        /// </returns>
        public static MatchCollection Matches(this string text, string regex)
        {
            return Regex.Matches(text, regex);
        }

        /// <summary>
        /// Searches the specified input string for all occurrences of a specified regular expression,
        /// using the specified matching options.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>
        /// A collection of the Match objects found by the search.
        /// If no matches are found, the method returns an empty collection object.
        /// </returns>
        public static MatchCollection Matches(this string text, string regex,
            RegexOptions options)
        {
            return Regex.Matches(text, regex, options);
        }

        /// <summary>
        /// Searches the input string for the first occurrence of the specified regular expression,
        /// using the specified matching options and time-out interval.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="timeout">
        /// A time-out interval, or <see cref="Regex.InfiniteMatchTimeout"/> to indicate that the method should not time out.
        /// </param>
        /// <returns>
        /// A collection of the Match objects found by the search.
        /// If no matches are found, the method returns an empty collection object.
        /// </returns>
        public static MatchCollection Matches(this string text, string regex,
            RegexOptions options, TimeSpan timeout)
        {
            return Regex.Matches(text, regex, options, timeout);
        }

        /// <summary>
        /// Searches the specified input string for all occurrences of a specified regular expression.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <returns>The result of text.Matches(...) cast as an IEnumerable of Match objects</returns>
        public static IEnumerable<Match> EnumerableMatches(this string text, string regex)
        {
            return text.Matches(regex).Cast<Match>();
        }

        /// <summary>
        /// Searches the specified input string for all occurrences of a specified regular expression,
        /// using the specified matching options.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>The result of text.Matches(...) cast as an IEnumerable of Match objects</returns>
        public static IEnumerable<Match> EnumerableMatches(this string text, string regex,
            RegexOptions options)
        {
            return text.Matches(regex, options).Cast<Match>();
        }

        /// <summary>
        /// Searches the input string for the first occurrence of the specified regular expression,
        /// using the specified matching options and time-out interval.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="timeout">
        /// A time-out interval, or <see cref="Regex.InfiniteMatchTimeout"/> to indicate that the method should not time out.
        /// </param>
        /// <returns>The result of text.Matches(...) cast as an IEnumerable of Match objects</returns>
        public static IEnumerable<Match> EnumerableMatches(this string text, string regex,
            RegexOptions options, TimeSpan timeout)
        {
            return text.Matches(regex, options, timeout).Cast<Match>();
        }

        #endregion

        #region RegexReplace

        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <returns>
        /// A new string that is identical to the input string, except that the replacement string takes the place of each matched string.
        /// If pattern is not matched in the current instance, the method returns the current instance unchanged.
        /// </returns>
        public static string RegexReplace(this string text, string regex, string replacement)
        {
            return Regex.Replace(text, regex, replacement);
        }

        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string.
        /// Specified options modify the matching operation.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>
        /// A new string that is identical to the input string, except that the replacement string takes the place of each matched string.
        /// If pattern is not matched in the current instance, the method returns the current instance unchanged.
        /// </returns>
        public static string RegexReplace(this string text, string regex, string replacement,
            RegexOptions options)
        {
            return Regex.Replace(text, regex, replacement, options);
        }

        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a specified replacement string.
        /// Additional parameters specify options that modify the matching operation and a time-out interval if no match is found.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="replacement">The replacement string.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="timeout">
        /// A time-out interval, or <see cref="Regex.InfiniteMatchTimeout"/> to indicate that the method should not time out.
        /// </param>
        /// <returns>
        /// A new string that is identical to the input string, except that the replacement string takes the place of each matched string.
        /// If pattern is not matched in the current instance, the method returns the current instance unchanged.
        /// </returns>
        public static string RegexReplace(this string text, string regex, string replacement,
            RegexOptions options, TimeSpan timeout)
        {
            return Regex.Replace(text, regex, replacement, options, timeout);
        }

        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a string returned by a MatchEvaluator delegate.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="evaluator">A custom method that examines each match and returns either the original matched string or a replacement string.</param>
        /// <returns>
        /// A new string that is identical to the input string, except that the replacement string takes the place of each matched string.
        /// If pattern is not matched in the current instance, the method returns the current instance unchanged.
        /// </returns>
        public static string RegexReplace(this string text, string regex, MatchEvaluator evaluator)
        {
            return Regex.Replace(text, regex, evaluator);
        }

        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a string returned by a MatchEvaluator delegate.
        /// Specified options modify the matching operation.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="evaluator">A custom method that examines each match and returns either the original matched string or a replacement string.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>
        /// A new string that is identical to the input string, except that the replacement string takes the place of each matched string.
        /// If pattern is not matched in the current instance, the method returns the current instance unchanged.
        /// </returns>
        public static string RegexReplace(this string text, string regex,
            MatchEvaluator evaluator, RegexOptions options)
        {
            return Regex.Replace(text, regex, evaluator, options);
        }

        /// <summary>
        /// In a specified input string, replaces all substrings that match a specified regular expression with a string returned by a MatchEvaluator delegate.
        /// Additional parameters specify options that modify the matching operation and a time-out interval if no match is found.
        /// </summary>
        /// <param name="text">The string to search for a match.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="evaluator">A custom method that examines each match and returns either the original matched string or a replacement string.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="timeout">
        /// A time-out interval, or <see cref="Regex.InfiniteMatchTimeout"/> to indicate that the method should not time out.
        /// </param>
        /// <returns>
        /// A new string that is identical to the input string, except that the replacement string takes the place of each matched string.
        /// If pattern is not matched in the current instance, the method returns the current instance unchanged.
        /// </returns>
        public static string RegexReplace(this string text, string regex,
            MatchEvaluator evaluator, RegexOptions options, TimeSpan timeout)
        {
            return Regex.Replace(text, regex, evaluator, options);
        }

        #endregion

        #region RegexSplit

        /// <summary>
        /// Splits an input string into an array of substrings at the positions defined by a regular expression pattern.
        /// </summary>
        /// <param name="text">The string to split.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <returns>An array of strings.</returns>
        public static string[] RegexSplit(this string text, string regex)
        {
            return Regex.Split(text, regex);
        }

        /// <summary>
        /// Splits an input string into an array of substrings at the positions defined by a specified regular expression pattern.
        /// Specified options modify the matching operation.
        /// </summary>
        /// <param name="text">The string to split.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>An array of strings.</returns>
        public static string[] RegexSplit(this string text, string regex,
            RegexOptions options)
        {
            return Regex.Split(text, regex, options);
        }

        /// <summary>
        /// Splits an input string into an array of substrings at the positions defined by a specified regular expression pattern.
        /// Additional parameters specify options that modify the matching operation and a time-out interval if no match is found.
        /// </summary>
        /// <param name="text">The string to split.</param>
        /// <param name="regex">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <param name="timeout">
        /// A time-out interval, or <see cref="Regex.InfiniteMatchTimeout"/> to indicate that the method should not time out.
        /// </param>
        /// <returns>An array of strings.</returns>
        public static string[] RegexSplit(this string text, string regex,
            RegexOptions options, TimeSpan timeout)
        {
            return Regex.Split(text, regex, options, timeout);
        }

        #endregion
    }
}
