using Newtonsoft.Json;
using System.Collections.Generic;

namespace Beam.Rest.API
{
    internal class ConfettiSettings
    {
        [JsonProperty("count")]
        public string Count { get; set; }
        [JsonProperty("particles")]
        public IEnumerable<ConfettiParticle> Particles { get; set; }
    }
}
