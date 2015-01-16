namespace System.Net
{
    public class IPAddress
    {
        public static IPAddress Any
        {
            get { throw new NotImplementedException(); }
        }

        public static IPAddress Broadcast
        {
            get { throw new NotImplementedException(); }
        }

        public IPAddress(long address)
        {

        }

        public byte[] GetAddressBytes()
        {
            throw new NotImplementedException();
        }

        public static int HostToNetworkOrder(int order)
        {
            throw new NotImplementedException();
        }

        public static int NetworkToHostOrder(int order)
        {
            throw new NotImplementedException();
        }

        public static short HostToNetworkOrder(short order)
        {
            throw new NotImplementedException();
        }

        public static long NetworkToHostOrder(long order)
        {
            throw new NotImplementedException();
        }

        public static short NetworkToHostOrder(short order)
        {
            throw new NotImplementedException();
        }

        public static IPAddress Parse(string addres)
        {
            throw new NotImplementedException();
        }

        internal static bool TryParse(string address, out IPAddress supplied)
        {
            throw new NotImplementedException();
        }
    }
}
