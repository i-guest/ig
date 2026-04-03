namespace System.ComponentModel
{
	/// <summary>Specifies the name of the category in which to group the property or event when displayed in a <see cref="T:System.Windows.Forms.PropertyGrid" /> control set to Categorized mode.</summary>
	[AttributeUsage(AttributeTargets.All)]
	public class CategoryAttribute : Attribute
	{
		private static CategoryAttribute appearance;

		private static CategoryAttribute asynchronous;

		private static CategoryAttribute behavior;

		private static CategoryAttribute data;

		private static CategoryAttribute design;

		private static CategoryAttribute action;

		private static CategoryAttribute format;

		private static CategoryAttribute layout;

		private static CategoryAttribute mouse;

		private static CategoryAttribute key;

		private static CategoryAttribute focus;

		private static CategoryAttribute windowStyle;

		private static CategoryAttribute dragDrop;

		private static CategoryAttribute defAttr;

		private bool localized;

		private string categoryValue;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Action category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the action category.</returns>
		public static CategoryAttribute Action => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Appearance category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the appearance category.</returns>
		public static CategoryAttribute Appearance => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Asynchronous category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the asynchronous category.</returns>
		public static CategoryAttribute Asynchronous => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Behavior category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the behavior category.</returns>
		public static CategoryAttribute Behavior => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Data category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the data category.</returns>
		public static CategoryAttribute Data => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Default category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the default category.</returns>
		public static CategoryAttribute Default => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Design category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the design category.</returns>
		public static CategoryAttribute Design => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the DragDrop category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the drag-and-drop category.</returns>
		public static CategoryAttribute DragDrop => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Focus category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the focus category.</returns>
		public static CategoryAttribute Focus => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Format category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the format category.</returns>
		public static CategoryAttribute Format => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Key category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the key category.</returns>
		public static CategoryAttribute Key => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Layout category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the layout category.</returns>
		public static CategoryAttribute Layout => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Mouse category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the mouse category.</returns>
		public static CategoryAttribute Mouse => null;

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the WindowStyle category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the window style category.</returns>
		public static CategoryAttribute WindowStyle => null;

		/// <summary>Gets the name of the category for the property or event that this attribute is applied to.</summary>
		/// <returns>The name of the category for the property or event that this attribute is applied to.</returns>
		public string Category => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CategoryAttribute" /> class using the category name Default.</summary>
		public CategoryAttribute()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CategoryAttribute" /> class using the specified category name.</summary>
		/// <param name="category">The name of the category. </param>
		public CategoryAttribute(string category)
		{
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.CategoryAttribute" />..</summary>
		/// <param name="obj">The object to test the value equality of. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Returns the hash code for this attribute.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Looks up the localized name of the specified category.</summary>
		/// <param name="value">The identifer for the category to look up. </param>
		/// <returns>The localized name of the category, or <see langword="null" /> if a localized name does not exist.</returns>
		protected virtual string GetLocalizedString(string value)
		{
			return null;
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>
		///     <see langword="true" /> if the attribute is the default value for this attribute class; otherwise, <see langword="false" />.</returns>
		public override bool IsDefaultAttribute()
		{
			return false;
		}
	}
}
