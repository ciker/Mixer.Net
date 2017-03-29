using Newtonsoft.Json;
using System;

namespace Beam.Rest.API
{
    internal class Timestamped
    {
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("deletedAt")]
        public DateTime? DeletedAt { get; set; }
    }
}
