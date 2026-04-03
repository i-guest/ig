using System.Reflection;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Represents a configuration element within a configuration file.</summary>
	[DefaultMember("Item")]
	public abstract class ConfigurationElement
	{
		/// <summary>Gets the collection of properties.</summary>
		/// <returns>The <see cref="T:System.Configuration.ConfigurationPropertyCollection" /> of properties for the element.</returns>
		protected internal virtual ConfigurationPropertyCollection Properties => null;

		/// <summary>Reads XML from the configuration file.</summary>
		/// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> that reads from the configuration file.</param>
		/// <param name="serializeCollectionKey">
		///       <see langword="true" /> to serialize only the collection key properties; otherwise, <see langword="false" />.</param>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">The element to read is locked.- or -An attribute of the current node is not recognized.- or -The lock status of the current node cannot be determined.  </exception>
		protected internal virtual void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		/// <summary>Used to initialize a default set of values for the <see cref="T:System.Configuration.ConfigurationElement" /> object.</summary>
		protected internal virtual void InitializeDefault()
		{
		}

		/// <summary>Indicates whether this configuration element has been modified since it was last saved or loaded, when implemented in a derived class.</summary>
		/// <returns>
		///     <see langword="true" /> if the element has been modified; otherwise, <see langword="false" />. </returns>
		protected internal virtual bool IsModified()
		{
			return false;
		}

		/// <summary>Called after deserialization.</summary>
		protected virtual void PostDeserialize()
		{
		}

		/// <summary>Resets the internal state of the <see cref="T:System.Configuration.ConfigurationElement" /> object, including the locks and the properties collections.</summary>
		/// <param name="parentElement">The parent node of the configuration element.</param>
		protected internal virtual void Reset(ConfigurationElement parentElement)
		{
		}

		/// <summary>Resets the value of the <see cref="M:System.Configuration.ConfigurationElement.IsModified" /> method to <see langword="false" /> when implemented in a derived class.</summary>
		protected internal virtual void ResetModified()
		{
		}
	}
}
