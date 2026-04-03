namespace System.Security.Cryptography
{
	internal static class Utils
	{
		internal const int DefaultRsaProviderType = 1;

		private static RNGCryptoServiceProvider _rng;

		internal static RNGCryptoServiceProvider StaticRandomNumberGenerator => null;

		internal static byte[] GenerateRandom(int keySize)
		{
			return null;
		}

		internal static bool HasAlgorithm(int dwCalg, int dwKeySize)
		{
			return false;
		}

		internal static string DiscardWhiteSpaces(string inputBuffer)
		{
			return null;
		}

		internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		internal static int ConvertByteArrayToInt(byte[] input)
		{
			return 0;
		}

		internal static byte[] ConvertIntToByteArray(int dwInput)
		{
			return null;
		}

		internal static void ConvertIntToByteArray(uint dwInput, ref byte[] counter)
		{
		}

		internal static byte[] FixupKeyParity(byte[] key)
		{
			return null;
		}

		internal unsafe static void DWORDFromLittleEndian(uint* x, int digits, byte* block)
		{
		}

		internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits)
		{
		}

		internal unsafe static void DWORDFromBigEndian(uint* x, int digits, byte* block)
		{
		}

		internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits)
		{
		}

		internal unsafe static void QuadWordFromBigEndian(ulong* x, int digits, byte* block)
		{
		}

		internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits)
		{
		}

		internal static byte[] Int(uint i)
		{
			return null;
		}

		internal static byte[] RsaOaepEncrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, RandomNumberGenerator rng, byte[] data)
		{
			return null;
		}

		internal static byte[] RsaOaepDecrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, byte[] encryptedData)
		{
			return null;
		}

		internal static byte[] RsaPkcs1Padding(RSA rsa, byte[] oid, byte[] hash)
		{
			return null;
		}

		internal static bool CompareBigIntArrays(byte[] lhs, byte[] rhs)
		{
			return false;
		}

		internal static HashAlgorithmName OidToHashAlgorithmName(string oid)
		{
			return default(HashAlgorithmName);
		}

		internal static bool DoesRsaKeyOverride(RSA rsaKey, string methodName, Type[] parameterTypes)
		{
			return false;
		}

		private static bool DoesRsaKeyOverrideSlowPath(Type t, string methodName, Type[] parameterTypes)
		{
			return false;
		}

		internal static bool _ProduceLegacyHmacValues()
		{
			return false;
		}
	}
}
