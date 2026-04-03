using System.Configuration;
using System.Net.Security;

namespace System.Net.Configuration
{
	/// <summary>Represents the default settings used to create connections to a remote computer. This class cannot be inherited.</summary>
	public sealed class ServicePointManagerElement : ConfigurationElement
	{
		/// <summary>Gets or sets a Boolean value that controls checking host name information in an X509 certificate.</summary>
		/// <returns>
		///     <see langword="true" /> to specify host name checking; otherwise, <see langword="false" />. </returns>
		public bool CheckCertificateName
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a Boolean value that indicates whether the certificate is checked against the certificate authority revocation list.</summary>
		/// <returns>
		///     <see langword="true" /> if the certificate revocation list is checked; otherwise, <see langword="false" />.The default value is <see langword="false" />.</returns>
		public bool CheckCertificateRevocationList
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the amount of time after which address information is refreshed.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> that specifies when addresses are resolved using DNS.</returns>
		public int DnsRefreshTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a Boolean value that controls using different IP addresses on connections to the same server.</summary>
		/// <returns>
		///     <see langword="true" /> to enable DNS round-robin behavior; otherwise, <see langword="false" />.</returns>
		public bool EnableDnsRoundRobin
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Net.Security.EncryptionPolicy" /> to use.</summary>
		/// <returns>The encryption policy to use for a <see cref="T:System.Net.ServicePointManager" /> instance.</returns>
		public EncryptionPolicy EncryptionPolicy
		{
			get
			{
				return default(EncryptionPolicy);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a Boolean value that determines whether 100-Continue behavior is used.</summary>
		/// <returns>
		///     <see langword="true" /> to expect 100-Continue responses for <see langword="POST" /> requests; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
		public bool Expect100Continue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Gets or sets a Boolean value that determines whether the Nagle algorithm is used.</summary>
		/// <returns>
		///     <see langword="true" /> to use the Nagle algorithm; otherwise, <see langword="false" />. The default value is <see langword="true" />.</returns>
		public bool UseNagleAlgorithm
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ServicePointManagerElement" /> class. </summary>
		public ServicePointManagerElement()
		{
		}

		protected override void PostDeserialize()
		{
		}
	}
}
