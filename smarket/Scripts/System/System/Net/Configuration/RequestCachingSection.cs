using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for cache behavior. This class cannot be inherited.</summary>
	public sealed class RequestCachingSection : ConfigurationSection
	{
		/// <summary>Gets the default FTP caching behavior for the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.FtpCachePolicyElement" /> that defines the default cache policy.</returns>
		public FtpCachePolicyElement DefaultFtpCachePolicy => null;

		/// <summary>Gets the default caching behavior for the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.HttpCachePolicyElement" /> that defines the default cache policy.</returns>
		public HttpCachePolicyElement DefaultHttpCachePolicy => null;

		/// <summary>Gets or sets the default cache policy level.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCacheLevel" /> enumeration value.</returns>
		public RequestCacheLevel DefaultPolicyLevel
		{
			get
			{
				return default(RequestCacheLevel);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a Boolean value that enables caching on the local computer.</summary>
		/// <returns>
		///     <see langword="true" /> if caching is disabled on the local computer; otherwise, <see langword="false" />.</returns>
		public bool DisableAllCaching
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a Boolean value that indicates whether the local computer cache is private.</summary>
		/// <returns>
		///     <see langword="true" /> if the cache provides user isolation; otherwise, <see langword="false" />.</returns>
		public bool IsPrivateCache
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

		/// <summary>Gets or sets a value used as the maximum age for cached resources that do not have expiration information.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> that provides a default maximum age for cached resources.</returns>
		public TimeSpan UnspecifiedMaximumAge
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.RequestCachingSection" /> class. </summary>
		public RequestCachingSection()
		{
		}

		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		protected override void PostDeserialize()
		{
		}
	}
}
