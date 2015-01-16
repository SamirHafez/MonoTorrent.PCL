using System.Collections.Generic;
using System.IO;

namespace System.Net
{
    public class HttpListener
    {
        public bool IsListening
        {
            get { throw new NotImplementedException(); }
        }

        public List<string> Prefixes
        {
            get { throw new NotImplementedException(); }
        }

        internal void Start()
        {
            throw new NotImplementedException();
        }

        internal void BeginGetContext(Action<IAsyncResult> endGetRequest, HttpListener listener)
        {
            throw new NotImplementedException();
        }

        internal HttpListenerContext EndGetContext(IAsyncResult result)
        {
            throw new NotImplementedException();
        }
    }

    public class HttpListenerContext
    {
        public HttpListenerRequest Request
        {
            get { throw new NotImplementedException(); }
        }

        public HttpListenerResponse Response
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class HttpListenerRequest : IDisposable
    {
        public string RawUrl
        {
            get { throw new NotImplementedException(); }
        }

        public IPEndPoint RemoteEndPoint
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class HttpListenerResponse : IDisposable
    {
        public Stream OutputStream
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
