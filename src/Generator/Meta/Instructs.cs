using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Generator.Meta
{
    internal static class Instructs
    {
        private static readonly Instruct[] Data;
        private static readonly Rx[] Pats;

        static Instructs()
        {
            Data = Load();
            Pats = CompilePatterns(CreatePatterns(Data)).ToArray();
        }

        private static Instruct? _word;

        private static Instruct[] Load()
        {
            var type = typeof(Instructs);
            var dll = Path.GetFullPath(type.Assembly.Location);
            var dir = Path.GetDirectoryName(dll)!;
            var file = Path.Combine(dir, "Meta", "instructs.csv");
            var list = new List<Instruct>(CsvTool.ReadCsv<Instruct>(file));
            list.Add(_word = new Instruct
            {
                TBit = "_", Summary = "Some random data", Format = ".WORD d",
                Instruction = "dddddddddddddddd", States = "0"
            });
            return list.ToArray();
        }

        private static string? Lbl(Instruct instruct)
            => instruct.Format?.Split(' ').FirstOrDefault();

        private const StringComparison Cmp = StringComparison.InvariantCultureIgnoreCase;

        public static Instruct? Find(string txt)
            => Data.FirstOrDefault(d =>
            {
                var dd = Lbl(d) ?? string.Empty;
                return txt.Equals(dd, Cmp) ||
                       txt.Replace('.', '/').Equals(dd, Cmp);
            });

        private static IEnumerable<Rx> CompilePatterns(IDictionary<string, List<Instruct>> p)
        {
            foreach (var (key, val) in p)
            {
                var regex = new Regex(key);
                yield return new Rx(key, regex, val.ToArray());
            }
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

        internal static string? ToRegex(Instruct record)
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

        public static IList<InstrPat> Match(string text)
        {
            var res = new List<InstrPat>(FindPattern(Pats, text));
            var maxLen = res.Max(r => r.MinMaxLen().max);
            while (res.Count >= 2)
            {
                if (res.FirstOrDefault(r => r.Items.Equals(_word)) is { } nonsense)
                    res.Remove(nonsense);
                else if (res.FirstOrDefault(r => r.MinMaxLen().max < maxLen) is { } less)
                    res.Remove(less);
                else
                    throw new InvalidOperationException(JsonTool.ToJson(res));
            }
            return res;
        }
    }
}