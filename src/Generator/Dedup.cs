using System;
using System.Collections.Generic;
using System.Linq;
using KV = (string key, string val);

namespace Generator
{
    internal static class Dedup
    {
        internal static List<KV> Cluster(KV[] items)
        {
            var list = new List<KV>();
            foreach (var group in items.GroupBy(i => BuildKey(i, "rXX")))
            {
                if (group.Count() == 16)
                {
                    var kg = group.Select(g => $"{g.key}").ToArray();
                    var kk = FindCommon(kg);
                    if (kk.StartsWith("0x?"))
                    {
                        const string arg = "R(b1 >> 4)";
                        var idd = group.Select(g => FindIdx(g).ToArray()).ToArray();
                        var gid = GroupIdx(idd);
                        var rid = gid.Where(x => x.Value.Count == 1)
                            .GroupBy(x => x.Value.Single())
                            .MaxBy(x => x.Count());
                        if (rid != null)
                        {
                            var tid = rid.MaxBy(r => r.Key.Length);
                            var tii = tid.Value.Single();
                            var fi = group.FirstOrDefault(g => g.val.IndexOf(tid.Key, C) == tid.Value.First());
                            var fc = fi.val.Remove(tii, tid.Key.Length);
                            fc = fc.Insert(tii, arg);
                            foreach (var itg in group.Select(g => g.key))
                                list.Add((itg, fc));
                            continue;
                        }
                    }
                }
                list.AddRange(group);
            }
            return list;
        }

        private static Dictionary<string, ISet<int>> GroupIdx((string txt, int idx)[][] idd)
        {
            var dict = new Dictionary<string, ISet<int>>();
            foreach (var tup in idd)
            {
                foreach (var it in tup)
                {
                    if (!dict.TryGetValue(it.txt, out var val))
                        dict[it.txt] = val = new SortedSet<int>();
                    val.Add(it.idx);
                }
            }
            return dict;
        }

        private static string BuildKey(KV item, string? t = null)
        {
            var key = item.val;
            return key
                .Replace("r10", t ?? "r10")
                .Replace("r11", t ?? "r11")
                .Replace("r12", t ?? "r12")
                .Replace("r13", t ?? "r13")
                .Replace("r14", t ?? "r14")
                .Replace("r15", t ?? "r15")
                .Replace("r0", t ?? "r00")
                .Replace("r1", t ?? "r01")
                .Replace("r2", t ?? "r02")
                .Replace("r3", t ?? "r03")
                .Replace("r4", t ?? "r04")
                .Replace("r5", t ?? "r05")
                .Replace("r6", t ?? "r06")
                .Replace("r7", t ?? "r07")
                .Replace("r8", t ?? "r08")
                .Replace("r9", t ?? "r09")
                .Replace("r010", t ?? "r10")
                .Replace("r011", t ?? "r11")
                .Replace("r012", t ?? "r12")
                .Replace("r013", t ?? "r13")
                .Replace("r014", t ?? "r14")
                .Replace("r015", t ?? "r15");
        }

        private static string FindCommon(ICollection<string> items)
        {
            var size = items.Max(i => i.Length);
            var text = new char?[size];
            foreach (var item in items)
            {
                for (var i = 0; i < item.Length; i++)
                {
                    if (text[i] == null)
                    {
                        text[i] = item[i];
                        continue;
                    }
                    if (text[i].Equals(item[i]))
                        continue;
                    text[i] = '?';
                }
            }
            var common = string.Join("", text);
            return common;
        }

        private const StringComparison C = StringComparison.Ordinal;

        private static IEnumerable<(string txt, int idx)> FindIdx(KV item, int off = 0)
        {
            var idx = -1;
            var key = item.val;
            var tmp = "";
            if ((idx = key.IndexOf(tmp = "r15", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r14", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r13", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r12", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r11", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r10", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r09", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r08", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r07", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r06", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r05", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r04", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r03", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r02", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r01", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r00", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r9", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r8", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r7", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r6", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r5", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r4", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r3", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r2", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r1", off, C)) != -1)
                yield return (tmp, idx);
            if ((idx = key.IndexOf(tmp = "r0", off, C)) != -1)
                yield return (tmp, idx);
        }
    }
}