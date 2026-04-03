using System.Security.Cryptography;

namespace Mono.Security.Cryptography
{
	internal sealed class CryptoConvert
	{
		private static int ToInt32LE(byte[] bytes, int offset)
		{
			return 0;
		}

		private static uint ToUInt32LE(byte[] bytes, int offset)
		{
			return 0u;
		}

		private static byte[] GetBytesLE(int val)
		{
			return null;
		}

		private static byte[] Trim(byte[] array)
		{
			return null;
		}

		public static RSA FromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			return null;
		}

		private static RSAParameters GetParametersFromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			return default(RSAParameters);
		}

		public static DSA FromCapiPrivateKeyBlobDSA(byte[] blob, int offset)
		{
			return null;
		}

		public static byte[] ToCapiPrivateKeyBlob(RSA rsa)
		{
			return null;
		}

		public static byte[] ToCapiPrivateKeyBlob(DSA dsa)
		{
			return null;
		}

		public static RSA FromCapiPublicKeyBlob(byte[] blob, int offset)
		{
			return null;
		}

		private static RSAParameters GetParametersFromCapiPublicKeyBlob(byte[] blob, int offset)
		{
			return default(RSAParameters);
		}

		public static DSA FromCapiPublicKeyBlobDSA(byte[] blob, int offset)
		{
			return null;
		}

		public static byte[] ToCapiPublicKeyBlob(RSA rsa)
		{
			return null;
		}

		public static byte[] ToCapiPublicKeyBlob(DSA dsa)
		{
			return null;
		}

		public static RSA FromCapiKeyBlob(byte[] blob)
		{
			return null;
		}

		public static RSA FromCapiKeyBlob(byte[] blob, int offset)
		{
			return null;
		}

		public static DSA FromCapiKeyBlobDSA(byte[] blob)
		{
			return null;
		}

		public static DSA FromCapiKeyBlobDSA(byte[] blob, int offset)
		{
			return null;
		}
	}
}
