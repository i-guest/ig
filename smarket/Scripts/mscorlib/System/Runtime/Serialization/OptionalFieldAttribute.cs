using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Specifies that a field can be missing from a serialization stream so that the <see cref="T:System.Runtime.Serialization.Formatters.Binary.BinaryFormatter" /> and the <see cref="T:System.Runtime.Serialization.Formatters.Soap.SoapFormatter" /> does not throw an exception. </summary>
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	public sealed class OptionalFieldAttribute : Attribute
	{
		private int versionAdded;

		/// <summary>This property is unused and is reserved.</summary>
		/// <returns>This property is reserved.</returns>
		public int VersionAdded
		{
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.OptionalFieldAttribute" /> class. </summary>
		public OptionalFieldAttribute()
		{
		}
	}
}
