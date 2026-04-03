using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for Web proxy server usage. This class cannot be inherited.</summary>
	public sealed class DefaultProxySection : ConfigurationSection
	{
		/// <summary>Gets the collection of resources that are not obtained using the Web proxy server.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.BypassElementCollection" /> that contains the addresses of resources that bypass the Web proxy server. </returns>
		public BypassElementCollection BypassList => null;

		/// <summary>Gets or sets whether a Web proxy is used.</summary>
		/// <returns>
		///     <see langword="true" /> if a Web proxy will be used; otherwise, <see langword="false" />.</returns>
		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets the type information for a custom Web proxy implementation.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.ModuleElement" />. The type information for a custom Web proxy implementation.</returns>
		public ModuleElement Module => null;

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Gets the URI that identifies the Web proxy server to use.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.ProxyElement" />. The URI that identifies the Web proxy server.</returns>
		public ProxyElement Proxy => null;

		/// <summary>Gets or sets whether default credentials are to be used to access a Web proxy server.</summary>
		/// <returns>
		///     <see langword="true" /> if default credentials are to be used; otherwise, <see langword="false" />.</returns>
		public bool UseDefaultCredentials
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.DefaultProxySection" /> class. </summary>
		public DefaultProxySection()
		{
		}

		protected override void PostDeserialize()
		{
		}

		protected override void Reset(ConfigurationElement parentElement)
		{
		}
	}
}
