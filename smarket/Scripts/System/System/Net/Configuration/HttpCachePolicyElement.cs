using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	/// <summary>Represents the default HTTP cache policy for network resources. This class cannot be inherited.</summary>
	public sealed class HttpCachePolicyElement : ConfigurationElement
	{
		/// <summary>Gets or sets the maximum age permitted for a resource returned from the cache.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> value that specifies the maximum age for cached resources specified in the configuration file.</returns>
		public TimeSpan MaximumAge
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the maximum staleness value permitted for a resource returned from the cache.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> value that is set to the maximum staleness value specified in the configuration file.</returns>
		public TimeSpan MaximumStale
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the minimum freshness permitted for a resource returned from the cache.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> value that specifies the minimum freshness specified in the configuration file.</returns>
		public TimeSpan MinimumFresh
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets HTTP caching behavior for the local machine.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.HttpRequestCacheLevel" /> value that specifies the cache behavior.</returns>
		public HttpRequestCacheLevel PolicyLevel
		{
			get
			{
				return default(HttpRequestCacheLevel);
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.HttpCachePolicyElement" /> class. </summary>
		public HttpCachePolicyElement()
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
