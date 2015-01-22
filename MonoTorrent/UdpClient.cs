namespace System.Net.Sockets
{
    public class UdpClient
    {
        public Socket Client
        {
            get { throw new NotImplementedException(); }
        }

        public UdpClient(int port)
        {
            throw new NotImplementedException();
        }

        public UdpClient()
        {
            throw new NotImplementedException();
        }

        public UdpClient(string host, int port)
        {
            throw new NotImplementedException();
        }

        public UdpClient(IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        internal void JoinMulticastGroup(IPAddress multicastIpAddress)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void BeginReceive(AsyncCallback asyncCallback, object state)
        {
            throw new NotImplementedException();
        }

        internal byte[] EndReceive(IAsyncResult ar, ref IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        internal void Send(byte[] data, int length, IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        internal void Connect(string host, int port)
        {
            throw new NotImplementedException();
        }

        internal void Send(byte[] buffer, int length)
        {
            throw new NotImplementedException();
        }
    }
}
