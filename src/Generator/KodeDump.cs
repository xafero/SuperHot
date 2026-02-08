using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Generator.Meta;
using static Generator.FileTool;
using static Generator.JsonTool;
using N = System.Globalization.NumberStyles;
using InstrPat = Generator.Meta.RegExs.InstrPat;
using InstrMat = Generator.Meta.RegExs.InstrMat;
using InDi = System.Collections.Generic.IDictionary<string, 
    System.Collections.Generic.IDictionary<string, 
        System.Collections.Generic.IDictionary<string, 
            System.Collections.Generic.IDictionary<string, 
                System.Collections.Generic.List<Generator.KodeDump.BinLine>>>>>;

// ReSharper disable ConvertIfStatementToReturnStatement

namespace Generator
{
    internal static class KodeDump
    {
        public static async Task Run(Options o)
        {
            if (CreateOrGetDir(o.OutputDir) is not { } outDir)
            {
                await Console.Error.WriteLineAsync("No output dir given!");
                return;
            }
            if (CreateOrGetDir(o.InputDir) is not { } inpDir)
            {
                await Console.Error.WriteLineAsync("No input dir given!");
                return;
            }

            const SearchOption so = SearchOption.TopDirectoryOnly;
            var files = Directory.EnumerateFiles(inpDir, "*.json", so);
            var cpus = await ReadCpus(files);

            var grouped = Collect(cpus);
            var maxKey = grouped.Max(g => FixName(g.Key).Length);
            var comDir = CreateOrGetDir(Path.Combine(outDir, "Common"))!;

            foreach (var (grp, lines) in grouped.ToArray())
            {
                var fn = FixName(grp, maxKey);
                var jdf = Path.Combine(comDir, $"d{fn}.cs");

                var text = await GenerateCode(fn, lines, grp);
                if (text == null)
                {
                    grouped.Remove(grp);
                    continue;
                }

                Console.WriteLine($"Writing '{jdf}' with {lines.Count} values...");
                await WriteFile(jdf, text.ToString());
            }

            foreach (var (cpu, _) in cpus)
            {
                var jdf = Path.Combine(outDir, $"{cpu}Decoder.cs");
                var group = GetSorted(grouped, cpu);

                var text = await GenerateCode(cpu, group, maxKey);

                Console.WriteLine($"Writing '{jdf}' with {group.Length} calls...");
                await WriteFile(jdf, text.ToString());
            }

            Console.WriteLine("Done.");
        }

        private static IDictionary<string, ISet<ParsedLine>> Collect(IDictionary<string, ParsedLine[]> dict)
        {
            var res = new Dictionary<ParsedLine, ISet<string>>();
            foreach (var (cpu, lines) in dict)
            foreach (var line in lines)
            {
                if (!res.TryGetValue(line, out var set))
                    res[line] = set = new SortedSet<string>();
                set.Add(cpu);
            }
            var rep = new SortedDictionary<string, ISet<ParsedLine>>();
            foreach (var (line, cpus) in res)
            {
                var key = $";{string.Join(";", cpus)};";
                if (!rep.TryGetValue(key, out var list))
                    rep[key] = list = new HashSet<ParsedLine>();
                list.Add(line);
            }
            return rep;
        }

        private static async Task<IDictionary<string, ParsedLine[]>> ReadCpus(IEnumerable<string> files)
        {
            var dict = new SortedDictionary<string, ParsedLine[]>();
            foreach (var file in files)
            {
                var cpu = ToTitle(Path.GetFileNameWithoutExtension(file));
                var lines = FromJson<ParsedLine>(await ReadFile(file));
                dict.Add(cpu, lines);
            }
            return dict;
        }

        private static async Task<StringWriter?> GenerateCode(string lbl, ISet<ParsedLine> lines, string cpusR)
        {
            var t = new StringWriter();
            const string nsp = "SuperHot2.Auto.Common";
            var cln = $"d{lbl}";
            await t.WriteLineAsync("using System;");
            await t.WriteLineAsync("using SuperHot;");
            await t.WriteLineAsync("using static SuperHot.InstructV;");
            await t.WriteLineAsync("using static SuperHot.Auto.Instruct;");
            await t.WriteLineAsync("using static SuperHot.Register;");
            await t.WriteLineAsync("using I = SuperHot2.InstructH;");
            await t.WriteLineAsync();
            await t.WriteLineAsync("#pragma warning disable CS0164");
            await t.WriteLineAsync("#pragma warning disable CS0162");
            await t.WriteLineAsync("// ReSharper disable RedundantAssignment");
            await t.WriteLineAsync("// ReSharper disable InconsistentNaming");
            await t.WriteLineAsync();
            await t.WriteLineAsync($"namespace {nsp}");
            await t.WriteLineAsync("{");
            await t.WriteLineAsync($"\tinternal static class {cln}");
            await t.WriteLineAsync("\t{");
            await t.WriteLineAsync("\t\tinternal static Instruction? Decode(byte n0, byte n1, byte n2, byte n3)");
            await t.WriteLineAsync("\t\t{");

            int[] dcn = [0];
            var tmp = new StringWriter(); 
            var cpus = cpusR.ToLower().Split(";", StringSplitOptions.RemoveEmptyEntries);
            var binLines = GetBinaryLines(lines, cpus)
                .GroupBy(x => x.BitStrS()).ToArray();
            var binTree = BuildTree(binLines);
            await GenerateCodeLvl0(dcn, tmp, "\t\t\t", binTree);

            if (IsEmpty(tmp))
                return null;
            await t.WriteAsync(tmp.GetStringBuilder());

            await t.WriteLineAsync("\t\t\treturn null;");
            await t.WriteLineAsync("\t\t}");
            await t.WriteLineAsync("\t}");
            await t.WriteLineAsync("}");
            return t;
        }

        private static bool IsEmpty(StringWriter tmp)
        {
            var text = tmp.ToString().Trim();
            if (text.Length < 1)
                return true;
            var txt = text.Replace('\n', ' ');
            txt = Regex.Replace(txt, @"\s+", " ");
            if (txt.Length == 15)
                return true;
            return false;
        }

        private static async Task GenerateCodeLvl0(int[] dcn, StringWriter t, string sp, InDi v0)
        {
            await t.WriteLineAsync($"{sp}switch (n0)");
            await t.WriteLineAsync($"{sp}{{");
            var td = new Dictionary<string, StringWriter>();
            foreach (var (k1, v1) in v0)
            {
                var k1K = GetCase(k1, dcn);
                var tt = td[k1K] = new StringWriter();
                await tt.WriteLineAsync($"{sp}\t{k1K}");
                await GenerateCodeLvl1(dcn, tt, $"{sp}\t\t", v1);
                await tt.WriteLineAsync($"{sp}\t\tbreak0;");
            }
            await FixBreakPoints(td, t, 0);
            await t.WriteLineAsync($"{sp}}}");
        }

        private static async Task GenerateCodeLvl1(int[] dcn, StringWriter t, string sp,
            IDictionary<string, IDictionary<string, IDictionary<string, List<BinLine>>>> v1)
        {
            await t.WriteLineAsync($"{sp}switch (n1)");
            await t.WriteLineAsync($"{sp}{{");
            var td = new Dictionary<string, StringWriter>();
            foreach (var (k2, v2) in v1)
            {
                var k2K = GetCase(k2, dcn);
                var tt = td[k2K] = new StringWriter();
                await tt.WriteLineAsync($"{sp}\t{k2K}");
                await GenerateCodeLvl2(dcn, tt, $"{sp}\t\t", v2);
                await tt.WriteLineAsync($"{sp}\t\tbreak1;");
            }
            await FixBreakPoints(td, t, 1);
            await t.WriteLineAsync($"{sp}}}");
        }

        private static async Task GenerateCodeLvl2(int[] dcn, StringWriter t, string sp,
            IDictionary<string, IDictionary<string, List<BinLine>>> v2)
        {
            await t.WriteLineAsync($"{sp}switch (n2)");
            await t.WriteLineAsync($"{sp}{{");
            var td = new Dictionary<string, StringWriter>();
            foreach (var (k3, v3) in v2)
            {
                var k3K = GetCase(k3, dcn);
                var tt = td[k3K] = new StringWriter();
                await tt.WriteLineAsync($"{sp}\t{k3K}");
                await GenerateCodeLvl3(dcn, tt, $"{sp}\t\t", v3);
                await tt.WriteLineAsync($"{sp}\t\tbreak2;");
            }
            await FixBreakPoints(td, t, 2);
            await t.WriteLineAsync($"{sp}}}");
        }
        
        private static async Task GenerateCodeLvl3(int[] dcn, StringWriter t, string sp,
            IDictionary<string, List<BinLine>> v3)
        {
            await t.WriteLineAsync($"{sp}switch (n3)");
            await t.WriteLineAsync($"{sp}{{");
            foreach (var (k4, v4) in v3)
            {
                var k4K = GetCase(k4, dcn);
                await t.WriteLineAsync($"{sp}\t{k4K}");
                var tmp = new SortedSet<(string g, string f)>();
                foreach (var single1 in v4)
                {
                    var single2 = single1.M.SingleOrDefault();
                    var meth = ToTitle(single2?.Item.Label?.ToLower().Trim('.'));
                    var args = GetArgs(single1);
                    var pre = GetPrefix(single1);
                    var gen = $"{sp}\t\treturn I.{meth}{pre}({args});";
                    tmp.Add((g: gen, f: single2?.Item.Instruction ?? ""));
                }
                if (tmp.Count == 1)
                    PatchLines(tmp);
                if (tmp.Count >= 2)
                    MergeLines(tmp);
                foreach (var one in tmp)
                    await t.WriteLineAsync(one.g);
            }
            await t.WriteLineAsync($"{sp}}}");
        }

        private static async Task FixBreakPoints(IDictionary<string, StringWriter> d, StringWriter t, int l)
        {
            const string tmp = "default: ";
            var anchor = default(string?);
            if (d.FirstOrDefault(x => x.Key.StartsWith(tmp)) is var dk
                && !string.IsNullOrWhiteSpace(dk.Key) && dk.Key.Replace(tmp, "").TrimEnd(':') is { } dv)
            {
                anchor = dv;
            }
            foreach (var (key, val) in d)
            {
                var txt = val.ToString();
                if (!string.IsNullOrWhiteSpace(anchor) && !key.StartsWith(tmp))
                    txt = txt.Replace($"break{l};", $"goto {anchor};");
                else
                    txt = txt.Replace($"break{l};", "break;");
                await t.WriteAsync(txt);
            }
        }

        private static string GetArgs(BinLine line)
        {
            var mat = line.M;
            if (mat.Length == 1)
            {
                var mas = mat[0];
                var md = mas.Matches.ToDictionary(k => k.Name, v => v);
                var args = new List<string>();
                foreach (var once in ParseFormat(mas))
                {
                    var one = once.Trim();
                    switch (one)
                    {
                        case "#imm": case "#imm3":
                            if (GetNibble(md, 'i') is { } rI) { args.Add($"i: {rI}"); continue; }
                            break;
                        case "label": case "disp": case "@disp8":
                            if (GetNibble(md, 'd') is { } rD) { args.Add($"d: {rD}"); continue; }
                            break;
                        case "FRn":
                            if (GetNibble(md, 'n') is { } rNf) { args.Add($"n: fR({rNf})"); continue; }
                            break;
                        case "FRm":
                            if (GetNibble(md, 'm') is { } rMf) { args.Add($"m: fR({rMf})"); continue; }
                            break;
                        case "FVm":
                            if (GetNibble(md, 'm') is { } rMv) { args.Add($"m: fV({rMv})"); continue; }
                            break;
                        case "FVn":
                            if (GetNibble(md, 'n') is { } rNv) { args.Add($"n: fV({rNv})"); continue; }
                            break;
                        case "DRn":
                            if (GetNibble(md, 'n') is { } rNd) { args.Add($"n: dR({rNd})"); continue; }
                            break;
                        case "DRm":
                            if (GetNibble(md, 'm') is { } rMd) { args.Add($"m: dR({rMd})"); continue; }
                            break;
                        case "XDn":
                            if (GetNibble(md, 'n') is { } rXnd) { args.Add($"n: xR({rXnd})"); continue; }
                            break;
                        case "XDm":
                            if (GetNibble(md, 'm') is { } rXmd) { args.Add($"m: xR({rXmd})"); continue; }
                            break;
                        case "Rm":
                            if (GetNibble(md, 'm') is { } rM) { args.Add($"m: R({rM})"); continue; }
                            break;
                        case "@Rm":
                            if (GetNibble(md, 'm') is { } rMa) { args.Add($"m: at(R({rMa}))"); continue; }
                            break;
                        case "@Rm+":
                            if (GetNibble(md, 'm') is { } rMap) { args.Add($"m: at(p(R({rMap})))"); continue; }
                            break;
                        case "@-Rm":
                            if (GetNibble(md, 'm') is { } rMam) { args.Add($"n: at(m(R({rMam})))"); continue; }
                            break;
                        case "Rn":
                            if (GetNibble(md, 'n') is { } rN) { args.Add($"n: R({rN})"); continue; }
                            break;
                        case "@Rn":
                            if (GetNibble(md, 'n') is { } rNa) { args.Add($"n: at(R({rNa}))"); continue; }
                            break;
                        case "@Rn+":
                            if (GetNibble(md, 'n') is { } rNap) { args.Add($"n: at(p(R({rNap})))"); continue; }
                            break;
                        case "@-Rn":
                            if (GetNibble(md, 'n') is { } rNam) { args.Add($"n: at(m(R({rNam})))"); continue; }
                            break;
                        default:
                            if (Regex.IsMatch(one, @"^@R\d{1,2}\+$")) { one = $"at(p(R({one.TrimStart('@').TrimEnd('+').ToLower()})))"; break; }
                            if (Regex.IsMatch(one, @"^@-R\d{1,2}$")) {  one = $"at(m(R({one.TrimStart('@','-').ToLower()})))"; break; }
                            if (Regex.IsMatch(one, @"^R\d{1,2}$")) {    one = $"{one.ToLower()}"; break; }
                            if (Regex.IsMatch(one, @"^FR\d{1,2}$")) {   one = $"{one.ToLower()}"; break; }
                            if (Regex.IsMatch(one, @"^R\d{1}_BANK$")) { one = $"{one.ToLower()}"; }
                            break;
                    }
                    args.Add(one);
                }
                var arg = string.Join(", ", args);
                return arg;
            }
            // return $"/* {ToJson(line)} */";
            throw new InvalidOperationException(ToJson(line));
        }

        private static string GetPrefix(BinLine line)
        {
            var mas = line.M[0];
            var fmt = mas.Item.Format ?? "";
            if (fmt.Contains(",@("))
                return "_rs";
            if (fmt.Contains("@("))
                return "_ls";
            return "";
        }

        private static string? GetNibble(IDictionary<char, InstrMat> md, char lt)
        {
            if (md.TryGetValue(lt, out var im))
                if (im is { Index: 4, Length: 4 })
                    return "n1";
                else if (im is { Index: 4, Length: 3 })
                    return "n1 >> 1";
                else if (im is { Index: 4, Length: 2 })
                    return "n1 >> 2";
                else if (im is { Index: 6, Length: 2 })
                    return "n1 & 0b0011";
                else if (im is { Index: 4, Length: 12 })
                    return "(n1 << 8) | ((n2 << 4) | n3)";
                else if (im is { Index: 8, Length: 4 })
                    return "n2";
                else if (im is { Index: 8, Length: 3 })
                    return "n2 >> 1";
                else if (im is { Index: 8, Length: 8 })
                    return "(n2 << 4) | n3";
                else if (im is { Index: 12, Length: 4 })
                    return "n3";
                else if (im is { Index: 12, Length: 1 })
                    return "n3 >> 3";
                else if (im is { Index: 13, Length: 3 })
                    return "n3 & 0b0111";
            throw new InvalidOperationException($"{lt} => {ToJson(md)}");
        }

        private static string[] ParseFormat(InstrPat pat)
        {
            var fmt = pat.Item.Format ?? string.Empty;
            return ParseFormat(fmt);
        }

        private static string[] ParseFormat(string? format)
        {
            var fmt = format ?? string.Empty;
            var parts = fmt.Split(' ', 2);
            _ = parts[0];
            var arg = parts.Length == 2 ? parts[1] : null;
            if (string.IsNullOrWhiteSpace(arg))
                return [];
            var plain = arg.Replace("@(", "").Replace(")", "").Trim();
            var tmp = plain.Split(',')
                .Select(x => x.Trim())
                .Select(x => x.All(char.IsUpper) ? x.ToLower() : x)
                .ToArray();
            return tmp;
        }

        private static string GetCase(string txt, int[] num)
        {
            if (txt == "default")
            {
                num[0]++;
                return $"{txt}: j{num[0]:D3}:";
            }
            return  $"case 0b{txt}:";
        }

        private static IEnumerable<string[]> GetChunked(string? txt)
        {
            foreach (var part in txt?.Split('|') ?? [])
            {
                var item = part.Chunk(4).Select(c => new string(c)).ToArray();
                yield return item;
            }
        }

        private static IEnumerable<BinLine> GetBinaryLines(IEnumerable<ParsedLine> lines, string[] cpus)
        {
            foreach (var line in lines)
            {
                var bin = GetBinaryStr(line.H);
                var mm = RegExs.Match(bin, cpus);
                yield return new(bin, line, mm.ToArray());
            }
        }

        private static string GetBinaryStr(string text)
        {
            var num = ushort.Parse(text.Replace(" ", ""), N.HexNumber);
            return Convert.ToString(num, 2).PadLeft(16, '0');
        }

        private static async Task<StringWriter> GenerateCode(string cpu,
            KeyValuePair<string, ISet<ParsedLine>>[] groups, int maxKey)
        {
            var t = new StringWriter();
            const string nsp = "SuperHot2.Auto";
            var cln = $"{cpu}Decoder";
            await t.WriteLineAsync("using SuperHot;");
            await t.WriteLineAsync("using SuperHot2.Auto.Common;");
            await t.WriteLineAsync("using I = SuperHot2.InstructH;");
            await t.WriteLineAsync();
            await t.WriteLineAsync("// ReSharper disable RedundantAssignment");
            await t.WriteLineAsync("// ReSharper disable InconsistentNaming");
            await t.WriteLineAsync();
            await t.WriteLineAsync($"namespace {nsp}");
            await t.WriteLineAsync("{");
            await t.WriteLineAsync($"\tpublic sealed class {cln} : IDecoder");
            await t.WriteLineAsync("\t{");
            await t.WriteLineAsync("\t\tpublic Instruction? Decode(IByteReader reader, bool fail)");
            await t.WriteLineAsync("\t\t{");
            await t.WriteLineAsync("\t\t\tvar b0 = reader.ReadOne();");
            await t.WriteLineAsync("\t\t\tvar b1 = reader.ReadOne();");
            await t.WriteLineAsync("\t\t\tvar (n0, n1) = ((byte)(b0 >> 4), (byte)(b0 & 0x0F));");
            await t.WriteLineAsync("\t\t\tvar (n2, n3) = ((byte)(b1 >> 4), (byte)(b1 & 0x0F));");
            var i = 0;
            foreach (var (k, _) in groups)
            {
                i++;
                var fn = FixName(k, maxKey);
                await t.WriteLineAsync($"\t\t\tif (d{fn}.Decode(n0, n1, n2, n3) is {{ }} x{i})");
                await t.WriteLineAsync($"\t\t\t\treturn x{i};");
            }
            await t.WriteLineAsync("\t\t\treturn fail ? throw new DecodeException(b0, b1) : I.Word(n0, n1, n2, n3);");
            await t.WriteLineAsync("\t\t}");
            await t.WriteLineAsync("\t}");
            await t.WriteLineAsync("}");
            return t;
        }

        private static KeyValuePair<string, ISet<ParsedLine>>[] GetSorted(
            IDictionary<string, ISet<ParsedLine>> grouped, string cpu)
        {
            var key = $";{cpu};";
            return grouped.Where(g => g.Key.Contains(key))
                .OrderByDescending(g => g.Key.Length)
                .ToArray();
        }

        private static string FixName(string txt, int? pad = null)
        {
            var res = txt.Replace(";Sh;", ";Sh1;").ToUpper()
                .Replace(";SH", "_").Trim(';', '_').Replace("_", "");
            if (pad is { } pm)
                res = res.PadRight(pm, '0');
            return res;
        }

        private static InDi BuildTree(IEnumerable<IGrouping<string, BinLine>> binLines)
        {
            var q0 = new SortedDictionary<string, IDictionary<string,
                IDictionary<string, IDictionary<string, List<BinLine>>>>>();
            foreach (var one in binLines)
            {
                var chunks = GetChunked(one.Key);
                foreach (var t in chunks)
                {
                    if (t.Length == 0)
                        continue;
                    var (p1, p2, p3, p4) = (Y(t[0]), Y(t[1]), Y(t[2]), Y(t[3]));
                    if (!q0.TryGetValue(p1, out var q1))
                        q0[p1] = q1 = new SortedDictionary<string, IDictionary<string, IDictionary<string, List<BinLine>>>>();
                    if (!q1.TryGetValue(p2, out var q2))
                        q1[p2] = q2 = new SortedDictionary<string, IDictionary<string, List<BinLine>>>();
                    if (!q2.TryGetValue(p3, out var q3))
                        q2[p3] = q3 = new SortedDictionary<string, List<BinLine>>();
                    if (!q3.TryGetValue(p4, out var q4))
                        q3[p4] = q4 = new();
                    q4.AddRange(one);
                }
            }
            return q0;
        }

        private static void PatchLines(SortedSet<(string g, string f)> tmp)
        {
            const string word = "return I.Word(n0, n1, n2, n3);";
            var items = CreateDict(tmp);
            if (items.FirstOrDefault(i => i.Value.Any(x =>
                    x.Contains(".Fcnvsd(") || x.Contains(".Fcnvds("))
                ) is var fc && !string.IsNullOrWhiteSpace(fc.Key))
            {
                var fcv = fc.Key.Replace("nnn0", "bbbb").Replace("mmm0", "bbbb");
                tmp.Add((g: word, f: fcv));
            }
        }

        private static void MergeLines(SortedSet<(string g, string f)> tmp)
        {
            var items = CreateDict(tmp);
            var diff = GetCommon(items.Keys, out var common);
            const string nib = "n0, n1, n2, n3"; // GetNibble(diff, 'q')?.Split(' ', 2)[0] ?? "";
            var t = new StringWriter();
            var lines = items.Values.SelectMany(v => v).ToArray();
            var spC = lines.First().Count(x => x == '\t');
            var sp = new string(Enumerable.Repeat('\t', spC).ToArray());
            var meths = lines.Select(l => l.Split(" I.", 2)[1].Split('(', 2)[0]).ToArray();
            var nl = Environment.NewLine;
            var argT = string.Join($",{nl}\t{sp}", lines.Select(l =>
            {
                var desc = items.FirstOrDefault(x => x.Value.Any(y => y == l)).Key;
                return $"/* {desc} */ () => {l.Split("return ", 2)[1].Trim(';', ' ')}";
            }));
            var arg = $", {nl}{sp}{argT}";
            var meth = $"I.{string.Join("_or_", meths)}({nib}{arg})";
            t.WriteLine($"{sp}return {meth};");
            tmp.Clear();
            tmp.Add((g: t.ToString().TrimEnd(), f: common));
        }

        private static Dictionary<string, string[]> CreateDict(SortedSet<(string g, string f)> tmp)
            => tmp.GroupBy(x => x.f)
                .ToDictionary(k => k.Key, v => v.Select(y => y.g).ToArray());

        private static readonly Regex Place = new("(?<q>[_]{1,4})");

        private static Dictionary<char, InstrMat> GetCommon(IEnumerable<string> keys, out string txt)
        {
            char[]? pat = null;
            foreach (var key in keys)
            {
                if (pat == null)
                {
                    pat = key.ToCharArray();
                    continue;
                }
                for (var i = 0; i < key.Length; i++)
                {
                    if (pat[i] == key[i])
                        continue;
                    pat[i] = '_';
                }
            }
            txt = new string(pat);
            var mat = Place.Matches(txt).Single();
            var mar = RegExs.ToMatch(mat).Single();
            return new Dictionary<char, InstrMat> { [mar.Name] = mar };
        }

        private static string Y(string txt)
            => txt.All(t => t is '0' or '1') ? txt : "default";

        internal record BinLine(string B, ParsedLine P, InstrPat[] M)
        {
            internal string BitStrS() => string.Join("|", M.Select(y => y.GetBitStr()));
        }
    }
}