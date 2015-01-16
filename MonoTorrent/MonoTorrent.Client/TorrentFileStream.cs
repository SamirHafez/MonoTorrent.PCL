using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MonoTorrent.Common;
using Windows.Storage;

namespace MonoTorrent.Client
{
    internal class TorrentFileStream
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
