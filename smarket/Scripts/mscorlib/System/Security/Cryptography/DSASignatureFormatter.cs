using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Creates a Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) signature.</summary>
	[ComVisible(true)]
	public class DSASignatureFormatter : AsymmetricSignatureFormatter
	{
		private DSA _dsaKey;

		private string _oid;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSASignatureFormatter" /> class.</summary>
		public DSASignatureFormatter()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSASignatureFormatter" /> class with the specified key.</summary>
		/// <param name="key">The instance of the Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) that holds the key. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		public DSASignatureFormatter(AsymmetricAlgorithm key)
		{
		}

		/// <summary>Specifies the key to be used for the Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) signature formatter.</summary>
		/// <param name="key">The instance of <see cref="T:System.Security.Cryptography.DSA" /> that holds the key. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />.</exception>
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		/// <summary>Specifies the hash algorithm for the Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) signature formatter.</summary>
		/// <param name="strName">The name of the hash algorithm to use for the signature formatter. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The <paramref name="strName" /> parameter does not map to the <see cref="T:System.Security.Cryptography.SHA1" /> hash algorithm. </exception>
		public override void SetHashAlgorithm(string strName)
		{
		}

		/// <summary>Creates the Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) PKCS #1 signature for the specified data.</summary>
		/// <param name="rgbHash">The data to be signed. </param>
		/// <returns>The digital signature for the specified data.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="rgbHash" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">The OID is <see langword="null" />.-or-The DSA key is <see langword="null" />.</exception>
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			return null;
		}
	}
}
