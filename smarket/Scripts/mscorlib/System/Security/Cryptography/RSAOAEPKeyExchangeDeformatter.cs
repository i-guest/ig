using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Decrypts Optimal Asymmetric Encryption Padding (OAEP) key exchange data.</summary>
	[ComVisible(true)]
	public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		private RSA _rsaKey;

		private bool? _rsaOverridesDecrypt;

		/// <summary>Gets the parameters for the Optimal Asymmetric Encryption Padding (OAEP) key exchange.</summary>
		/// <returns>An XML string containing the parameters of the OAEP key exchange operation.</returns>
		public override string Parameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool OverridesDecrypt => false;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAOAEPKeyExchangeDeformatter" /> class.</summary>
		public RSAOAEPKeyExchangeDeformatter()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSAOAEPKeyExchangeDeformatter" /> class with the specified key.</summary>
		/// <param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the private key. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key " />is <see langword="null" />.</exception>
		public RSAOAEPKeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
		}

		/// <summary>Extracts secret information from the encrypted key exchange data.</summary>
		/// <param name="rgbData">The key exchange data within which the secret information is hidden. </param>
		/// <returns>The secret information derived from the key exchange data.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key exchange data verification has failed. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The key is missing.</exception>
		public override byte[] DecryptKeyExchange(byte[] rgbData)
		{
			return null;
		}

		/// <summary>Sets the private key to use for decrypting the secret information.</summary>
		/// <param name="key">The instance of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm that holds the private key. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}
	}
}
