﻿using System;
using System.Net;
using System.Net.Http;

namespace Beam.Rest
{
    public class HttpException : Exception
    {
        public HttpRequestException Exception { get; }
        public HttpStatusCode StatusCode { get; }

        public HttpException(HttpStatusCode code, HttpRequestException ex)
        {
            Exception = ex;
            StatusCode = code;
        }
    }
}
