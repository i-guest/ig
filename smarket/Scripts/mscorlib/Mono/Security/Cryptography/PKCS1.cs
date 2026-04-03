using System.Security.Cryptography;

namespace Mono.Security.Cryptography
{
	internal sealed class PKCS1
	{
		private static byte[] emptySHA1;

		private static byte[] emptySHA256;

		private static byte[] emptySHA384;

		private static byte[] emptySHA512;

		private static bool Compare(byte[] array1, byte[] array2)
		{
			return false;
		}

		private static byte[] xor(byte[] array1, byte[] array2)
		{
			return null;
		}

		private static byte[] GetEmptyHash(HashAlgorithm hash)
		{
			return null;
		}

		public static byte[] I2OSP(int x, int size)
		{
			return null;
		}

		public static byte[] I2OSP(byte[] x, int size)
		{
			return null;
		}

		public static byte[] OS2IP(byte[] x)
		{
			return null;
		}

		public static byte[] RSAEP(RSA rsa, byte[] m)
		{
			return null;
		}

		public static byte[] RSADP(RSA rsa, byte[] c)
		{
			return null;
		}

		public static byte[] RSASP1(RSA rsa, byte[] m)
		{
			return null;
		}

		public static byte[] RSAVP1(RSA rsa, byte[] s)
		{
			return null;
		}

		public static byte[] Encrypt_OAEP(RSA rsa, HashAlgorithm hash, RandomNumberGenerator rng, byte[] M)
		{
			return null;
		}

		public static byte[] Decrypt_OAEP(RSA rsa, HashAlgorithm hash, byte[] C)
		{
			return null;
		}

		public static byte[] Sign_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue)
		{
			return null;
		}

		internal static byte[] Sign_v15(RSA rsa, string hashName, byte[] hashValue)
		{
			return null;
		}

		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature)
		{
			return false;
		}

		internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature)
		{
			return false;
		}

		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding)
		{
			return false;
		}

		public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength)
		{
			return null;
		}

		public static byte[] MGF1(HashAlgorithm hash, byte[] mgfSeed, int maskLen)
		{
			return null;
		}

		internal static HashAlgorithm CreateFromName(string name)
		{
			return null;
		}
	}
}
