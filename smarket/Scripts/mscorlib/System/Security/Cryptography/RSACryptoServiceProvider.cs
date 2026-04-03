using System.IO;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Performs asymmetric encryption and decryption using the implementation of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm provided by the cryptographic service provider (CSP). This class cannot be inherited.</summary>
	[ComVisible(true)]
	public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm
	{
		private static CspProviderFlags s_UseMachineKeyStore;

		private const int PROV_RSA_FULL = 1;

		private const int AT_KEYEXCHANGE = 1;

		private const int AT_SIGNATURE = 2;

		private KeyPairPersistence store;

		private bool persistKey;

		private bool persisted;

		private bool privateKeyExportable;

		private bool m_disposed;

		private RSAManaged rsa;

		/// <summary>Gets the name of the signature algorithm available with this implementation of <see cref="T:System.Security.Cryptography.RSA" />.</summary>
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

		/// <summary>Gets the name of the key exchange algorithm available with this implementation of <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		/// <returns>The name of the key exchange algorithm if it exists; otherwise, <see langword="null" />.</returns>
		public override string KeyExchangeAlgorithm => null;

		/// <summary>Gets the size of the current key.</summary>
		/// <returns>The size of the key in bits.</returns>
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

		/// <summary>Gets a value that indicates whether the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object contains only a public key.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object contains only a public key; otherwise, <see langword="false" />.</returns>
		[ComVisible(false)]
		public bool PublicOnly => false;

		/// <summary>Gets a <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> object that describes additional information about a cryptographic key pair. </summary>
		/// <returns>A <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" /> object that describes additional information about a cryptographic key pair.</returns>
		[ComVisible(false)]
		public CspKeyContainerInfo CspKeyContainerInfo => null;

		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		private static int GetAlgorithmId(HashAlgorithmName hashAlgorithm)
		{
			return 0;
		}

		/// <summary>Encrypts data with the <see cref="T:System.Security.Cryptography.RSA" /> algorithm using the specified padding. </summary>
		/// <param name="data">The data to encrypt. </param>
		/// <param name="padding">The padding. </param>
		/// <returns>The encrypted data. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="data" /> is <see langword="null" />. -or-
		///         <paramref name="padding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The padding mode is not supported.</exception>
		public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		/// <summary>Decrypts data that was previously encrypted with the <see cref="T:System.Security.Cryptography.RSA" /> algorithm by using the specified padding. </summary>
		/// <param name="data">The data to decrypt. </param>
		/// <param name="padding">The padding. </param>
		/// <returns>The decrypted data. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="data" /> is <see langword="null" />. -or-
		///         <paramref name="padding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The padding mode is not supported.</exception>
		public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		/// <summary>Computes the signature for the specified hash value by encrypting it with the private key using the specified padding. </summary>
		/// <param name="hash">The hash value of the data to be signed. </param>
		/// <param name="hashAlgorithm">The hash algorithm name used to create the hash value of the data. </param>
		/// <param name="padding">The padding. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.RSA" /> signature for the specified hash value. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hashAlgorithm" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="hash" /> is <see langword="null" />. -or-
		///         <paramref name="padding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///         <paramref name="padding" /> does not equal <see cref="P:System.Security.Cryptography.RSASignaturePadding.Pkcs1" />. </exception>
		public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		/// <summary>Verifies that a digital signature is valid by determining the hash value in the signature using the specified hashing algorithm and padding, and comparing it to the provided hash value. </summary>
		/// <param name="hash">The hash value of the signed data. </param>
		/// <param name="signature">The signature data to be verified. </param>
		/// <param name="hashAlgorithm">The hash algorithm name used to create the hash value. </param>
		/// <param name="padding">The padding. </param>
		/// <returns>
		///     <see langword="true" /> if the signature is valid; otherwise, <see langword="false" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hashAlgorithm" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="hash" /> is <see langword="null" />. -or-
		///         <paramref name="padding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///         <paramref name="padding" /> does not equal <see cref="P:System.Security.Cryptography.RSASignaturePadding.Pkcs1" />. </exception>
		public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		private static Exception PaddingModeNotSupported()
		{
			return null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class using the default key.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired. </exception>
		public RSACryptoServiceProvider()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified parameters.</summary>
		/// <param name="parameters">The parameters to be passed to the cryptographic service provider (CSP). </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired. </exception>
		public RSACryptoServiceProvider(CspParameters parameters)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified key size.</summary>
		/// <param name="dwKeySize">The size of the key to use in bits. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired. </exception>
		public RSACryptoServiceProvider(int dwKeySize)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> class with the specified key size and parameters.</summary>
		/// <param name="dwKeySize">The size of the key to use in bits. </param>
		/// <param name="parameters">The parameters to be passed to the cryptographic service provider (CSP). </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The CSP cannot be acquired.-or- The key cannot be created. </exception>
		public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
		}

		private void Common(int dwKeySize, bool parameters)
		{
		}

		private void Common(CspParameters p)
		{
		}

		~RSACryptoServiceProvider()
		{
		}

		/// <summary>Decrypts data with the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		/// <param name="rgb">The data to be decrypted. </param>
		/// <param name="fOAEP">
		///       <see langword="true" /> to perform direct <see cref="T:System.Security.Cryptography.RSA" /> decryption using OAEP padding (only available on a computer running Microsoft Windows XP or later); otherwise, <see langword="false" /> to use PKCS#1 v1.5 padding. </param>
		/// <returns>The decrypted data, which is the original plain text before encryption.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="fOAEP" /> parameter is <see langword="true" /> and the length of the <paramref name="rgb" /> parameter is greater than <see cref="P:System.Security.Cryptography.RSACryptoServiceProvider.KeySize" />.-or- The <paramref name="fOAEP" /> parameter is <see langword="true" /> and OAEP is not supported. -or- The key does not match the encrypted data. However, the exception wording may not be accurate. For example, it may say Not enough storage is available to process this command.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="rgb " />is <see langword="null" />.</exception>
		public byte[] Decrypt(byte[] rgb, bool fOAEP)
		{
			return null;
		}

		/// <summary>This method is not supported in the current version.</summary>
		/// <param name="rgb">The data to be decrypted. </param>
		/// <returns>The decrypted data, which is the original plain text before encryption.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported in the current version. </exception>
		public override byte[] DecryptValue(byte[] rgb)
		{
			return null;
		}

		/// <summary>Encrypts data with the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		/// <param name="rgb">The data to be encrypted. </param>
		/// <param name="fOAEP">
		///       <see langword="true" /> to perform direct <see cref="T:System.Security.Cryptography.RSA" /> encryption using OAEP padding (only available on a computer running Windows XP or later); otherwise, <see langword="false" /> to use PKCS#1 v1.5 padding. </param>
		/// <returns>The encrypted data.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The length of the <paramref name="rgb" /> parameter is greater than the maximum allowed length.-or- The <paramref name="fOAEP" /> parameter is <see langword="true" /> and OAEP padding is not supported. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="rgb " />is <see langword="null" />.</exception>
		public byte[] Encrypt(byte[] rgb, bool fOAEP)
		{
			return null;
		}

		/// <summary>This method is not supported in the current version.</summary>
		/// <param name="rgb">The data to be encrypted. </param>
		/// <returns>The encrypted data.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported in the current version. </exception>
		public override byte[] EncryptValue(byte[] rgb)
		{
			return null;
		}

		/// <summary>Exports the <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
		/// <param name="includePrivateParameters">
		///       <see langword="true" /> to include private parameters; otherwise, <see langword="false" />. </param>
		/// <returns>The parameters for <see cref="T:System.Security.Cryptography.RSA" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The key cannot be exported. </exception>
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			return default(RSAParameters);
		}

		/// <summary>Imports the specified <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
		/// <param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.RSA" />. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="parameters" /> parameter has missing fields. </exception>
		public override void ImportParameters(RSAParameters parameters)
		{
		}

		private HashAlgorithm GetHash(object halg)
		{
			return null;
		}

		private HashAlgorithm GetHashFromString(string name)
		{
			return null;
		}

		/// <summary>Computes the hash value of the specified byte array using the specified hash algorithm, and signs the resulting hash value.</summary>
		/// <param name="buffer">The input data for which to compute the hash. </param>
		/// <param name="halg">The hash algorithm to use to create the hash value. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.RSA" /> signature for the specified data.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="halg" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="halg" /> parameter is not a valid type. </exception>
		public byte[] SignData(byte[] buffer, object halg)
		{
			return null;
		}

		/// <summary>Computes the hash value of the specified input stream using the specified hash algorithm, and signs the resulting hash value.</summary>
		/// <param name="inputStream">The input data for which to compute the hash. </param>
		/// <param name="halg">The hash algorithm to use to create the hash value. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.RSA" /> signature for the specified data.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="halg" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="halg" /> parameter is not a valid type. </exception>
		public byte[] SignData(Stream inputStream, object halg)
		{
			return null;
		}

		/// <summary>Computes the hash value of a subset of the specified byte array using the specified hash algorithm, and signs the resulting hash value.</summary>
		/// <param name="buffer">The input data for which to compute the hash. </param>
		/// <param name="offset">The offset into the array from which to begin using data. </param>
		/// <param name="count">The number of bytes in the array to use as data. </param>
		/// <param name="halg">The hash algorithm to use to create the hash value. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.RSA" /> signature for the specified data.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="halg" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="halg" /> parameter is not a valid type. </exception>
		public byte[] SignData(byte[] buffer, int offset, int count, object halg)
		{
			return null;
		}

		private string GetHashNameFromOID(string oid)
		{
			return null;
		}

		/// <summary>Computes the signature for the specified hash value by encrypting it with the private key.</summary>
		/// <param name="rgbHash">The hash value of the data to be signed. </param>
		/// <param name="str">The hash algorithm identifier (OID) used to create the hash value of the data. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.RSA" /> signature for the specified hash value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- There is no private key. </exception>
		public byte[] SignHash(byte[] rgbHash, string str)
		{
			return null;
		}

		private byte[] SignHash(byte[] rgbHash, int calgHash)
		{
			return null;
		}

		private static HashAlgorithm InternalHashToHashAlgorithm(int calgHash)
		{
			return null;
		}

		/// <summary>Verifies that a digital signature is valid by determining the hash value in the signature using the provided public key and comparing it to the hash value of the provided data.</summary>
		/// <param name="buffer">The data that was signed. </param>
		/// <param name="halg">The name of the hash algorithm used to create the hash value of the data. </param>
		/// <param name="signature">The signature data to be verified. </param>
		/// <returns>
		///     <see langword="true" /> if the signature is valid; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="halg" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="halg" /> parameter is not a valid type. </exception>
		public bool VerifyData(byte[] buffer, object halg, byte[] signature)
		{
			return false;
		}

		/// <summary>Verifies that a digital signature is valid by determining the hash value in the signature using the provided public key and comparing it to the provided hash value.</summary>
		/// <param name="rgbHash">The hash value of the signed data. </param>
		/// <param name="str">The hash algorithm identifier (OID) used to create the hash value of the data. </param>
		/// <param name="rgbSignature">The signature data to be verified. </param>
		/// <returns>
		///     <see langword="true" /> if the signature is valid; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="rgbHash" /> parameter is <see langword="null" />.-or- The <paramref name="rgbSignature" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The cryptographic service provider (CSP) cannot be acquired.-or- The signature cannot be verified. </exception>
		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			return false;
		}

		private bool VerifyHash(byte[] rgbHash, int calgHash, byte[] rgbSignature)
		{
			return false;
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void OnKeyGenerated(object sender, EventArgs e)
		{
		}

		/// <summary>Exports a blob containing the key information associated with an <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object.  </summary>
		/// <param name="includePrivateParameters">
		///       <see langword="true" /> to include the private key; otherwise, <see langword="false" />.</param>
		/// <returns>A byte array containing the key information associated with an <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> object.</returns>
		[ComVisible(false)]
		public byte[] ExportCspBlob(bool includePrivateParameters)
		{
			return null;
		}

		/// <summary>Imports a blob that represents RSA key information.  </summary>
		/// <param name="keyBlob">A byte array that represents an RSA key blob.</param>
		[ComVisible(false)]
		public void ImportCspBlob(byte[] keyBlob)
		{
		}
	}
}
