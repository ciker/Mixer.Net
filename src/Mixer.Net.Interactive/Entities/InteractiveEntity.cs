using System;

namespace Mixer.Interactive
{
    public abstract class InteractiveEntity<TId> : IEntity<TId>
    {
        /// <summary> An instance of the client that created this entity </summary>
        public MixerInteractiveClient Client { get; }
        /// <summary> The unique identifier for this entity </summary>
        public TId Id { get; }

        public InteractiveEntity(MixerInteractiveClient client, TId id)
        {
            Client = client;
            Id = id;
        }

        IMixerClient IEntity<TId>.Client
            => throw new NotImplementedException();
    }
}
