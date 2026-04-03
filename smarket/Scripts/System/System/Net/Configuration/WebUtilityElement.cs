using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the WebUtility element in the configuration file.</summary>
	public sealed class WebUtilityElement : ConfigurationElement
	{
		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Gets the default Unicode decoding conformance behavior used for an <see cref="T:System.Net.WebUtility" /> object.</summary>
		/// <returns>Returns <see cref="T:System.Net.Configuration.UnicodeDecodingConformance" />.The default Unicode decoding behavior.</returns>
		public UnicodeDecodingConformance UnicodeDecodingConformance
		{
			get
			{
				return default(UnicodeDecodingConformance);
			}
			set
			{
			}
		}

		/// <summary>Gets the default Unicode encoding conformance behavior used for an <see cref="T:System.Net.WebUtility" /> object.</summary>
		/// <returns>Returns <see cref="T:System.Net.Configuration.UnicodeEncodingConformance" />.The default Unicode encoding behavior.</returns>
		public UnicodeEncodingConformance UnicodeEncodingConformance
		{
			get
			{
				return default(UnicodeEncodingConformance);
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebUtilityElement" /> class.</summary>
		public WebUtilityElement()
		{
		}
	}
}
