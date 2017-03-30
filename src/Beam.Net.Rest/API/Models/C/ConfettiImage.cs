using Newtonsoft.Json;
using System.Collections.Generic;

namespace Beam.Rest.API
{
    internal class ConfettiImage
    {
        [JsonProperty("shape")]
        public string Shape { get; set; }
        [JsonProperty("scale")]
        public string Scale { get; set; }
        [JsonProperty("spinPeriod")]
        public string SpinPeriod { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty("width")]
        public string Width { get; set; }
        [JsonProperty("height")]
        public string Height { get; set; }
        [JsonProperty("size")]
        public string Size { get; set; }
        [JsonProperty("flipPeriod")]
        public string FlipPeriod { get; set; }
        [JsonProperty("colors")]
        public IEnumerable<Color> Colors { get; set; }
    }
}
