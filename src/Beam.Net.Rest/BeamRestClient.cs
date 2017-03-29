using System;
using System.Threading.Tasks;

namespace Beam.Rest
{
    public class BeamRestClient : BaseRestClient, IBeamClient
    {
        public BeamRestClient() : this(new BeamRestConfig()) { }
        public BeamRestClient(BeamRestConfig config) : base(config) { }

        public Task LoginAsync(string token)
            => RestLoginAsync(token);

        Task IBeamClient.ConnectAsync()
            => throw new NotImplementedException();
        Task IBeamClient.DisconnectAsync()
            => throw new NotImplementedException();
    }
}
