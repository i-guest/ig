using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for sockets, IPv6, response headers, and service points. This class cannot be inherited.</summary>
	public sealed class SettingsSection : ConfigurationSection
	{
		/// <summary>Gets the configuration element that controls the settings used by an <see cref="T:System.Net.HttpListener" /> object.</summary>
		/// <returns>An <see cref="T:System.Net.Configuration.HttpListenerElement" /> object.The configuration element that controls the settings used by an <see cref="T:System.Net.HttpListener" /> object.</returns>
		public HttpListenerElement HttpListener => null;

		/// <summary>Gets the configuration element that controls the settings used by an <see cref="T:System.Net.HttpWebRequest" /> object.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.HttpWebRequestElement" /> object.The configuration element that controls the maximum response header length and other settings used by an <see cref="T:System.Net.HttpWebRequest" /> object.</returns>
		public HttpWebRequestElement HttpWebRequest => null;

		/// <summary>Gets the configuration element that enables Internet Protocol version 6 (IPv6).</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.Ipv6Element" />.The configuration element that controls setting used by IPv6.</returns>
		public Ipv6Element Ipv6 => null;

		/// <summary>Gets the configuration element that controls whether network performance counters are enabled.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.PerformanceCountersElement" />.The configuration element that controls setting used network performance counters.</returns>
		public PerformanceCountersElement PerformanceCounters => null;

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Gets the configuration element that controls settings for connections to remote host computers.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.ServicePointManagerElement" /> object.The configuration element that that controls setting used network performance counters for connections to remote host computers.</returns>
		public ServicePointManagerElement ServicePointManager => null;

		/// <summary>Gets the configuration element that controls settings for sockets.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.SocketElement" /> object.The configuration element that controls settings for sockets.</returns>
		public SocketElement Socket => null;

		/// <summary>Gets the configuration element that controls the execution timeout and download timeout of Web proxy scripts.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.WebProxyScriptElement" /> object.The configuration element that controls settings for the execution timeout and download timeout used by the Web proxy scripts.</returns>
		public WebProxyScriptElement WebProxyScript => null;

		/// <summary>Gets the configuration element that controls the settings used by an <see cref="T:System.Net.WebUtility" /> object.</summary>
		/// <returns>Returns <see cref="T:System.Net.Configuration.WebUtilityElement" />.The configuration element that controls the settings used by an <see cref="T:System.Net.WebUtility" /> object.</returns>
		public WebUtilityElement WebUtility => null;

		public WindowsAuthenticationElement WindowsAuthentication => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ConnectionManagementSection" /> class. </summary>
		public SettingsSection()
		{
		}
	}
}
