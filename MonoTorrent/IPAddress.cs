using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
    public class IPAddress
    {
        public IPAddress(long address)
        {

        }

        public byte[] GetAddressBytes()
        {
            throw new NotImplementedException();
        }

        public int HostToNetworkOrder(int order)
        {
            throw new NotImplementedException();
        }

        public int NetworkToHostOrder(int order)
        {
            throw new NotImplementedException();
        }

        public short HostToNetworkOrder(short order)
        {
            throw new NotImplementedException();
        }

        public long NetworkToHostOrder(long order)
        {
            throw new NotImplementedException();
        }

        public short NetworkToHostOrder(short order)
        {
            throw new NotImplementedException();
        }

        public static IPAddress Parse(string addres)
        {
            throw new NotImplementedException();
        }
    }
}
