namespace System.ComponentModel
{
	/// <summary>Identifies a type as an object suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object. This class cannot be inherited.</summary>
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DataObjectAttribute : Attribute
	{
		/// <summary>Indicates that the class is suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object at design time. This field is read-only.</summary>
		public static readonly DataObjectAttribute DataObject;

		/// <summary>Indicates that the class is not suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object at design time. This field is read-only.</summary>
		public static readonly DataObjectAttribute NonDataObject;

		/// <summary>Represents the default value of the <see cref="T:System.ComponentModel.DataObjectAttribute" /> class, which indicates that the class is suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object at design time. This field is read-only.</summary>
		public static readonly DataObjectAttribute Default;

		/// <summary>Gets a value indicating whether an object should be considered suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object at design time.</summary>
		/// <returns>
		///     <see langword="true" /> if the object should be considered suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object; otherwise, <see langword="false" />.</returns>
		public bool IsDataObject { get; }

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DataObjectAttribute" /> class. </summary>
		public DataObjectAttribute()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DataObjectAttribute" /> class and indicates whether an object is suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object.</summary>
		/// <param name="isDataObject">
		///       <see langword="true" /> if the object is suitable for binding to an <see cref="T:System.Web.UI.WebControls.ObjectDataSource" /> object; otherwise, <see langword="false" />.</param>
		public DataObjectAttribute(bool isDataObject)
		{
		}

		/// <summary>Determines whether this instance of <see cref="T:System.ComponentModel.DataObjectAttribute" /> fits the pattern of another object.</summary>
		/// <param name="obj">An object to compare with this instance of <see cref="T:System.ComponentModel.DataObjectAttribute" />. </param>
		/// <returns>
		///     <see langword="true" /> if this instance is the same as the instance specified by the <paramref name="obj" /> parameter; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if the current value of the attribute is the default; otherwise, <see langword="false" />.</returns>
		public override bool IsDefaultAttribute()
		{
			return false;
		}
	}
}
