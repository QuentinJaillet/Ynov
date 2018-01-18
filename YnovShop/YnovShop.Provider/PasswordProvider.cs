using System.Collections.Generic;
using System.Security.Cryptography;

namespace YnovShop.Provider
{
    public class PasswordProvider : IPasswordProvider
    {
        private const int HashByteSize = 24;
        private const int Iterations = 1337;

        public byte[] PasswordHash(string password, byte[] salt)
        {
            byte[] passwordHash;

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
                passwordHash = pbkdf2.GetBytes(HashByteSize);

            return passwordHash;
        }

        public bool Validate(string password, byte[] salt, byte[] passwordHash)
        {
            return ConstantTimeEquals(passwordHash, PasswordHash(password, salt));
        }

        private static bool ConstantTimeEquals(IReadOnlyList<byte> a, IReadOnlyList<byte> b)
        {
            var diff = (uint)a.Count ^ (uint)b.Count;

            for (var i = 0; i < a.Count && i < b.Count; i++)
                diff |= (uint)(a[i] ^ b[i]);

            return diff == 0;
        }
    }
}
