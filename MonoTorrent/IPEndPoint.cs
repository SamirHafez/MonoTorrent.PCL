using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
    public class EndPoint { }

    public class IPEndPoint : EndPoint
    {
        public IPAddress Address { get; private set; }

        public int Port { get; private set; }

        public IPEndPoint(IPAddress address, int port)
        {
            Address = address;
            Port = port;
        }
    }
}
