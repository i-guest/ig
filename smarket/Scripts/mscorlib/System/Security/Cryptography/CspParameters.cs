using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Security.Cryptography
{
	/// <summary>Contains parameters that are passed to the cryptographic service provider (CSP) that performs cryptographic computations. This class cannot be inherited.</summary>
	[ComVisible(true)]
	public sealed class CspParameters
	{
		/// <summary>Represents the provider type code for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
		public int ProviderType;

		/// <summary>Represents the provider name for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
		public string ProviderName;

		/// <summary>Represents the key container name for <see cref="T:System.Security.Cryptography.CspParameters" />.</summary>
		public string KeyContainerName;

		/// <summary>Specifies whether an asymmetric key is created as a signature key or an exchange key.</summary>
		public int KeyNumber;

		private int m_flags;

		private CryptoKeySecurity m_cryptoKeySecurity;

		private SecureString m_keyPassword;

		private IntPtr m_parentWindowHandle;

		/// <summary>Represents the flags for <see cref="T:System.Security.Cryptography.CspParameters" /> that modify the behavior of the cryptographic service provider (CSP).</summary>
		/// <returns>An enumeration value, or a bitwise combination of enumeration values.</returns>
		/// <exception cref="T:System.ArgumentException">Value is not a valid enumeration value.</exception>
		public CspProviderFlags Flags
		{
			get
			{
				return default(CspProviderFlags);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object that represents access rights and audit rules for a container. </summary>
		/// <returns>A <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> object that represents access rights and audit rules for a container.</returns>
		public CryptoKeySecurity CryptoKeySecurity
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a password associated with a smart card key. </summary>
		/// <returns>A password associated with a smart card key.</returns>
		public SecureString KeyPassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a handle to the unmanaged parent window for a smart card password dialog box.</summary>
		/// <returns>A handle to the parent window for a smart card password dialog box.</returns>
		public IntPtr ParentWindowHandle
		{
			get
			{
				return (IntPtr)0;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class.</summary>
		public CspParameters()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class with the specified provider type code.</summary>
		/// <param name="dwTypeIn">A provider type code that specifies the kind of provider to create. </param>
		public CspParameters(int dwTypeIn)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class with the specified provider type code and name.</summary>
		/// <param name="dwTypeIn">A provider type code that specifies the kind of provider to create.</param>
		/// <param name="strProviderNameIn">A provider name. </param>
		public CspParameters(int dwTypeIn, string strProviderNameIn)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class with the specified provider type code and name, and the specified container name.</summary>
		/// <param name="dwTypeIn">The provider type code that specifies the kind of provider to create.</param>
		/// <param name="strProviderNameIn">A provider name. </param>
		/// <param name="strContainerNameIn">A container name. </param>
		public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class using a provider type, a provider name, a container name, access information, and a password associated with a smart card key.</summary>
		/// <param name="providerType">The provider type code that specifies the kind of provider to create.</param>
		/// <param name="providerName">A provider name. </param>
		/// <param name="keyContainerName">A container name. </param>
		/// <param name="cryptoKeySecurity">An object that represents access rights and audit rules for a container. </param>
		/// <param name="keyPassword">A password associated with a smart card key.</param>
		public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, SecureString keyPassword)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CspParameters" /> class using a provider type, a provider name, a container name, access information, and a handle to an unmanaged smart card password dialog. </summary>
		/// <param name="providerType">The provider type code that specifies the kind of provider to create.</param>
		/// <param name="providerName">A provider name. </param>
		/// <param name="keyContainerName">A container name. </param>
		/// <param name="cryptoKeySecurity">An object that represents access rights and audit rules for the container.</param>
		/// <param name="parentWindowHandle">A handle to the parent window for a smart card password dialog.</param>
		public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, IntPtr parentWindowHandle)
		{
		}

		internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
		{
		}

		internal CspParameters(CspParameters parameters)
		{
		}
	}
}
