using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the network element in the SMTP configuration file. This class cannot be inherited.</summary>
	public sealed class SmtpNetworkElement : ConfigurationElement
	{
		/// <summary>Gets or sets the client domain name used in the initial SMTP protocol request to connect to an SMTP mail server.</summary>
		/// <returns>A string that represents the client domain name used in the initial SMTP protocol request to connect to an SMTP mail server.</returns>
		public string ClientDomain
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Determines whether or not default user credentials are used to access an SMTP server. The default value is <see langword="false" />.</summary>
		/// <returns>
		///     <see langword="true" /> indicates that default user credentials will be used to access the SMTP server; otherwise, <see langword="false" />.</returns>
		public bool DefaultCredentials
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets whether SSL is used to access an SMTP mail server. The default value is <see langword="false" />.</summary>
		/// <returns>
		///     <see langword="true" /> indicates that SSL will be used to access the SMTP mail server; otherwise, <see langword="false" />.</returns>
		public bool EnableSsl
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the name of the SMTP server.</summary>
		/// <returns>A string that represents the name of the SMTP server to connect to.</returns>
		public string Host
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the user password to use to connect to an SMTP mail server.</summary>
		/// <returns>A string that represents the password to use to connect to an SMTP mail server.</returns>
		public string Password
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the port that SMTP clients use to connect to an SMTP mail server. The default value is 25.</summary>
		/// <returns>A string that represents the port to connect to an SMTP mail server.</returns>
		public int Port
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Gets or sets the Service Provider Name (SPN) to use for authentication when using extended protection to connect to an SMTP mail server.</summary>
		/// <returns>A string that represents the SPN to use for authentication when using extended protection to connect to an SMTP mail server.</returns>
		public string TargetName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the user name to connect to an SMTP mail server.</summary>
		/// <returns>A string that represents the user name to connect to an SMTP mail server.</returns>
		public string UserName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.SmtpNetworkElement" /> class.</summary>
		public SmtpNetworkElement()
		{
		}

		protected override void PostDeserialize()
		{
		}
	}
}
