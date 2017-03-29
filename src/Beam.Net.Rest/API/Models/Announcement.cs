using Newtonsoft.Json;

namespace Beam.Rest.API
{
    internal class Announcement
    {
        [JsonProperty("texct")]
        public string Text { get; set; }
        [JsonProperty("script")]
        public string Script { get; set; }
        [JsonProperty("scope")]
        public object Scope { get; set; }
    }
}
