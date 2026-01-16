using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Generator
{
    internal static class JsonTool
    {
        public static string ToJson(object? obj)
        {
            var cfg = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Converters = { new StringEnumConverter() },
                Formatting = Formatting.Indented
            };
            return JsonConvert.SerializeObject(obj, cfg);
        }
    }
}