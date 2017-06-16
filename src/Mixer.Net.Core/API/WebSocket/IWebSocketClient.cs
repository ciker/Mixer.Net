using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mixer
{
    public interface IWebSocketClient
    {
        event Func<string, Task> TextMessage;
        event Func<Exception, Task> Closed;

        void SetCancelToken(CancellationToken cancelToken);

        Task ConnectAsync(string host);
        Task DisconnectAsync(bool disposing = false);

        Task SendAsync(string message);
        Task SendAsync(byte[] data, int index, int count, bool isText);
    }
}
