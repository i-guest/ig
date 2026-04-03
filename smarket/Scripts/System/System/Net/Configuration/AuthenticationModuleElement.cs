using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the type information for an authentication module. This class cannot be inherited.</summary>
	public sealed class AuthenticationModuleElement : ConfigurationElement
	{
		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Gets or sets the type and assembly information for the current instance.</summary>
		/// <returns>A string that identifies a type that implements an authentication module or <see langword="null" /> if no value has been specified.</returns>
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

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.AuthenticationModuleElement" /> class. </summary>
		public AuthenticationModuleElement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.AuthenticationModuleElement" /> class with the specified type information.</summary>
		/// <param name="typeName">A string that identifies the type and the assembly that contains it.</param>
		public AuthenticationModuleElement(string typeName)
		{
		}
	}
}
