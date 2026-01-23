using F23.StringSimilarity;
using System.Collections.Generic;

namespace Generator
{
    internal static class Dedup
    {
        public static List<List<string>> Cluster(List<string> strings, double threshold = 0.8)
        {
            var metric = new JaroWinkler();
            var clusters = new List<List<string>>();
            var assigned = new Dictionary<string, int>();

            foreach (var str in strings)
            {
                if (assigned.ContainsKey(str)) continue;

                var bestCluster = -1;
                double bestSimilarity = 0;

                for (var i = 0; i < clusters.Count; i++)
                {
                    var sim = metric.Similarity(str, clusters[i][0]);
                    if (sim > bestSimilarity && sim >= threshold)
                    {
                        bestSimilarity = sim;
                        bestCluster = i;
                    }
                }

                if (bestCluster >= 0)
                {
                    clusters[bestCluster].Add(str);
                    assigned[str] = bestCluster;
                }
                else
                {
                    clusters.Add([str]);
                    assigned[str] = clusters.Count - 1;
                }
            }

            return clusters;
        }
    }
}