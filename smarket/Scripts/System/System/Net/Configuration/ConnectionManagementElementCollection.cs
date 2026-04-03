using System.Configuration;
using System.Runtime.CompilerServices;

namespace System.Net.Configuration
{
	/// <summary>Represents a container for connection management configuration elements. This class cannot be inherited.</summary>
	[ConfigurationCollection(typeof(ConnectionManagementElement))]
	public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
	{
		/// <summary>Gets or sets the element with the specified key.</summary>
		/// <param name="name">The key for an element in the collection. </param>
		/// <returns>The <see cref="T:System.Net.Configuration.ConnectionManagementElement" /> with the specified key or <see langword="null" /> if there is no element with the specified key.</returns>
		public ConnectionManagementElement this[string name]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.ConnectionManagementElementCollection" /> class. </summary>
		public ConnectionManagementElementCollection()
		{
		}

		[SpecialName]
		public ConnectionManagementElement get_Item(int index)
		{
			return null;
		}

		[SpecialName]
		public void set_Item(int index, ConnectionManagementElement value)
		{
		}

		/// <summary>Adds an element to the collection.</summary>
		/// <param name="element">The <see cref="T:System.Net.Configuration.ConnectionManagementElement" /> to add to the collection.</param>
		public void Add(ConnectionManagementElement element)
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
		/// <param name="element">A <see cref="T:System.Net.Configuration.ConnectionManagementElement" />.</param>
		/// <returns>The zero-based index of <paramref name="element" />.</returns>
		public int IndexOf(ConnectionManagementElement element)
		{
			return 0;
		}

		/// <summary>Removes the specified configuration element from the collection.</summary>
		/// <param name="element">The <see cref="T:System.Net.Configuration.ConnectionManagementElement" /> to remove.</param>
		public void Remove(ConnectionManagementElement element)
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
