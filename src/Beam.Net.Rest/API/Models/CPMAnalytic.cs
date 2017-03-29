using Newtonsoft.Json;

namespace Beam.Rest.API
{
    internal class CPMAnalytic
    {
        [JsonProperty("channel")]
        public uint Channel { get; set; }
        [JsonProperty("impressions")]
        public uint Impressions { get; set; }
        [JsonProperty("payout")]
        public double Payout { get; set; }
    }
}
