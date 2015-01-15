using System;
using System.Text;
using MonoTorrent.Common;

namespace MonoTorrent.Client
{
    public class TorrentLoadException : TorrentException
    {

        public TorrentLoadException()
            : base()
        {
        }


        public TorrentLoadException(string message)
            : base(message)
        {
        }


        public TorrentLoadException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}