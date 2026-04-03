using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents a URI prefix and the associated class that handles creating Web requests for the prefix. This class cannot be inherited.</summary>
	public sealed class WebRequestModuleElement : ConfigurationElement
	{
		/// <summary>Gets or sets the URI prefix for the current Web request module.</summary>
		/// <returns>A string that contains a URI prefix.</returns>
		public string Prefix
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

		/// <summary>Gets or sets a class that creates Web requests.</summary>
		/// <returns>A <see cref="T:System.Type" /> instance that identifies a Web request module.</returns>
		public Type Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> class. </summary>
		public WebRequestModuleElement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> class using the specified URI prefix and type information. </summary>
		/// <param name="prefix">A string containing a URI prefix.</param>
		/// <param name="type">A string containing the type and assembly information for the class that handles creating requests for resources that use the <paramref name="prefix" /> URI prefix. For more information, see the Remarks section.</param>
		public WebRequestModuleElement(string prefix, string type)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> class using the specified URI prefix and type identifier.</summary>
		/// <param name="prefix">A string containing a URI prefix.</param>
		/// <param name="type">A <see cref="T:System.Type" /> that identifies the class that handles creating requests for resources that use the <paramref name="prefix" /> URI prefix. </param>
		public WebRequestModuleElement(string prefix, Type type)
		{
		}
	}
}
