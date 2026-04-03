using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	/// <summary>Represents the default FTP cache policy for network resources. This class cannot be inherited.</summary>
	public sealed class FtpCachePolicyElement : ConfigurationElement
	{
		/// <summary>Gets or sets FTP caching behavior for the local machine.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCacheLevel" /> value that specifies the cache behavior.</returns>
		public RequestCacheLevel PolicyLevel
		{
			get
			{
				return default(RequestCacheLevel);
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.FtpCachePolicyElement" /> class.</summary>
		public FtpCachePolicyElement()
		{
		}

		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		protected override void Reset(ConfigurationElement parentElement)
		{
		}
	}
}
