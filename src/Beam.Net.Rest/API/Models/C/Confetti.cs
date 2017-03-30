using Newtonsoft.Json;

namespace Beam.Rest.API
{
    internal class Confetti
    {
        [JsonProperty("id")]
        public uint Id { get; set; }
        [JsonProperty("channelId")]
        public uint? ChannelId { get; set; }
        [JsonProperty("settings")]
        public ConfettiSettings Settings { get; set; }
    }
}
