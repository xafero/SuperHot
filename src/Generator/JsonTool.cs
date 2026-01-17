using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Generator
{
    internal static class JsonTool
    {
        public static string ToJson(object? obj, bool format = false)
        {
            var cfg = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Converters = { new StringEnumConverter() },
                Formatting = format ? Formatting.Indented : Formatting.None
            };
            return JsonConvert.SerializeObject(obj, cfg);
        }
    }
}