using Mixer.Rest;
using System.Threading.Tasks;

namespace Mixer.Net.Tests
{
    class Program
    {
        public static void Main(string[] args)
            => new Program().StartAsync().GetAwaiter().GetResult();

        private MixerRestClient _client;

        public async Task StartAsync()
        {
            await Task.Delay(0);
        }
    }
}