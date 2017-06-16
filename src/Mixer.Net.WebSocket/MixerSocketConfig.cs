using Mixer.Rest;

namespace Mixer.WebSocket
{
    public class MixerSocketConfig : MixerRestConfig
    {
        /// <summary> Gets or sets the provider used to generate new websocket connections. </summary>
        public SocketClientProvider WebSocketProvider { get; set; } = DefaultWebSocketProvider.Instance;
    }
}
