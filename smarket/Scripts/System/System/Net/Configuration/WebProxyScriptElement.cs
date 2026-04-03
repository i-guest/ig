using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents information used to configure Web proxy scripts. This class cannot be inherited.</summary>
	public sealed class WebProxyScriptElement : ConfigurationElement
	{
		public int AutoConfigUrlRetryInterval
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the Web proxy script download timeout using the format hours:minutes:seconds.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> object that contains the timeout value. The default download timeout is one minute.</returns>
		public TimeSpan DownloadTimeout
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Initializes an instance of the <see cref="T:System.Net.Configuration.WebProxyScriptElement" /> class.</summary>
		public WebProxyScriptElement()
		{
		}

		protected override void PostDeserialize()
		{
		}
	}
}
