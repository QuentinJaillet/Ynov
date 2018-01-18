using System;
using System.Security.Cryptography;

namespace YnovShop.Provider
{
    public class SaltProvider : ISaltProvider
    {
        public const int SaltByteSize = 24;

        public byte[] GetSalt()
        {
            var saltBytes = new byte[SaltByteSize];

            using (var rng = new RNGCryptoServiceProvider())
                rng.GetNonZeroBytes(saltBytes);

            return saltBytes;
        }
    }
}
