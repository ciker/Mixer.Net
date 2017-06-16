using System;

namespace Mixer.Chat
{
    public abstract class ChatEntity<TId> : IEntity<TId>
    {
        /// <summary> An instance of the client that created this entity </summary>
        public MixerChatClient Client { get; }
        /// <summary> The unique identifier for this entity </summary>
        public TId Id { get; }

        public ChatEntity(MixerChatClient client, TId id)
        {
            Client = client;
            Id = id;
        }

        IMixerClient IEntity<TId>.Client
            => throw new NotImplementedException();
    }
}
