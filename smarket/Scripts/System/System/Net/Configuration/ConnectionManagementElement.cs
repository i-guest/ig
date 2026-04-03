using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the maximum number of connections to a remote computer. This class cannot be inherited.</summary>
	public sealed class ConnectionManagementElement : ConfigurationElement
	{
		/// <summary>Gets or sets the address for remote computers.</summary>
		/// <returns>A string that contains a regular expression describing an IP address or DNS name.</returns>
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

		/// <summary>Gets or sets the maximum number of connections that can be made to a remote computer.</summary>
		/// <returns>An integer that specifies the maximum number of connections.</returns>
		public int MaxConnection
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

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ConnectionManagementElement" /> class. </summary>
		public ConnectionManagementElement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ConnectionManagementElement" /> class with the specified address and connection limit information.</summary>
		/// <param name="address">A string that identifies the address of a remote computer.</param>
		/// <param name="maxConnection">An integer that identifies the maximum number of connections allowed to <paramref name="address" /> from the local computer.</param>
		public ConnectionManagementElement(string address, int maxConnection)
		{
		}
	}
}
