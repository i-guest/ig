using System.Runtime.CompilerServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the abstract base class from which all implementations of the Advanced Encryption Standard (AES) must inherit. </summary>
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	public abstract class Aes : SymmetricAlgorithm
	{
		private static KeySizes[] s_legalBlockSizes;

		private static KeySizes[] s_legalKeySizes;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Aes" /> class. </summary>
		protected Aes()
		{
		}

		/// <summary>Creates a cryptographic object that is used to perform the symmetric algorithm.</summary>
		/// <returns>A cryptographic object that is used to perform the symmetric algorithm.</returns>
		public new static Aes Create()
		{
			return null;
		}

		/// <summary>Creates a cryptographic object that specifies the implementation of AES to use to perform the symmetric algorithm.</summary>
		/// <param name="algorithmName">The name of the specific implementation of AES to use.</param>
		/// <returns>A cryptographic object that is used to perform the symmetric algorithm.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="algorithmName" /> parameter is <see langword="null" />.</exception>
		public new static Aes Create(string algorithmName)
		{
			return null;
		}
	}
}
