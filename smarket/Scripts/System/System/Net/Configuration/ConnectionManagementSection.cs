using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for connection management. This class cannot be inherited.</summary>
	public sealed class ConnectionManagementSection : ConfigurationSection
	{
		/// <summary>Gets the collection of connection management objects in the section.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.ConnectionManagementElementCollection" /> that contains the connection management information for the local computer. </returns>
		public ConnectionManagementElementCollection ConnectionManagement => null;

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ConnectionManagementSection" /> class. </summary>
		public ConnectionManagementSection()
		{
		}
	}
}
