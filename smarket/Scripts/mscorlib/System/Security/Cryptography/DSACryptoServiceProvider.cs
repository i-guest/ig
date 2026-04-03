using System.IO;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Defines a wrapper object to access the cryptographic service provider (CSP) implementation of the <see cref="T:System.Security.Cryptography.DSA" /> algorithm. This class cannot be inherited. </summary>
	[ComVisible(true)]
	public sealed class DSACryptoServiceProvider : DSA, ICspAsymmetricAlgorithm
	{
		private const int PROV_DSS_DH = 13;

		private KeyPairPersistence store;

		private bool persistKey;

		private bool persisted;

		private bool privateKeyExportable;

		private bool m_disposed;

		private DSAManaged dsa;

		private static bool useMachineKeyStore;

		/// <summary>Gets the name of the key exchange algorithm.</summary>
		/// <returns>The name of the key exchange algorithm.</returns>
		public override string KeyExchangeAlgorithm => null;

		/// <summary>Gets the size of the key used by the asymmetric algorithm in bits.</summary>
		/// <returns>The size of the key used by the asymmetric algorithm.</returns>
		public override int KeySize => 0;

		/// <summary>Gets or sets a value indicating whether the key should be persisted in the cryptographic service provider (CSP).</summary>
		/// <returns>
		///     <see langword="true" /> if the key should be persisted in the CSP; otherwise, <see langword="false" />.</returns>
		public bool PersistKeyInCsp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets a value that indicates whether the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object contains only a public key.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object contains only a public key; otherwise, <see langword="false" />.</returns>
		[ComVisible(false)]
		public bool PublicOnly => false;

		/// <summary>Gets the name of the signature algorithm.</summary>
		/// <returns>The name of the signature algorithm.</returns>
		public override string SignatureAlgorithm => null;

		/// <summary>Gets or sets a value indicating whether the key should be persisted in the computer's key store instead of the user profile store.</summary>
		/// <returns>
		///     <see langword="true" /> if the key should be persisted in the computer key store; otherwise, <see langword="false" />.</returns>
		public static bool UseMachineKeyStore
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets a <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> object that describes additional information about a cryptographic key pair.  </summary>
		/// <returns>A <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> object that describes additional information about a cryptographic key pair.</returns>
		[ComVisible(false)]
		[MonoTODO("call into KeyPairPersistence to get details")]
		public CspKeyContainerInfo CspKeyContainerInfo => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class.</summary>
		public DSACryptoServiceProvider()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class with the specified parameters for the cryptographic service provider (CSP).</summary>
		/// <param name="parameters">The parameters for the CSP. </param>
		public DSACryptoServiceProvider(CspParameters parameters)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class with the specified key size.</summary>
		/// <param name="dwKeySize">The size of the key for the asymmetric algorithm in bits. </param>
		public DSACryptoServiceProvider(int dwKeySize)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> class with the specified key size and parameters for the cryptographic service provider (CSP).</summary>
		/// <param name="dwKeySize">The size of the key for the cryptographic algorithm in bits. </param>
		/// <param name="parameters">The parameters for the CSP. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired.-or- The key cannot be created. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="dwKeySize" /> is out of range.</exception>
		public DSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
		}

		private void Common(int dwKeySize, bool parameters)
		{
		}

		private void Common(CspParameters parameters)
		{
		}

		~DSACryptoServiceProvider()
		{
		}

		/// <summary>Exports the <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
		/// <param name="includePrivateParameters">
		///       <see langword="true" /> to include private parameters; otherwise, <see langword="false" />. </param>
		/// <returns>The parameters for <see cref="T:System.Security.Cryptography.DSA" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key cannot be exported. </exception>
		public override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			return default(DSAParameters);
		}

		/// <summary>Imports the specified <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
		/// <param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.DSA" />. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="parameters" /> parameter has missing fields. </exception>
		public override void ImportParameters(DSAParameters parameters)
		{
		}

		/// <summary>Creates the <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</summary>
		/// <param name="rgbHash">The data to be signed. </param>
		/// <returns>The digital signature for the specified data.</returns>
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			return null;
		}

		/// <summary>Computes the hash value of the specified byte array and signs the resulting hash value.</summary>
		/// <param name="buffer">The input data for which to compute the hash. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</returns>
		public byte[] SignData(byte[] buffer)
		{
			return null;
		}

		/// <summary>Signs a byte array from the specified start point to the specified end point.</summary>
		/// <param name="buffer">The input data to sign. </param>
		/// <param name="offset">The offset into the array from which to begin using data. </param>
		/// <param name="count">The number of bytes in the array to use as data. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</returns>
		public byte[] SignData(byte[] buffer, int offset, int count)
		{
			return null;
		}

		/// <summary>Computes the hash value of the specified input stream and signs the resulting hash value.</summary>
		/// <param name="inputStream">The input data for which to compute the hash. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</returns>
		public byte[] SignData(Stream inputStream)
		{
			return null;
		}

		/// <summary>Computes the signature for the specified hash value by encrypting it with the private key.</summary>
		/// <param name="rgbHash">The hash value of the data to be signed. </param>
		/// <param name="str">The name of the hash algorithm used to create the hash value of the data. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified hash value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- There is no private key. </exception>
		public byte[] SignHash(byte[] rgbHash, string str)
		{
			return null;
		}

		/// <summary>Verifies the specified signature data by comparing it to the signature computed for the specified data.</summary>
		/// <param name="rgbData">The data that was signed. </param>
		/// <param name="rgbSignature">The signature data to be verified. </param>
		/// <returns>
		///     <see langword="true" /> if the signature verifies as valid; otherwise, <see langword="false" />.</returns>
		public bool VerifyData(byte[] rgbData, byte[] rgbSignature)
		{
			return false;
		}

		/// <summary>Verifies the specified signature data by comparing it to the signature computed for the specified hash value.</summary>
		/// <param name="rgbHash">The hash value of the data to be signed. </param>
		/// <param name="str">The name of the hash algorithm used to create the hash value of the data. </param>
		/// <param name="rgbSignature">The signature data to be verified. </param>
		/// <returns>
		///     <see langword="true" /> if the signature verifies as valid; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is <see langword="null" />.-or- The <paramref name="rgbSignature" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The signature cannot be verified. </exception>
		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			return false;
		}

		/// <summary>Verifies the <see cref="T:System.Security.Cryptography.DSA" /> signature for the specified data.</summary>
		/// <param name="rgbHash">The data signed with <paramref name="rgbSignature" />. </param>
		/// <param name="rgbSignature">The signature to be verified for <paramref name="rgbData" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="rgbSignature" /> matches the signature computed using the specified hash algorithm and key on <paramref name="rgbHash" />; otherwise, <see langword="false" />.</returns>
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			return false;
		}

		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void OnKeyGenerated(object sender, EventArgs e)
		{
		}

		/// <summary>Exports a blob containing the key information associated with a <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object.  </summary>
		/// <param name="includePrivateParameters">
		///       <see langword="true" /> to include the private key; otherwise, <see langword="false" />.</param>
		/// <returns>A byte array containing the key information associated with a <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> object.</returns>
		[ComVisible(false)]
		public byte[] ExportCspBlob(bool includePrivateParameters)
		{
			return null;
		}

		/// <summary>Imports a blob that represents DSA key information.</summary>
		/// <param name="keyBlob">A byte array that represents a DSA key blob.</param>
		[ComVisible(false)]
		public void ImportCspBlob(byte[] keyBlob)
		{
		}
	}
}
