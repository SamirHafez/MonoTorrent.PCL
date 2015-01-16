namespace System.Net.Sockets
{
    public class Socket
    {
        public Socket(AddressFamily interNetwork, SocketType stream, ProtocolType tcp)
        {
            throw new NotImplementedException();
        }

        public bool Connected
        {
            get { throw new NotImplementedException(); }
        }

        public AddressFamily AddressFamily
        {
            get { throw new NotImplementedException(); }
        }

        public IPEndPoint RemoteEndPoint
        {
            get { throw new NotImplementedException(); }
        }

        internal Socket EndAccept(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void BeginAccept(AsyncCallback endAcceptCallback, object state)
        {
            throw new NotImplementedException();
        }

        internal void Bind(IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        internal void Listen(int port)
        {
            throw new NotImplementedException();
        }

        internal IAsyncResult BeginConnect(EndPoint endpoint, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        internal void EndConnect(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        internal int EndReceive(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        internal int EndSend(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        internal IAsyncResult BeginReceive(byte[] buffer, int offset, int count, object none, AsyncCallback asyncCallback, object state)
        {
            throw new NotImplementedException();
        }

        internal IAsyncResult BeginSend(byte[] buffer, int offset, int count, object none, AsyncCallback asyncCallback, object state)
        {
            throw new NotImplementedException();
        }
    }
}
