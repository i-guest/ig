using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for Web request modules. This class cannot be inherited.</summary>
	public sealed class WebRequestModulesSection : ConfigurationSection
	{
		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Gets the collection of Web request modules in the section.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.WebRequestModuleElementCollection" /> containing the registered Web request modules. </returns>
		public WebRequestModuleElementCollection WebRequestModules => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebRequestModulesSection" /> class.</summary>
		public WebRequestModulesSection()
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
