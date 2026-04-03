using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the address information for resources that are not retrieved using a proxy server. This class cannot be inherited.</summary>
	public sealed class BypassElement : ConfigurationElement
	{
		/// <summary>Gets or sets the addresses of resources that bypass the proxy server.</summary>
		/// <returns>A string that identifies a resource.</returns>
		public string Address
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.BypassElement" /> class. </summary>
		public BypassElement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.BypassElement" /> class with the specified type information.</summary>
		/// <param name="address">A string that identifies the address of a resource.</param>
		public BypassElement(string address)
		{
		}
	}
}
