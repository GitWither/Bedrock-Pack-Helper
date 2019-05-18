using Newtonsoft.Json;

namespace BedrockRpHelper
{
    public struct MainJson
    {
        [JsonProperty("format_version")]
        public int formatVersion;
        [JsonProperty("header")]
        public Header header;
        [JsonProperty("modules")]
        public Modules[] modules;
    }

    public struct Header
    {
        [JsonProperty("name")]
        public string name;
        [JsonProperty("description")]
        public string description;
        [JsonProperty("uuid")]
        public string uuid;
        [JsonProperty("version")]
        public int[] version;
        [JsonProperty("min_engine_version")]
        public int[] minEngineVersion;
    }

    public struct Modules
    {
        [JsonProperty("type")]
        public string type;
        [JsonProperty("uuid")]
        public string uuid;
        [JsonProperty("version")]
        public int[] version;
    }
}
