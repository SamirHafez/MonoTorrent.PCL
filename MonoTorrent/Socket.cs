using Windows.Networking.Sockets;
namespace System.Net.Sockets
{
    public class Socket
    {
        ProtocolType protocol;
        DatagramSocket datagramSocket;

        public Socket(AddressFamily family, SocketType stocketType, ProtocolType protocol)
        {
            this.protocol = protocol;

            switch (protocol)
            {
            case ProtocolType.Udp:
                datagramSocket = new DatagramSocket();
                break;
            }
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
