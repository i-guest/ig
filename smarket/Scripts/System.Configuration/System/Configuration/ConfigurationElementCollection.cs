using System.Diagnostics;

namespace System.Configuration
{
	/// <summary>Represents a configuration element containing a collection of child elements.</summary>
	[DebuggerDisplay("Count = {Count}")]
	public abstract class ConfigurationElementCollection : ConfigurationElement
	{
		/// <summary>Gets a value indicating whether an attempt to add a duplicate <see cref="T:System.Configuration.ConfigurationElement" /> to the <see cref="T:System.Configuration.ConfigurationElementCollection" /> will cause an exception to be thrown.</summary>
		/// <returns>
		///     <see langword="true" /> if an attempt to add a duplicate <see cref="T:System.Configuration.ConfigurationElement" /> to this <see cref="T:System.Configuration.ConfigurationElementCollection" /> will cause an exception to be thrown; otherwise, <see langword="false" />. </returns>
		protected virtual bool ThrowOnDuplicate => false;

		/// <summary>When overridden in a derived class, creates a new <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
		/// <returns>A newly created <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
		protected abstract ConfigurationElement CreateNewElement();

		/// <summary>Gets the element key for a specified configuration element when overridden in a derived class.</summary>
		/// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement" /> to return the key for. </param>
		/// <returns>An <see cref="T:System.Object" /> that acts as the key for the specified <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
		protected abstract object GetElementKey(ConfigurationElement element);
	}
}
