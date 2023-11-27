using System.Security.Cryptography;

namespace EcomersCryptoLib
{
    public static class EcomersCrypto
    {

        private const int SaltByteSize = 24;
        private const int HashByteSize = 24;
        private const int HasingIterationsCount = 10101;


        public static string GetHashPassword(string password)
        {
           
            byte[] salt;
            byte[] buffer;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, SaltByteSize, HasingIterationsCount))
            {
                salt = bytes.Salt;
                buffer = bytes.GetBytes(HashByteSize);
            }

            byte[] dst = new byte[(SaltByteSize + HashByteSize) + 1];

            Buffer.BlockCopy(salt, 0, dst, 1, SaltByteSize);
            Buffer.BlockCopy(buffer, 0, dst, SaltByteSize + 1, HashByteSize);

            return Convert.ToBase64String(dst);
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] passwordHashBytes;

            int arrayLen = (SaltByteSize + HashByteSize) + 1;

            if (hashedPassword == null)
            {
                return false;
            }

            if (password == null)
            {
                return false;
            }

            byte[] src = Convert.FromBase64String(hashedPassword);

            if ((src.Length != arrayLen) || (src[0] != 0))
            {
                return false;
            }

            byte[] _currentSaltBytes = new byte[SaltByteSize];
            Buffer.BlockCopy(src, 1, _currentSaltBytes, 0, SaltByteSize);

            byte[] currentHashBytes = new byte[HashByteSize];
            Buffer.BlockCopy(src, SaltByteSize + 1, currentHashBytes, 0, HashByteSize);

            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, _currentSaltBytes, HasingIterationsCount))
            {
                passwordHashBytes = bytes.GetBytes(SaltByteSize);
            }

            return AreHashesEqual(currentHashBytes, passwordHashBytes);

        }

        private static bool AreHashesEqual(byte[] firstHash, byte[] secondHash)
        {
            if (firstHash.Length != secondHash.Length) return false;

            int xor = 0;

            for (int i = 0; i < firstHash.Length; i++)
                xor |= firstHash[i] ^ secondHash[i];
            return 0 == xor;
        }

    }
}