using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for authentication modules. This class cannot be inherited.</summary>
	public sealed class AuthenticationModulesSection : ConfigurationSection
	{
		/// <summary>Gets the collection of authentication modules in the section.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.AuthenticationModuleElementCollection" /> that contains the registered authentication modules. </returns>
		public AuthenticationModuleElementCollection AuthenticationModules => null;

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.AuthenticationModulesSection" /> class. </summary>
		public AuthenticationModulesSection()
		{
		}

		protected override void InitializeDefault()
		{
		}

		protected override void PostDeserialize()
		{
		}
	}
}
