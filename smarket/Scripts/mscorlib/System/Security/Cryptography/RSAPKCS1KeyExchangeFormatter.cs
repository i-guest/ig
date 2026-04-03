using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Creates the PKCS#1 key exchange data using <see cref="T:System.Security.Cryptography.RSA" />.</summary>
	[ComVisible(true)]
	public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		private RandomNumberGenerator RngValue;

		private RSA _rsaKey;

		private bool? _rsaOverridesEncrypt;

		/// <summary>Gets the parameters for the PKCS #1 key exchange.</summary>
		/// <returns>An XML string containing the parameters of the PKCS #1 key exchange operation.</returns>
		public override string Parameters => null;

		/// <summary>Gets or sets the random number generator algorithm to use in the creation of the key exchange.</summary>
		/// <returns>The instance of a random number generator algorithm to use.</returns>
		public RandomNumberGenerator Rng
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool OverridesEncrypt => false;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter" /> class.</summary>
		public RSAPKCS1KeyExchangeFormatter()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter" /> class with the specified key.</summary>
		/// <param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the public key. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key " />is <see langword="null" />.</exception>
		public RSAPKCS1KeyExchangeFormatter(AsymmetricAlgorithm key)
		{
		}

		/// <summary>Sets the public key to use for encrypting the key exchange data.</summary>
		/// <param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the public key. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key " />is <see langword="null" />.</exception>
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		/// <summary>Creates the encrypted key exchange data from the specified input data.</summary>
		/// <param name="rgbData">The secret information to be passed in the key exchange. </param>
		/// <returns>The encrypted key exchange data to be sent to the intended recipient.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///         <paramref name="rgbData " />is too big.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The key is <see langword="null" />.</exception>
		public override byte[] CreateKeyExchange(byte[] rgbData)
		{
			return null;
		}

		/// <summary>Creates the encrypted key exchange data from the specified input data.</summary>
		/// <param name="rgbData">The secret information to be passed in the key exchange. </param>
		/// <param name="symAlgType">This parameter is not used in the current version. </param>
		/// <returns>The encrypted key exchange data to be sent to the intended recipient.</returns>
		public override byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType)
		{
			return null;
		}
	}
}
