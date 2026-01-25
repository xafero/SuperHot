namespace Generator.Meta
{
    public sealed record Comment
    {
        public string? Item { get; set; }
        public string? Label { get; set; }
        public string? Group { get; set; }
        public string? Desc { get; set; }
    }
}