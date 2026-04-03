using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the type information for a custom <see cref="T:System.Net.IWebProxy" /> module. This class cannot be inherited.</summary>
	public sealed class ModuleElement : ConfigurationElement
	{
		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Gets or sets the type and assembly information for the current instance.</summary>
		/// <returns>A string that identifies a type that implements the <see cref="T:System.Net.IWebProxy" /> interface or <see langword="null" /> if no value has been specified.</returns>
		public string Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ModuleElement" /> class. </summary>
		public ModuleElement()
		{
		}
	}
}
