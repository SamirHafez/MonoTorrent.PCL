namespace System.Net
{
    public class IPAddress
    {
        private long m_Address;

        public static readonly IPAddress Any = new IPAddress(0x0000000000000000);
        public static IPAddress Broadcast
        {
            get { throw new NotImplementedException(); }
        }

        public IPAddress(long newAddress)
        {
            if (newAddress<0 || newAddress>0x00000000FFFFFFFF) {
                throw new ArgumentOutOfRangeException("newAddress");
            }
            m_Address = newAddress;
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
