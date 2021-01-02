using System;
using System.Security.Cryptography;

namespace SecureNumber.Encryption
{
    internal static class NumberEncryption
    {
        private static byte[] s_aditionalEntropy = GenerateRandomByteArray();

        public static byte[] Encryption(Int16 baseValue) => Protect(BitConverter.GetBytes(baseValue));
        public static byte[] Encryption(Int32 baseValue) => Protect(BitConverter.GetBytes(baseValue));
        public static byte[] Encryption(Int64 baseValue) => Protect(BitConverter.GetBytes(baseValue));
        public static byte[] Encryption(Single baseValue) => Protect(BitConverter.GetBytes(baseValue));
        public static byte[] Encryption(Double baseValue) => Protect(BitConverter.GetBytes(baseValue));
        public static byte[] Encryption(UInt16 baseValue) => Protect(BitConverter.GetBytes(baseValue));
        public static byte[] Encryption(UInt32 baseValue) => Protect(BitConverter.GetBytes(baseValue));
        public static byte[] Encryption(UInt64 baseValue) => Protect(BitConverter.GetBytes(baseValue));

        public static Int16 DecryptionAsInt16(byte[] secureValue) => BitConverter.ToInt16(Unprotect(secureValue), 0);
        public static Int32 DecryptionAsInt32(byte[] secureValue) => BitConverter.ToInt32(Unprotect(secureValue), 0);
        public static Int64 DecryptionAsInt64(byte[] secureValue) => BitConverter.ToInt64(Unprotect(secureValue), 0);
        public static Single DecryptionAsSingle(byte[] secureValue) => BitConverter.ToSingle(Unprotect(secureValue), 0);
        public static Double DecryptionAsDouble(byte[] secureValue) => BitConverter.ToDouble(Unprotect(secureValue), 0);
        public static UInt16 DecryptionAsUInt16(byte[] secureValue) => BitConverter.ToUInt16(Unprotect(secureValue), 0);
        public static UInt32 DecryptionAsUInt32(byte[] secureValue) => BitConverter.ToUInt32(Unprotect(secureValue), 0);
        public static UInt64 DecryptionAsUInt64(byte[] secureValue) => BitConverter.ToUInt64(Unprotect(secureValue), 0);

        private static byte[] Protect(byte[] data)
        {
            try
            {
                return ProtectedData.Protect(data, s_aditionalEntropy, DataProtectionScope.CurrentUser);
            }
            catch (CryptographicException e)
            {
                // TODO
                throw e;
            }
        }

        private static byte[] Unprotect(byte[] data)
        {
            try
            {
                return ProtectedData.Unprotect(data, s_aditionalEntropy, DataProtectionScope.CurrentUser);
            }
            catch (CryptographicException e)
            {
                // TODO
                throw e;
            }
        }

        private static byte[] GenerateRandomByteArray()
        {
            byte[] result = new byte[16];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(result);
            return result;
        }
    }
}
