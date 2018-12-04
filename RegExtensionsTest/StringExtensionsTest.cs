using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegExtensionsTest
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void IsMatch()
        {
            Assert.AreEqual(Regex.IsMatch("1234", @"\d{4}"), "1234".IsMatch(@"\d{4}"));

            Assert.AreEqual(
                Regex.IsMatch("hello\r\nworld", @"Hello$", RegexOptions.IgnoreCase | RegexOptions.Multiline),
                "hello\r\nworld".IsMatch(@"Hello$", RegexOptions.IgnoreCase | RegexOptions.Multiline));

            Assert.AreEqual(
                Regex.IsMatch("hello\r\nworld", @"Hello$",
                    RegexOptions.IgnoreCase | RegexOptions.Multiline, new TimeSpan(100)),
                "hello\r\nworld".IsMatch(@"Hello$",
                    RegexOptions.IgnoreCase | RegexOptions.Multiline, new TimeSpan(100)));
        }

        [TestMethod]
        public void Match()
        {
            Assert.AreEqual(Regex.Match("1234", @"\d{4}").Value, "1234".Match(@"\d{4}").Value);

            Assert.AreEqual(
                Regex.Match("hello\r\nworld", @"Hello$", RegexOptions.IgnoreCase | RegexOptions.Multiline).Value,
                "hello\r\nworld".Match(@"Hello$", RegexOptions.IgnoreCase | RegexOptions.Multiline).Value);

            Assert.AreEqual(
                Regex.Match("hello\r\nworld", @"Hello$",
                    RegexOptions.IgnoreCase | RegexOptions.Multiline, new TimeSpan(100)).Value,
                "hello\r\nworld".Match(@"Hello$",
                    RegexOptions.IgnoreCase | RegexOptions.Multiline, new TimeSpan(100)).Value);
        }

        [TestMethod]
        public void Matches()
        {
            Func<MatchCollection, string> toString = (m) => string.Join(", ", m.Cast<Match>());

            Assert.AreEqual(toString(Regex.Matches("1234", @"\d")), toString("1234".Matches(@"\d")));

            Assert.AreEqual(toString(Regex.Matches("ABcd", @"[a-z]", RegexOptions.IgnoreCase)),
                toString("ABcd".Matches(@"[a-z]", RegexOptions.IgnoreCase)));

            Assert.AreEqual(toString(Regex.Matches("ABcd", @"[a-z]", RegexOptions.IgnoreCase, new TimeSpan(100))),
                toString("ABcd".Matches(@"[a-z]", RegexOptions.IgnoreCase, new TimeSpan(100))));
        }

        [TestMethod]
        public void EnumerateMatches()
        {
            Func<IEnumerable<Match>, string> toString = (m) => string.Join(", ", m);

            Assert.AreEqual(toString(Regex.Matches("1234", @"\d").Cast<Match>()),
                toString("1234".EnumerateMatches(@"\d")));

            Assert.AreEqual(toString(Regex.Matches("ABcd", @"[a-z]", RegexOptions.IgnoreCase).Cast<Match>()),
                toString("ABcd".EnumerateMatches(@"[a-z]", RegexOptions.IgnoreCase)));

            Assert.AreEqual(
                toString(Regex.Matches("ABcd", @"[a-z]",
                    RegexOptions.IgnoreCase, new TimeSpan(100)).Cast<Match>()),
                toString("ABcd".EnumerateMatches(@"[a-z]",
                    RegexOptions.IgnoreCase, new TimeSpan(100))));
        }

        [TestMethod]
        public void RegexReplace()
        {
            Assert.AreEqual(Regex.Replace("abc123", @"\d", "_"), "abc123".RegexReplace(@"\d", "_"));

            Assert.AreEqual(Regex.Replace("abc123", @"[A-Z]", "_", RegexOptions.IgnoreCase),
                "abc123".RegexReplace(@"[A-Z]", "_", RegexOptions.IgnoreCase));

            Assert.AreEqual(Regex.Replace("abc123", @"[A-Z]", "_", RegexOptions.IgnoreCase, new TimeSpan(100)),
                "abc123".RegexReplace(@"[A-Z]", "_", RegexOptions.IgnoreCase, new TimeSpan(100)));

            Assert.AreEqual(Regex.Replace("abc123", @"\d", m => (int.Parse(m.Value) + 1).ToString()),
                "abc123".RegexReplace(@"\d", m => (int.Parse(m.Value) + 1).ToString()));

            Assert.AreEqual(
                Regex.Replace("ABcd", @"[a-z]", 
                    m => char.IsUpper(m.Value[0]) ? m.Value.ToLower() : m.Value.ToUpper(),
                    RegexOptions.IgnoreCase),
                "ABcd".RegexReplace(@"[a-z]",
                    m => char.IsUpper(m.Value[0]) ? m.Value.ToLower() : m.Value.ToUpper(),
                    RegexOptions.IgnoreCase));

            Assert.AreEqual(
                Regex.Replace("ABcd", @"[a-z]",
                    m => char.IsUpper(m.Value[0]) ? m.Value.ToLower() : m.Value.ToUpper(),
                    RegexOptions.IgnoreCase, new TimeSpan(100)),
                "ABcd".RegexReplace(@"[a-z]",
                    m => char.IsUpper(m.Value[0]) ? m.Value.ToLower() : m.Value.ToUpper(),
                    RegexOptions.IgnoreCase, new TimeSpan(100)));
        }

        [TestMethod]
        public void RegexSplit()
        {
            CollectionAssert.AreEqual(Regex.Split("1  2    3", @"\s+"), "1  2    3".RegexSplit(@"\s+"));

            CollectionAssert.AreEqual(Regex.Split("1a2A3", "a", RegexOptions.IgnoreCase),
                "1a2A3".RegexSplit("a", RegexOptions.IgnoreCase));

            CollectionAssert.AreEqual(Regex.Split("1a2A3", "a", RegexOptions.IgnoreCase, new TimeSpan(100)),
                "1a2A3".RegexSplit("a", RegexOptions.IgnoreCase, new TimeSpan(100)));
        }
    }
}
