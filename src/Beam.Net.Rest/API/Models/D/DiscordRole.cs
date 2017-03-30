using Newtonsoft.Json;

namespace Beam.Rest.API
{
    internal class DiscordRole
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
    }
}
