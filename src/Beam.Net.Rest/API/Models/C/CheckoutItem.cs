using Newtonsoft.Json;

namespace Beam.Rest.API
{
    internal class CheckoutItem
    {
        [JsonProperty("id")]
        public uint Id { get; set; }
        [JsonProperty("quantity")]
        public uint Quantity { get; set; }
    }
}
