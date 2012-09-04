using System;
using System.Collections.Generic;
using System.Net;

namespace DotCradle
{
    public class CradleResponse
    {
        public string Data { get; set; }
        public string StatusDescription { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public IDictionary<string, string> Headers { get; set; }
        public Uri Uri { get; set; }
        public string Method { get; set; }
    }
}