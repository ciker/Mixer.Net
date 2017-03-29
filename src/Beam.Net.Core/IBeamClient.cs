using System.Threading.Tasks;

namespace Beam
{
    public interface IBeamClient
    {
        Task LoginAsync(string token);
        Task ConnectAsync();
        Task DisconnectAsync();
    }
}
