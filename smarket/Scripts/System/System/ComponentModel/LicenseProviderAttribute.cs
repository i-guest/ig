namespace System.ComponentModel
{
	/// <summary>Specifies the <see cref="T:System.ComponentModel.LicenseProvider" /> to use with a class. This class cannot be inherited.</summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class LicenseProviderAttribute : Attribute
	{
		/// <summary>Specifies the default value, which is no provider. This <see langword="static" /> field is read-only.</summary>
		public static readonly LicenseProviderAttribute Default;

		private Type _licenseProviderType;

		private string _licenseProviderName;

		/// <summary>Gets the license provider that must be used with the associated class.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of the license provider. The default value is <see langword="null" />.</returns>
		public Type LicenseProvider => null;

		/// <summary>Indicates a unique ID for this attribute type.</summary>
		/// <returns>A unique ID for this attribute type.</returns>
		public override object TypeId => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.LicenseProviderAttribute" /> class without a license provider.</summary>
		public LicenseProviderAttribute()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.LicenseProviderAttribute" /> class with the specified type.</summary>
		/// <param name="typeName">The fully qualified name of the license provider class. </param>
		public LicenseProviderAttribute(string typeName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.LicenseProviderAttribute" /> class with the specified type of license provider.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of the license provider class. </param>
		public LicenseProviderAttribute(Type type)
		{
		}

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <param name="value">Another object to compare to. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object value)
		{
			return false;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.LicenseProviderAttribute" />.</returns>
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
