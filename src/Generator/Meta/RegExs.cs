using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Generator.Meta
{
    internal static class RegExs
    {
        private static readonly Rx[] Pats;

        static RegExs()
        {
            var p = CreatePatterns(Instructs.Data);
            Pats = CompilePatterns(p).ToArray();
        }

        private record Rx(string Key, Regex Ex, Instruct[] List);

        internal record InstrMat(char Name, string Value, int Index, int Length);

        internal record InstrPat(string Text, string Pattern, Instruct Items, InstrMat[] Matches)
        {
            internal string? GetBitStr() => Items.Instruction;

            internal (int min, int max) MinMaxLen()
            {
                var len = Matches.Select(m => m.Length).ToArray();
                if (len.Length == 0) len = [0];
                return (len.Min(), len.Max());
            }
        }

        private static IEnumerable<InstrMat> ToMatch(Match match)
        {
            foreach (Group mg in match.Groups)
            {
                var let = mg.Name.Single();
                if (!char.IsLetter(let))
                    continue;
                yield return new InstrMat(let, mg.Value, mg.Index, mg.Length);
            }
        }

        private static IEnumerable<InstrPat> FindPattern(Rx[] p, string txt)
        {
            foreach (var (pattern, regex, list) in p)
            {
                var match = regex.Match(txt);
                if (!match.Success)
                    continue;
                var matches = ToMatch(match).ToArray();
                var array = list.ToArray().Single();
                yield return new InstrPat(txt, pattern, array, matches);
            }
        }

        private static IEnumerable<Rx> CompilePatterns(IDictionary<string, List<Instruct>> p)
        {
            foreach (var (key, val) in p)
            {
                var regex = new Regex(key);
                yield return new Rx(key, regex, val.ToArray());
            }
        }

        internal static IList<InstrPat> Match(string text)
        {
            var res = new List<InstrPat>(FindPattern(Pats, text));
            var maxLen = res.Max(r => r.MinMaxLen().max);
            while (res.Count >= 2)
            {
                if (res.FirstOrDefault(r => r.Items.Equals(Instructs._word)) is { } nonsense)
                    res.Remove(nonsense);
                else if (res.FirstOrDefault(r => r.MinMaxLen().max < maxLen) is { } less)
                    res.Remove(less);
                else
                    throw new InvalidOperationException(JsonTool.ToJson(res));
            }
            return res;
        }

        private static string? ToRegex(Instruct record)
        {
            var bitPat = record.Instruction;
            if (string.IsNullOrWhiteSpace(bitPat))
                return null;
            var bitLet = bitPat.GroupBy(x => x)
                .ToDictionary(k => k.Key, v => v.Count());
            var regex = $"^{bitPat}$";
            foreach (var (l, c) in bitLet)
            {
                if (!char.IsLetter(l))
                    continue;
                var term = string.Join("", Enumerable.Repeat(l, c));
                var repl = $"(?<{l}>[01]{{{c}}})";
                regex = regex.Replace(term, repl);
            }
            return regex;
        }

        private static IDictionary<string, List<Instruct>> CreatePatterns(IEnumerable<Instruct> records)
        {
            var patterns = new SortedDictionary<string, List<Instruct>>();
            foreach (var record in records)
            {
                if (ToRegex(record) is not { } regex)
                    continue;
                if (!patterns.TryGetValue(regex, out var list))
                    patterns[regex] = list = [];
                list.Add(record);
            }
            return patterns;
        }
    }
}