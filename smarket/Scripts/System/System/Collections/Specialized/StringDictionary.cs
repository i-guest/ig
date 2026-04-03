using System.Reflection;

namespace System.Collections.Specialized
{
	/// <summary>Implements a hash table with the key and the value strongly typed to be strings rather than objects.</summary>
	[Serializable]
	[DefaultMember("Item")]
	public class StringDictionary : IEnumerable
	{
		internal Hashtable contents;

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.StringDictionary" /> class.</summary>
		public StringDictionary()
		{
		}

		/// <summary>Adds an entry with the specified key and value into the <see cref="T:System.Collections.Specialized.StringDictionary" />.</summary>
		/// <param name="key">The key of the entry to add. </param>
		/// <param name="value">The value of the entry to add. The value can be <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="key" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">An entry with the same key already exists in the <see cref="T:System.Collections.Specialized.StringDictionary" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Specialized.StringDictionary" /> is read-only. </exception>
		public virtual void Add(string key, string value)
		{
		}

		/// <summary>Returns an enumerator that iterates through the string dictionary.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that iterates through the string dictionary.</returns>
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
