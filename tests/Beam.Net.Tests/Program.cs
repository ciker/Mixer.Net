using System;
using System.Threading.Tasks;

namespace Beam.Net.Tests
{
    class Program
    {
        public static void Main(string[] args)
            => new Program().Start().GetAwaiter().GetResult();
        
        public async Task Start()
        {
            await Task.Delay(-1);
        }
    }
}