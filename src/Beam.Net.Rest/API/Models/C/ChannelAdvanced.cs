using Newtonsoft.Json;

namespace Beam.Rest.API
{
    internal class ChannelAdvanced : Channel
    {
        [JsonProperty("type")]
        public string GameType { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
