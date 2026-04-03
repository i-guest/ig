using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Contains information about the properties of a digital signature.</summary>
	[ComVisible(true)]
	public class SignatureDescription
	{
		private string _strKey;

		private string _strDigest;

		private string _strFormatter;

		private string _strDeformatter;

		/// <summary>Gets or sets the key algorithm for the signature description.</summary>
		/// <returns>The key algorithm for the signature description.</returns>
		public string KeyAlgorithm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the digest algorithm for the signature description.</summary>
		/// <returns>The digest algorithm for the signature description.</returns>
		public string DigestAlgorithm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the formatter algorithm for the signature description.</summary>
		/// <returns>The formatter algorithm for the signature description.</returns>
		public string FormatterAlgorithm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the deformatter algorithm for the signature description.</summary>
		/// <returns>The deformatter algorithm for the signature description.</returns>
		public string DeformatterAlgorithm
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SignatureDescription" /> class.</summary>
		public SignatureDescription()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SignatureDescription" /> class from the specified <see cref="T:System.Security.SecurityElement" />.</summary>
		/// <param name="el">The <see cref="T:System.Security.SecurityElement" /> from which to get the algorithms for the signature description. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="el" /> parameter is <see langword="null" />.</exception>
		public SignatureDescription(SecurityElement el)
		{
		}

		/// <summary>Creates an <see cref="T:System.Security.Cryptography.AsymmetricSignatureDeformatter" /> instance with the specified key using the <see cref="P:System.Security.Cryptography.SignatureDescription.DeformatterAlgorithm" /> property.</summary>
		/// <param name="key">The key to use in the <see cref="T:System.Security.Cryptography.AsymmetricSignatureDeformatter" />. </param>
		/// <returns>The newly created <see cref="T:System.Security.Cryptography.AsymmetricSignatureDeformatter" /> instance.</returns>
		public virtual AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
		{
			return null;
		}

		/// <summary>Creates an <see cref="T:System.Security.Cryptography.AsymmetricSignatureFormatter" /> instance with the specified key using the <see cref="P:System.Security.Cryptography.SignatureDescription.FormatterAlgorithm" /> property.</summary>
		/// <param name="key">The key to use in the <see cref="T:System.Security.Cryptography.AsymmetricSignatureFormatter" />. </param>
		/// <returns>The newly created <see cref="T:System.Security.Cryptography.AsymmetricSignatureFormatter" /> instance.</returns>
		public virtual AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
		{
			return null;
		}

		/// <summary>Creates a <see cref="T:System.Security.Cryptography.HashAlgorithm" /> instance using the <see cref="P:System.Security.Cryptography.SignatureDescription.DigestAlgorithm" /> property.</summary>
		/// <returns>The newly created <see cref="T:System.Security.Cryptography.HashAlgorithm" /> instance.</returns>
		public virtual HashAlgorithm CreateDigest()
		{
			return null;
		}
	}
}
