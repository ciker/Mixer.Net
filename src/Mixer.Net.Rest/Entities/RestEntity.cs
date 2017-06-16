using System;

namespace Mixer.Rest
{
    public abstract class RestEntity<TId> : IEntity<TId>
    {
        /// <summary> An instance of the client that created this entity </summary>
        public BaseMixerClient Client { get; }
        /// <summary> The unique identifier for this entity </summary>
        public TId Id { get; }

        public RestEntity(BaseMixerClient client, TId id)
        {
            Client = client;
            Id = id;
        }

        IMixerClient IEntity<TId>.Client
            => throw new NotImplementedException();
    }
}
