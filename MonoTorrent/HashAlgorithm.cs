using System.IO;

namespace System.Security.Cryptography
{
    public class HashAlgorithm : IDisposable
    {
        public byte[] Hash
        {
            get { throw new NotImplementedException(); }
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        internal void TransformBlock(byte[] buffer1, int bufferRead1, int read, byte[] buffer2, int bufferRead2)
        {
            throw new NotImplementedException();
        }

        public byte[] ComputeHash(byte[] buffer)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal byte[] ComputeHash(MemoryStream stream)
        {
            throw new NotImplementedException();
        }

        internal void TransformFinalBlock(byte[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        internal void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
