using Newtonsoft.Json;

namespace Beam.Rest.API
{
    internal class ChatUser
    {
        [JsonProperty("userId")]
        public uint UserId { get; set; }
        [JsonProperty("userName")]
        public string Username { get; set; }
        [JsonProperty("userRoles")]
        public string[] UserRoles { get; set; }
        [JsonProperty("lurking")]
        public bool? Lurking { get; set; }
    }
}
