using System.IO;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the base class from which all implementations of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm inherit.</summary>
	[ComVisible(true)]
	public abstract class RSA : AsymmetricAlgorithm
	{
		/// <summary>Gets the name of the key exchange algorithm available with this implementation of <see cref="T:System.Security.Cryptography.RSA" />. </summary>
		/// <returns>Returns "RSA". </returns>
		public override string KeyExchangeAlgorithm => null;

		/// <summary>Gets the name of the signature algorithm available with this implementation of <see cref="T:System.Security.Cryptography.RSA" />. </summary>
		/// <returns>Returns "RSA". </returns>
		public override string SignatureAlgorithm => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.RSA" /> class.</summary>
		protected RSA()
		{
		}

		/// <summary>Creates an instance of the default implementation of the <see cref="T:System.Security.Cryptography.RSA" /> algorithm.</summary>
		/// <returns>A new instance of the default implementation of <see cref="T:System.Security.Cryptography.RSA" />.</returns>
		public new static RSA Create()
		{
			return null;
		}

		/// <summary>Creates an instance of the specified implementation of <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		/// <param name="algName">The name of the implementation of <see cref="T:System.Security.Cryptography.RSA" /> to use. </param>
		/// <returns>A new instance of the specified implementation of <see cref="T:System.Security.Cryptography.RSA" />.</returns>
		public new static RSA Create(string algName)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, encrypts the input data using the specified padding mode. </summary>
		/// <param name="data">The data to encrypt. </param>
		/// <param name="padding">The padding mode. </param>
		/// <returns>The encrypted data. </returns>
		/// <exception cref="T:System.NotImplementedException">A derived class must override this method. </exception>
		public virtual byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, decrypts the input data using the specified padding mode. </summary>
		/// <param name="data">The data to decrypt. </param>
		/// <param name="padding">The padding mode. </param>
		/// <returns>The decrypted data. </returns>
		/// <exception cref="T:System.NotImplementedException">A derived class must override this method. </exception>
		public virtual byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, computes the signature for the specified hash value by encrypting it with the private key using the specified padding. </summary>
		/// <param name="hash">The hash value of the data to be signed. </param>
		/// <param name="hashAlgorithm">The hash algorithm used to create the hash value of the data. </param>
		/// <param name="padding">The padding. </param>
		/// <returns>The RSA signature for the specified hash value. </returns>
		/// <exception cref="T:System.NotImplementedException">A derived class must override this method. </exception>
		public virtual byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		/// <summary>Verifies that a digital signature is valid by determining the hash value in the signature using the specified hash algorithm and padding, and comparing it to the provided hash value. </summary>
		/// <param name="hash">The hash value of the signed data. </param>
		/// <param name="signature">The signature data to be verified. </param>
		/// <param name="hashAlgorithm">The hash algorithm used to create the hash value. </param>
		/// <param name="padding">The padding mode. </param>
		/// <returns>
		///     <see langword="true" /> if the signature is valid; otherwise, <see langword="false" />. </returns>
		/// <exception cref="T:System.NotImplementedException">A derived class must override this method. </exception>
		public virtual bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		/// <summary>When overridden in a derived class, computes the hash value of a specified portion of a byte array by using a specified hashing algorithm. </summary>
		/// <param name="data">The data to be hashed. </param>
		/// <param name="offset">The index of the first byte in <paramref name="data" /> that is to be hashed.  </param>
		/// <param name="count">The number of bytes to hash. </param>
		/// <param name="hashAlgorithm">The algorithm to use in hash the data. </param>
		/// <returns>The hashed data. </returns>
		/// <exception cref="T:System.NotImplementedException">A derived class must override this method. </exception>
		protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, computes the hash value of a specified binary stream by using a specified hashing algorithm.</summary>
		/// <param name="data">The binary stream to hash. </param>
		/// <param name="hashAlgorithm">The hash algorithm. </param>
		/// <returns>The hashed data. </returns>
		/// <exception cref="T:System.NotImplementedException">A derived class must override this method. </exception>
		protected virtual byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		/// <summary>Computes the hash value of the specified byte array using the specified hash algorithm and padding mode, and signs the resulting hash value. </summary>
		/// <param name="data">The input data for which to compute the hash. </param>
		/// <param name="hashAlgorithm">The hash algorithm to use to create the hash value. </param>
		/// <param name="padding">The padding mode. </param>
		/// <returns>The RSA signature for the specified data. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="data" /> is <see langword="null" />. -or-
		///         <paramref name="padding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />. </exception>
		public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		/// <summary>Computes the hash value of a portion of the specified byte array using the specified hash algorithm and padding mode, and signs the resulting hash value. </summary>
		/// <param name="data">The input data for which to compute the hash. </param>
		/// <param name="offset">The offset into the array at which to begin using data. </param>
		/// <param name="count">The number of bytes in the array to use as data. </param>
		/// <param name="hashAlgorithm">The hash algorithm to use to create the hash value. </param>
		/// <param name="padding">The padding mode. </param>
		/// <returns>The RSA signature for the specified data. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="data" /> is <see langword="null" />. -or-
		///         <paramref name="padding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than zero. -or-
		///         <paramref name="count" /> is less than zero. -or-
		///         <paramref name="offset" /> + <paramref name="count" /> – 1 results in an index that is beyond the upper bound of <paramref name="data" />.  </exception>
		public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		/// <summary>Computes the hash value of the specified stream using the specified hash algorithm and padding mode, and signs the resulting hash value.</summary>
		/// <param name="data">The input stream for which to compute the hash. </param>
		/// <param name="hashAlgorithm">The hash algorithm to use to create the hash value. </param>
		/// <param name="padding">The padding mode. </param>
		/// <returns>The RSA signature for the specified data. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="data" /> is <see langword="null" />. -or-
		///         <paramref name="padding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />. </exception>
		public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		/// <summary>Verifies that a digital signature is valid by calculating the hash value of the specified data using the specified hash algorithm and padding, and comparing it to the provided signature. </summary>
		/// <param name="data">The signed data. </param>
		/// <param name="signature">The signature data to be verified. </param>
		/// <param name="hashAlgorithm">The hash algorithm used to create the hash value of the data. </param>
		/// <param name="padding">The padding mode. </param>
		/// <returns>
		///     <see langword="true" /> if the signature is valid; otherwise, <see langword="false" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="data" /> is <see langword="null" />. -or-
		///         <paramref name="signature" /> is <see langword="null" />.-or-
		///         <paramref name="padding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />. </exception>
		public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		/// <summary>Verifies that a digital signature is valid by calculating the hash value of the data in a portion of a byte array using the specified hash algorithm and padding, and comparing it to the provided signature. </summary>
		/// <param name="data">The signed data. </param>
		/// <param name="offset">The starting index at which to compute the hash. </param>
		/// <param name="count">The number of bytes to hash. </param>
		/// <param name="signature">The signature data to be verified. </param>
		/// <param name="hashAlgorithm">The hash algorithm used to create the hash value of the data. </param>
		/// <param name="padding">The padding mode. </param>
		/// <returns>
		///     <see langword="true" /> if the signature is valid; otherwise, <see langword="false" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="data" /> is <see langword="null" />. -or-
		///         <paramref name="signature" /> is <see langword="null" />.-or-
		///         <paramref name="padding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is less than zero. -or-
		///         <paramref name="count" /> is less than zero.-or-
		///         <paramref name="offset" /> + <paramref name="count" /> – 1 results in an index that is beyond the upper bound of <paramref name="data" />.  </exception>
		public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		/// <summary>Verifies that a digital signature is valid by calculating the hash value of the specified stream using the specified hash algorithm and padding, and comparing it to the provided signature. </summary>
		/// <param name="data">The signed data. </param>
		/// <param name="signature">The signature data to be verified. </param>
		/// <param name="hashAlgorithm">The hash algorithm used to create the hash value of the data. </param>
		/// <param name="padding">The padding mode. </param>
		/// <returns>
		///     <see langword="true" /> if the signature is valid; otherwise, <see langword="false" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="data" /> is <see langword="null" />. -or-
		///         <paramref name="signature" /> is <see langword="null" />.-or-
		///         <paramref name="padding" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="hashAlgorithm" />.<see cref="P:System.Security.Cryptography.HashAlgorithmName.Name" /> is <see langword="null" /> or <see cref="F:System.String.Empty" />. </exception>
		public bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		private static Exception DerivedClassMustOverride()
		{
			return null;
		}

		internal static Exception HashAlgorithmNameNullOrEmpty()
		{
			return null;
		}

		/// <summary>When overridden in a derived class, decrypts the input data using the private key.</summary>
		/// <param name="rgb">The cipher text to be decrypted. </param>
		/// <returns>The resulting decryption of the <paramref name="rgb" /> parameter in plain text.</returns>
		/// <exception cref="T:System.NotSupportedException">This method call is not supported. This exception is thrown starting with the .NET Framework 4.6. </exception>
		public virtual byte[] DecryptValue(byte[] rgb)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, encrypts the input data using the public key.</summary>
		/// <param name="rgb">The plain text to be encrypted. </param>
		/// <returns>The resulting encryption of the <paramref name="rgb" /> parameter as cipher text.</returns>
		/// <exception cref="T:System.NotSupportedException">This method call is not supported. This exception is thrown starting with the .NET Framework 4.6. </exception>
		public virtual byte[] EncryptValue(byte[] rgb)
		{
			return null;
		}

		/// <summary>Initializes an <see cref="T:System.Security.Cryptography.RSA" /> object from the key information from an XML string.</summary>
		/// <param name="xmlString">The XML string containing <see cref="T:System.Security.Cryptography.RSA" /> key information. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="xmlString" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The format of the <paramref name="xmlString" /> parameter is not valid. </exception>
		public override void FromXmlString(string xmlString)
		{
		}

		/// <summary>Creates and returns an XML string containing the key of the current <see cref="T:System.Security.Cryptography.RSA" /> object.</summary>
		/// <param name="includePrivateParameters">
		///       <see langword="true" /> to include a public and private RSA key; <see langword="false" /> to include only the public key. </param>
		/// <returns>An XML string containing the key of the current <see cref="T:System.Security.Cryptography.RSA" /> object.</returns>
		public override string ToXmlString(bool includePrivateParameters)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, exports the <see cref="T:System.Security.Cryptography.RSAParameters" />. </summary>
		/// <param name="includePrivateParameters">
		///       <see langword="true" /> to include private parameters; otherwise, <see langword="false" />. </param>
		/// <returns>The parameters for <see cref="T:System.Security.Cryptography.DSA" />.</returns>
		public abstract RSAParameters ExportParameters(bool includePrivateParameters);

		/// <summary>When overridden in a derived class, imports the specified <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
		/// <param name="parameters">The parameters for <see cref="T:System.Security.Cryptography.RSA" />. </param>
		public abstract void ImportParameters(RSAParameters parameters);

		public static RSA Create(int keySizeInBits)
		{
			return null;
		}

		public static RSA Create(RSAParameters parameters)
		{
			return null;
		}

		public virtual bool TryDecrypt(ReadOnlySpan<byte> data, Span<byte> destination, RSAEncryptionPadding padding, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TryEncrypt(ReadOnlySpan<byte> data, Span<byte> destination, RSAEncryptionPadding padding, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		protected virtual bool TryHashData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TrySignHash(ReadOnlySpan<byte> hash, Span<byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TrySignData(ReadOnlySpan<byte> data, Span<byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool VerifyData(ReadOnlySpan<byte> data, ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		public virtual bool VerifyHash(ReadOnlySpan<byte> hash, ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return false;
		}

		public virtual byte[] ExportRSAPrivateKey()
		{
			return null;
		}

		public virtual byte[] ExportRSAPublicKey()
		{
			return null;
		}

		public virtual void ImportRSAPrivateKey(ReadOnlySpan<byte> source, out int bytesRead)
		{
			bytesRead = default(int);
		}

		public virtual void ImportRSAPublicKey(ReadOnlySpan<byte> source, out int bytesRead)
		{
			bytesRead = default(int);
		}

		public virtual bool TryExportRSAPrivateKey(Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}

		public virtual bool TryExportRSAPublicKey(Span<byte> destination, out int bytesWritten)
		{
			bytesWritten = default(int);
			return false;
		}
	}
}
