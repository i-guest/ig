using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Gets the section group information for the networking namespaces. This class cannot be inherited.</summary>
	public sealed class NetSectionGroup : ConfigurationSectionGroup
	{
		/// <summary>Gets the configuration section containing the authentication modules registered for the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.AuthenticationModulesSection" /> object.</returns>
		public AuthenticationModulesSection AuthenticationModules => null;

		/// <summary>Gets the configuration section containing the connection management settings for the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.ConnectionManagementSection" /> object.</returns>
		public ConnectionManagementSection ConnectionManagement => null;

		/// <summary>Gets the configuration section containing the default Web proxy server settings for the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.DefaultProxySection" /> object.</returns>
		public DefaultProxySection DefaultProxy => null;

		/// <summary>Gets the configuration section containing the SMTP client e-mail settings for the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.MailSettingsSectionGroup" /> object.</returns>
		public MailSettingsSectionGroup MailSettings => null;

		/// <summary>Gets the configuration section containing the cache configuration settings for the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.RequestCachingSection" /> object.</returns>
		public RequestCachingSection RequestCaching => null;

		/// <summary>Gets the configuration section containing the network settings for the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.SettingsSection" /> object.</returns>
		public SettingsSection Settings => null;

		/// <summary>Gets the configuration section containing the modules registered for use with the <see cref="T:System.Net.WebRequest" /> class.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.WebRequestModulesSection" /> object.</returns>
		public WebRequestModulesSection WebRequestModules => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.NetSectionGroup" /> class. </summary>
		public NetSectionGroup()
		{
		}

		/// <summary>Gets the <see langword="System.Net" /> configuration section group from the specified configuration file.</summary>
		/// <param name="config">A <see cref="T:System.Configuration.Configuration" /> that represents a configuration file.</param>
		/// <returns>A <see cref="T:System.Net.Configuration.NetSectionGroup" /> that represents the <see langword="System.Net" /> settings in <paramref name="config" />.</returns>
		public static NetSectionGroup GetSectionGroup(System.Configuration.Configuration config)
		{
			return null;
		}
	}
}
