using MonoTorrent.Common;
using System.IO;
using Windows.Storage;

namespace MonoTorrent.Client
{
    internal class TorrentFileStream : FileStream
    {
        TorrentFile file;

        public TorrentFile File
        {
            get { return file; }
        }

        public string Path
        {
            get { return file.FullPath; }
        }

        public TorrentFileStream(TorrentFile file, FileAccessMode access)
        {
            this.file = file;
        }
    }
}
