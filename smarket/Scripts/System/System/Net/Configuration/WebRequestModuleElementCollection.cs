using System.Configuration;
using System.Runtime.CompilerServices;

namespace System.Net.Configuration
{
	/// <summary>Represents a container for Web request module configuration elements. This class cannot be inherited.</summary>
	[ConfigurationCollection(typeof(WebRequestModuleElement))]
	public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
	{
		/// <summary>Gets or sets the element with the specified key.</summary>
		/// <param name="name">The key for an element in the collection.</param>
		/// <returns>The <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> with the specified key or <see langword="null" /> if there is no element with the specified key.</returns>
		public WebRequestModuleElement this[string name]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebRequestModuleElementCollection" /> class. </summary>
		public WebRequestModuleElementCollection()
		{
		}

		[SpecialName]
		public WebRequestModuleElement get_Item(int index)
		{
			return null;
		}

		[SpecialName]
		public void set_Item(int index, WebRequestModuleElement value)
		{
		}

		/// <summary>Adds an element to the collection.</summary>
		/// <param name="element">The <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> to add to the collection.</param>
		public void Add(WebRequestModuleElement element)
		{
		}

		/// <summary>Removes all elements from the collection.</summary>
		public void Clear()
		{
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return null;
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return null;
		}

		/// <summary>Returns the index of the specified configuration element.</summary>
		/// <param name="element">A <see cref="T:System.Net.Configuration.WebRequestModuleElement" />.</param>
		/// <returns>The zero-based index of <paramref name="element" />.</returns>
		public int IndexOf(WebRequestModuleElement element)
		{
			return 0;
		}

		/// <summary>Removes the specified configuration element from the collection.</summary>
		/// <param name="element">The <see cref="T:System.Net.Configuration.WebRequestModuleElement" /> to remove.</param>
		public void Remove(WebRequestModuleElement element)
		{
		}

		/// <summary>Removes the element with the specified key.</summary>
		/// <param name="name">The key of the element to remove.</param>
		public void Remove(string name)
		{
		}

		/// <summary>Removes the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to remove.</param>
		public void RemoveAt(int index)
		{
		}
	}
}
