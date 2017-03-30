using Newtonsoft.Json;

namespace Beam.Rest.API
{
    internal class ChannelPreferences
    {
        [JsonProperty("costream:allow")]
        public string AllowCoStream { get; set; }
        [JsonProperty("sharetext")]
        public string ShareText { get; set; }
        [JsonProperty("channel:links:allowed")]
        public bool? AllowLinks { get; set; }
        [JsonProperty("channel:links:clickable")]
        public bool? ClickableLinks { get; set; }
        [JsonProperty("channel:slowchat")]
        public int? SlowChat { get; set; }
        [JsonProperty("channel:notify:subscribemessage")]
        public string SubscribeMessage { get; set; }
        [JsonProperty("channel:notify:subscribe")]
        public bool? Subscribe { get; set; }
        [JsonProperty("channel:notify:followmessage")]
        public string FollowMessage { get; set; }
        [JsonProperty("channel:notify:follow")]
        public bool? Follow { get; set; }
        [JsonProperty("channel:notify:hostedBy")]
        public string HostedMessage { get; set; }
        [JsonProperty("channel:notify:hosting")]
        public string HostingMessage { get; set; }
        [JsonProperty("channel:partner:submail")]
        public string SubMail { get; set; }
        [JsonProperty("channel:player:muteOwn")]
        public bool? MuteOwn { get; set; }
        [JsonProperty("channel:tweet:enabled")]
        public bool? TwitterEnabled { get; set; }
        [JsonProperty("channel:tweet:body")]
        public string TweetBody { get; set; }
    }
}
