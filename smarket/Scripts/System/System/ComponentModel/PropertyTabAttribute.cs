namespace System.ComponentModel
{
	/// <summary>Identifies the property tab or tabs to display for the specified class or classes.</summary>
	[AttributeUsage(AttributeTargets.All)]
	public class PropertyTabAttribute : Attribute
	{
		private Type[] _tabClasses;

		private string[] _tabClassNames;

		/// <summary>Gets the types of tabs that this attribute uses.</summary>
		/// <returns>An array of types indicating the types of tabs that this attribute uses.</returns>
		/// <exception cref="T:System.TypeLoadException">The types specified by the <see cref="P:System.ComponentModel.PropertyTabAttribute.TabClassNames" /> property could not be found.</exception>
		public Type[] TabClasses => null;

		/// <summary>Gets the names of the tab classes that this attribute uses.</summary>
		/// <returns>The names of the tab classes that this attribute uses.</returns>
		protected string[] TabClassNames => null;

		/// <summary>Gets an array of tab scopes of each tab of this <see cref="T:System.ComponentModel.PropertyTabAttribute" />.</summary>
		/// <returns>An array of <see cref="T:System.ComponentModel.PropertyTabScope" /> objects that indicate the scopes of the tabs.</returns>
		public PropertyTabScope[] TabScopes { get; private set; }

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> class.</summary>
		public PropertyTabAttribute()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> class using the specified type of tab.</summary>
		/// <param name="tabClass">The type of tab to create. </param>
		public PropertyTabAttribute(Type tabClass)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> class using the specified tab class name.</summary>
		/// <param name="tabClassName">The assembly qualified name of the type of tab to create. For an example of this format convention, see <see cref="P:System.Type.AssemblyQualifiedName" />. </param>
		public PropertyTabAttribute(string tabClassName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> class using the specified type of tab and tab scope.</summary>
		/// <param name="tabClass">The type of tab to create. </param>
		/// <param name="tabScope">A <see cref="T:System.ComponentModel.PropertyTabScope" /> that indicates the scope of this tab. If the scope is <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, it is shown only for components with the corresponding <see cref="T:System.ComponentModel.PropertyTabAttribute" />. If it is <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, it is shown for all components on the document. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="tabScope" /> is not <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> or <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.</exception>
		public PropertyTabAttribute(Type tabClass, PropertyTabScope tabScope)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> class using the specified tab class name and tab scope.</summary>
		/// <param name="tabClassName">The assembly qualified name of the type of tab to create. For an example of this format convention, see <see cref="P:System.Type.AssemblyQualifiedName" />. </param>
		/// <param name="tabScope">A <see cref="T:System.ComponentModel.PropertyTabScope" /> that indicates the scope of this tab. If the scope is <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, it is shown only for components with the corresponding <see cref="T:System.ComponentModel.PropertyTabAttribute" />. If it is <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, it is shown for all components on the document. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="tabScope" /> is not <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> or <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.</exception>
		public PropertyTabAttribute(string tabClassName, PropertyTabScope tabScope)
		{
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <param name="other">An object to compare to this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="other" /> refers to the same <see cref="T:System.ComponentModel.PropertyTabAttribute" /> instance; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.TypeLoadException">The types specified by the <see cref="P:System.ComponentModel.PropertyTabAttribute.TabClassNames" /> property of the<paramref name=" other" /> parameter could not be found.</exception>
		public override bool Equals(object other)
		{
			return false;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified attribute.</summary>
		/// <param name="other">A <see cref="T:System.ComponentModel.PropertyTabAttribute" /> to compare to this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.ComponentModel.PropertyTabAttribute" /> instances are equal; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.TypeLoadException">The types specified by the <see cref="P:System.ComponentModel.PropertyTabAttribute.TabClassNames" /> property of the <paramref name="other" /> parameter cannot be found.</exception>
		public bool Equals(PropertyTabAttribute other)
		{
			return false;
		}

		/// <summary>Gets the hash code for this object.</summary>
		/// <returns>The hash code for the object the attribute belongs to.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Initializes the attribute using the specified names of tab classes and array of tab scopes.</summary>
		/// <param name="tabClassNames">An array of fully qualified type names of the types to create for tabs on the Properties window. </param>
		/// <param name="tabScopes">The scope of each tab. If the scope is <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, it is shown only for components with the corresponding <see cref="T:System.ComponentModel.PropertyTabAttribute" />. If it is <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, it is shown for all components on the document. </param>
		/// <exception cref="T:System.ArgumentException">One or more of the values in <paramref name="tabScopes" /> is not <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> or <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.-or-The length of the <paramref name="tabClassNames" /> and <paramref name="tabScopes" /> arrays do not match.-or-
		///         <paramref name="tabClassNames" /> or <paramref name="tabScopes" /> is <see langword="null" />.</exception>
		protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes)
		{
		}

		/// <summary>Initializes the attribute using the specified names of tab classes and array of tab scopes.</summary>
		/// <param name="tabClasses">The types of tabs to create. </param>
		/// <param name="tabScopes">The scope of each tab. If the scope is <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, it is shown only for components with the corresponding <see cref="T:System.ComponentModel.PropertyTabAttribute" />. If it is <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, it is shown for all components on the document. </param>
		/// <exception cref="T:System.ArgumentException">One or more of the values in <paramref name="tabScopes" /> is not <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> or <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.-or-The length of the <paramref name="tabClassNames" /> and <paramref name="tabScopes" /> arrays do not match.-or-
		///         <paramref name="tabClassNames" /> or <paramref name="tabScopes" /> is <see langword="null" />.</exception>
		protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
		}

		private void InitializeArrays(string[] tabClassNames, Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
		}
	}
}
