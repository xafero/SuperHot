using System;
using System.IO;

namespace Generator
{
    public sealed class TempFile : IDisposable
    {
        public string FileName { get; }

        public TempFile(string? path = null)
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