using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Identifies the configuration settings for Web proxy server. This class cannot be inherited.</summary>
	public sealed class ProxyElement : ConfigurationElement
	{
		/// <summary>Specifies whether the proxy is automatically detected.</summary>
		public enum AutoDetectValues
		{
			/// <summary>The proxy is not automatically detected.</summary>
			False = 0,
			/// <summary>The proxy is automatically detected.</summary>
			True = 1,
			/// <summary>Unspecified.</summary>
			Unspecified = -1
		}

		/// <summary>Specifies whether the proxy is bypassed for local resources.</summary>
		public enum BypassOnLocalValues
		{
			/// <summary>All requests for local resources should go through the proxy</summary>
			False = 0,
			/// <summary>Access local resources directly.</summary>
			True = 1,
			/// <summary>Unspecified.</summary>
			Unspecified = -1
		}

		/// <summary>Specifies whether to use the local system proxy settings to determine whether the proxy is bypassed for local resources.</summary>
		public enum UseSystemDefaultValues
		{
			/// <summary>Do not use system default proxy setting values</summary>
			False = 0,
			/// <summary>Use system default proxy setting values.</summary>
			True = 1,
			/// <summary>The system default proxy setting is unspecified.</summary>
			Unspecified = -1
		}

		/// <summary>Gets or sets an <see cref="T:System.Net.Configuration.ProxyElement.AutoDetectValues" /> value that controls whether the Web proxy is automatically detected.</summary>
		/// <returns>
		///     <see cref="F:System.Net.Configuration.ProxyElement.AutoDetectValues.True" /> if the <see cref="T:System.Net.WebProxy" /> is automatically detected; <see cref="F:System.Net.Configuration.ProxyElement.AutoDetectValues.False" /> if the <see cref="T:System.Net.WebProxy" /> is not automatically detected; or <see cref="F:System.Net.Configuration.ProxyElement.AutoDetectValues.Unspecified" />.</returns>
		public AutoDetectValues AutoDetect
		{
			get
			{
				return default(AutoDetectValues);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value that indicates whether local resources are retrieved by using a Web proxy server.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.ProxyElement.BypassOnLocalValues" />.Avalue that indicates whether local resources are retrieved by using a Web proxy server.</returns>
		public BypassOnLocalValues BypassOnLocal
		{
			get
			{
				return default(BypassOnLocalValues);
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Gets or sets the URI that identifies the Web proxy server to use.</summary>
		/// <returns>A <see cref="T:System.String" /> containing a URI.</returns>
		public Uri ProxyAddress
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets an <see cref="T:System.Uri" /> value that specifies the location of the automatic proxy detection script.</summary>
		/// <returns>A <see cref="T:System.Uri" /> specifying the location of the automatic proxy detection script.</returns>
		public Uri ScriptLocation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that controls whether the Internet Explorer Web proxy settings are used.</summary>
		/// <returns>
		///     <see langword="true" /> if the Internet Explorer LAN settings are used to detect and configure the default <see cref="T:System.Net.WebProxy" /> used for requests; otherwise, <see langword="false" />.</returns>
		public UseSystemDefaultValues UseSystemDefault
		{
			get
			{
				return default(UseSystemDefaultValues);
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ProxyElement" /> class. </summary>
		public ProxyElement()
		{
		}
	}
}
