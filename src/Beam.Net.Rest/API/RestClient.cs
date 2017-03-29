using System;
using System.Net.Http;

namespace Beam.Rest
{
    internal class RestClient : IDisposable
    {
        private HttpClient _client = null;
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposed = true;
            }
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
    }
}
