using System;

namespace Mixer.Constellation
{
    public abstract class ConstellationEntity<TId> : IEntity<TId>
    {
        /// <summary> An instance of the client that created this entity </summary>
        public MixerConstellationClient Client { get; }
        /// <summary> The unique identifier for this entity </summary>
        public TId Id { get; }

        public ConstellationEntity(MixerConstellationClient client, TId id)
        {
            Client = client;
            Id = id;
        }

        IMixerClient IEntity<TId>.Client
            => throw new NotImplementedException();
    }
}
