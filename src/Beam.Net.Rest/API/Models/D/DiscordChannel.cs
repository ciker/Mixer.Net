using Newtonsoft.Json;

namespace Beam.Rest.API
{
    internal class DiscordChannel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("private")]
        public bool IsPrivate { get; set; }
    }
}
