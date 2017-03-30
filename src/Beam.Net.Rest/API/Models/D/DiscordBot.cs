using Newtonsoft.Json;
using System.Collections.Generic;

namespace Beam.Rest.API
{
    internal class DiscordBot
    {
        [JsonProperty("id")]
        public uint Id { get; set; }
        [JsonProperty("channelId")]
        public uint ChannelId { get; set; }
        [JsonProperty("guildId")]
        public string GuildId { get; set; }
        [JsonProperty("inviteSetting")]
        public string InviteSetting { get; set; }
        [JsonProperty("inviteChannel")]
        public string InviteChannel { get; set; }
        [JsonProperty("liveUpdateState")]
        public bool LiveUpdateState { get; set; }
        [JsonProperty("liveChatChannel")]
        public string LiveChatChannel { get; set; }
        [JsonProperty("liveAnnounceChannel")]
        public string LiveAnnounceChannel { get; set; }
        [JsonProperty("syncEmoteRoles")]
        public IEnumerable<uint> SyncEmoteRoles { get; set; }
        [JsonProperty("roles")]
        public IEnumerable<DiscordBotRole> Roles { get; set; }
    }
}
