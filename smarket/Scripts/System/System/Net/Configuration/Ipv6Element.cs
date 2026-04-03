using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Determines whether Internet Protocol version 6 is enabled on the local computer. This class cannot be inherited.</summary>
	public sealed class Ipv6Element : ConfigurationElement
	{
		/// <summary>Gets or sets a Boolean value that indicates whether Internet Protocol version 6 is enabled on the local computer.</summary>
		/// <returns>
		///     <see langword="true" /> if IPv6 is enabled; otherwise, <see langword="false" />.</returns>
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

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.Ipv6Element" /> class. </summary>
		public Ipv6Element()
		{
		}
	}
}
