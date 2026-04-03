namespace System.Security.Cryptography
{
	public sealed class AesGcm : IDisposable
	{
		public static KeySizes NonceByteSizes => null;

		public static KeySizes TagByteSizes => null;

		public AesGcm(byte[] key)
		{
		}

		public AesGcm(ReadOnlySpan<byte> key)
		{
		}

		public void Decrypt(byte[] nonce, byte[] ciphertext, byte[] tag, byte[] plaintext, byte[] associatedData = null)
		{
		}

		public void Decrypt(ReadOnlySpan<byte> nonce, ReadOnlySpan<byte> ciphertext, ReadOnlySpan<byte> tag, Span<byte> plaintext, ReadOnlySpan<byte> associatedData = default(ReadOnlySpan<byte>))
		{
		}

		public void Dispose()
		{
		}

		public void Encrypt(byte[] nonce, byte[] plaintext, byte[] ciphertext, byte[] tag, byte[] associatedData = null)
		{
		}

		public void Encrypt(ReadOnlySpan<byte> nonce, ReadOnlySpan<byte> plaintext, Span<byte> ciphertext, Span<byte> tag, ReadOnlySpan<byte> associatedData = default(ReadOnlySpan<byte>))
		{
		}
	}
}
