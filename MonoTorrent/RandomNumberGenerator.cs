namespace System.Security.Cryptography
{
    public abstract class RandomNumberGenerator
    {
        public abstract void GetBytes(byte[] b);
    }

    public class RNGCryptoServiceProvider : RandomNumberGenerator
    {
        public override void GetBytes(byte[] b)
        {
            throw new NotImplementedException();
        }
    }
}
