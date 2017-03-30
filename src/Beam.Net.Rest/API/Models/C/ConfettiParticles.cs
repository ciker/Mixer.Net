using Newtonsoft.Json;

namespace Beam.Rest.API
{
    internal class ConfettiParticles
    {
        [JsonProperty("probability")]
        public int Probability { get; set; }
        [JsonProperty("velocity")]
        public string Velocity { get; set; }
        [JsonProperty("zdepth")]
        public string ZDepth { get; set; }
        [JsonProperty("wiggleMagnitude")]
        public string WiggleMagnitude { get; set; }
        [JsonProperty("wigglePeriod")]
        public string WigglePeriod { get; set; }
        [JsonProperty("lifetime")]
        public string Lifetime { get; set; }
        [JsonProperty("fader")]
        public string Fader { get; set; }
        [JsonProperty("draw")]
        public ConfettiImage Draw { get; set; }
    }
}
