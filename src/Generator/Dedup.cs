using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using KV = (string key, string val);

namespace Generator
{
    internal static class Dedup
    {
        public static List<KV> Cluster(KV[] items)
        {
            var list = new List<KV>();
            foreach (var group in items.GroupBy(BuildKey))
            {
                if (group.Count() == 16)
                {
                    // TODO
                    
                    continue;
                }
                list.AddRange(group);
            }
            return list;
        }

        private static string BuildKey(KV item)
        {
            const string tmp = "r(X)";
            const string pattern = "r(1[0-5]|[0-9])";
            return Regex.Replace(item.val, pattern, tmp);
        }
    }
}