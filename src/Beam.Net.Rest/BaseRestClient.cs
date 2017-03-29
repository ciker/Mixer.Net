using System.Threading.Tasks;

namespace Beam.Rest
{
    public partial class BaseRestClient
    {
        public RestApiClient RestClient => _rest;
        internal LogManager Logger;

        private RestApiClient _rest;
        private BeamRestConfig _config;

        public BaseRestClient(BeamRestConfig config)
        {
            Logger = new LogManager(config.LogLevel);
            _config = config;

            Logger.LogReceived += OnLogInternalAsync;
        }

        private Task OnLogInternalAsync(LogMessage msg)
            => logEvent.InvokeAsync(msg);

        internal Task RestLoginAsync(string token)
        {
            return Task.CompletedTask;
        }
    }
}
