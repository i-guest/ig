namespace System.ComponentModel
{
	/// <summary>Specifies the installer for a type that installs components.</summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class InstallerTypeAttribute : Attribute
	{
		private string _typeName;

		/// <summary>Gets the type of installer associated with this attribute.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of installer associated with this attribute, or <see langword="null" /> if an installer does not exist.</returns>
		public virtual Type InstallerType => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InstallerTypeAttribute" /> class, when given a <see cref="T:System.Type" /> that represents the installer for a component.</summary>
		/// <param name="installerType">A <see cref="T:System.Type" /> that represents the installer for the component this attribute is bound to. This class must implement <see cref="T:System.ComponentModel.Design.IDesigner" />. </param>
		public InstallerTypeAttribute(Type installerType)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InstallerTypeAttribute" /> class with the name of the component's installer type.</summary>
		/// <param name="typeName">The name of a <see cref="T:System.Type" /> that represents the installer for the component this attribute is bound to. This class must implement <see cref="T:System.ComponentModel.Design.IDesigner" />. </param>
		public InstallerTypeAttribute(string typeName)
		{
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.InstallerTypeAttribute" />.</summary>
		/// <param name="obj">The object to test the value equality of. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Returns the hashcode for this object.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.InstallerTypeAttribute" />.</returns>
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
