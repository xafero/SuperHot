using System;
using System.IO;

namespace Generator
{
    internal sealed class TempFile : IDisposable
    {
        internal string FileName { get; }

        internal TempFile(string? path = null)
        {
            FileName = path ?? Path.GetTempFileName();
        }

        public void Dispose()
        {
            if (File.Exists(FileName))
                File.Delete(FileName);
        }
    }
}