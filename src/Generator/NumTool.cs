using System.Linq;

namespace Generator
{
    internal static class NumTool
    {
        public static int[] Iter16Bit()
        {
            return Enumerable.Range(ushort.MinValue, ushort.MaxValue + 1).ToArray();
        }
    }
}