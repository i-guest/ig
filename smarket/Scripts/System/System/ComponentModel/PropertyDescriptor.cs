using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Provides an abstraction of a property on a class.</summary>
	public abstract class PropertyDescriptor : MemberDescriptor
	{
		private TypeConverter _converter;

		private Hashtable _valueChangedHandlers;

		private object[] _editors;

		private Type[] _editorTypes;

		private int _editorCount;

		/// <summary>When overridden in a derived class, gets the type of the component this property is bound to.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of component this property is bound to. When the <see cref="M:System.ComponentModel.PropertyDescriptor.GetValue(System.Object)" /> or <see cref="M:System.ComponentModel.PropertyDescriptor.SetValue(System.Object,System.Object)" /> methods are invoked, the object specified might be an instance of this type.</returns>
		public abstract Type ComponentType { get; }

		/// <summary>Gets the type converter for this property.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> that is used to convert the <see cref="T:System.Type" /> of this property.</returns>
		public virtual TypeConverter Converter => null;

		/// <summary>Gets a value indicating whether this property should be localized, as specified in the <see cref="T:System.ComponentModel.LocalizableAttribute" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the member is marked with the <see cref="T:System.ComponentModel.LocalizableAttribute" /> set to <see langword="true" />; otherwise, <see langword="false" />.</returns>
		public virtual bool IsLocalizable => false;

		/// <summary>When overridden in a derived class, gets a value indicating whether this property is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the property is read-only; otherwise, <see langword="false" />.</returns>
		public abstract bool IsReadOnly { get; }

		/// <summary>Gets a value indicating whether this property should be serialized, as specified in the <see cref="T:System.ComponentModel.DesignerSerializationVisibilityAttribute" />.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.DesignerSerializationVisibility" /> enumeration values that specifies whether this property should be serialized.</returns>
		public DesignerSerializationVisibility SerializationVisibility => default(DesignerSerializationVisibility);

		/// <summary>When overridden in a derived class, gets the type of the property.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of the property.</returns>
		public abstract Type PropertyType { get; }

		/// <summary>Gets a value indicating whether value change notifications for this property may originate from outside the property descriptor.</summary>
		/// <returns>
		///     <see langword="true" /> if value change notifications may originate from outside the property descriptor; otherwise, <see langword="false" />.</returns>
		public virtual bool SupportsChangeEvents => false;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> class with the specified name and attributes.</summary>
		/// <param name="name">The name of the property. </param>
		/// <param name="attrs">An array of type <see cref="T:System.Attribute" /> that contains the property attributes. </param>
		protected PropertyDescriptor(string name, Attribute[] attrs)
			: base((string)null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> class with the name and attributes in the specified <see cref="T:System.ComponentModel.MemberDescriptor" />.</summary>
		/// <param name="descr">A <see cref="T:System.ComponentModel.MemberDescriptor" /> that contains the name of the property and its attributes. </param>
		protected PropertyDescriptor(MemberDescriptor descr)
			: base((string)null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> class with the name in the specified <see cref="T:System.ComponentModel.MemberDescriptor" /> and the attributes in both the <see cref="T:System.ComponentModel.MemberDescriptor" /> and the <see cref="T:System.Attribute" /> array.</summary>
		/// <param name="descr">A <see cref="T:System.ComponentModel.MemberDescriptor" /> containing the name of the member and its attributes. </param>
		/// <param name="attrs">An <see cref="T:System.Attribute" /> array containing the attributes you want to associate with the property. </param>
		protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs)
			: base((string)null)
		{
		}

		/// <summary>Enables other objects to be notified when this property changes.</summary>
		/// <param name="component">The component to add the handler for. </param>
		/// <param name="handler">The delegate to add as a listener. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="component" /> or <paramref name="handler" /> is <see langword="null" />.</exception>
		public virtual void AddValueChanged(object component, EventHandler handler)
		{
		}

		/// <summary>When overridden in a derived class, returns whether resetting an object changes its value.</summary>
		/// <param name="component">The component to test for reset capability. </param>
		/// <returns>
		///     <see langword="true" /> if resetting the component changes its value; otherwise, <see langword="false" />.</returns>
		public abstract bool CanResetValue(object component);

		/// <summary>Compares this to another object to see if they are equivalent.</summary>
		/// <param name="obj">The object to compare to this <see cref="T:System.ComponentModel.PropertyDescriptor" />. </param>
		/// <returns>
		///     <see langword="true" /> if the values are equivalent; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Creates an instance of the specified type.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type to create. </param>
		/// <returns>A new instance of the type.</returns>
		protected object CreateInstance(Type type)
		{
			return null;
		}

		/// <summary>Adds the attributes of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to the specified list of attributes in the parent class.</summary>
		/// <param name="attributeList">An <see cref="T:System.Collections.IList" /> that lists the attributes in the parent class. Initially, this is empty.</param>
		protected override void FillAttributes(IList attributeList)
		{
		}

		/// <summary>Returns the default <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />.</summary>
		/// <returns>A collection of property descriptor.</returns>
		public PropertyDescriptorCollection GetChildProperties()
		{
			return null;
		}

		/// <summary>Returns a <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> using a specified array of attributes as a filter.</summary>
		/// <param name="filter">An array of type <see cref="T:System.Attribute" /> to use as a filter. </param>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that match the specified attributes.</returns>
		public PropertyDescriptorCollection GetChildProperties(Attribute[] filter)
		{
			return null;
		}

		/// <summary>Returns a <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> for a given object.</summary>
		/// <param name="instance">A component to get the properties for. </param>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties for the specified component.</returns>
		public PropertyDescriptorCollection GetChildProperties(object instance)
		{
			return null;
		}

		/// <summary>Returns a <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> for a given object using a specified array of attributes as a filter.</summary>
		/// <param name="instance">A component to get the properties for. </param>
		/// <param name="filter">An array of type <see cref="T:System.Attribute" /> to use as a filter. </param>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that match the specified attributes for the specified component.</returns>
		public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
		{
			return null;
		}

		/// <summary>Gets an editor of the specified type.</summary>
		/// <param name="editorBaseType">The base type of editor, which is used to differentiate between multiple editors that a property supports. </param>
		/// <returns>An instance of the requested editor type, or <see langword="null" /> if an editor cannot be found.</returns>
		public virtual object GetEditor(Type editorBaseType)
		{
			return null;
		}

		/// <summary>Returns the hash code for this object.</summary>
		/// <returns>The hash code for this object.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>This method returns the object that should be used during invocation of members.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the invocation target.</param>
		/// <param name="instance">The potential invocation target.</param>
		/// <returns>The <see cref="T:System.Object" /> that should be used during invocation of members.</returns>
		protected override object GetInvocationTarget(Type type, object instance)
		{
			return null;
		}

		/// <summary>Returns a type using its name.</summary>
		/// <param name="typeName">The assembly-qualified name of the type to retrieve. </param>
		/// <returns>A <see cref="T:System.Type" /> that matches the given type name, or <see langword="null" /> if a match cannot be found.</returns>
		protected Type GetTypeFromName(string typeName)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, gets the current value of the property on a component.</summary>
		/// <param name="component">The component with the property for which to retrieve the value. </param>
		/// <returns>The value of a property for a given component.</returns>
		public abstract object GetValue(object component);

		/// <summary>Raises the ValueChanged event that you implemented.</summary>
		/// <param name="component">The object that raises the event. </param>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data. </param>
		protected virtual void OnValueChanged(object component, EventArgs e)
		{
		}

		/// <summary>Enables other objects to be notified when this property changes.</summary>
		/// <param name="component">The component to remove the handler for. </param>
		/// <param name="handler">The delegate to remove as a listener. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="component" /> or <paramref name="handler" /> is <see langword="null" />.</exception>
		public virtual void RemoveValueChanged(object component, EventHandler handler)
		{
		}

		/// <summary>Retrieves the current set of ValueChanged event handlers for a specific component</summary>
		/// <param name="component">The component for which to retrieve event handlers.</param>
		/// <returns>A combined multicast event handler, or <see langword="null" /> if no event handlers are currently assigned to <paramref name="component" />.</returns>
		protected internal EventHandler GetValueChangedHandler(object component)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, resets the value for this property of the component to the default value.</summary>
		/// <param name="component">The component with the property value that is to be reset to the default value. </param>
		public abstract void ResetValue(object component);

		/// <summary>When overridden in a derived class, sets the value of the component to a different value.</summary>
		/// <param name="component">The component with the property value that is to be set. </param>
		/// <param name="value">The new value. </param>
		public abstract void SetValue(object component, object value);

		/// <summary>When overridden in a derived class, determines a value indicating whether the value of this property needs to be persisted.</summary>
		/// <param name="component">The component with the property to be examined for persistence. </param>
		/// <returns>
		///     <see langword="true" /> if the property should be persisted; otherwise, <see langword="false" />.</returns>
		public abstract bool ShouldSerializeValue(object component);
	}
}
