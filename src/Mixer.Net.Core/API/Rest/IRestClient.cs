﻿using System.Threading;
using System.Threading.Tasks;

namespace Mixer
{
    public interface IRestClient
    {
        void SetHeader(string key, string value);
        void SetCancelToken(CancellationToken cancelToken);

        Task<RestResponse> SendAsync(string method, string endpoint, CancellationToken cancelToken, bool headerOnly = false);
        Task<RestResponse> SendAsync(string method, string endpoint, string json, CancellationToken cancelToken, bool headerOnly = false);
    }
}
