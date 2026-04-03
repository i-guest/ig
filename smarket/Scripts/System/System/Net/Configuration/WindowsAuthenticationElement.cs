using System.Configuration;

namespace System.Net.Configuration
{
	public sealed class WindowsAuthenticationElement : ConfigurationElement
	{
		public int DefaultCredentialsHandleCacheSize
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
	}
}
