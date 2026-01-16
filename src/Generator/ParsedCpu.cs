namespace Generator
{
    internal record ParsedCpu(
        string Cpu,
        ParsedLine[] Lines
    );
}