using System.Runtime.CompilerServices;

namespace System.Reflection
{
	/// <summary>Defines a key/value metadata pair for the decorated assembly.</summary>
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class AssemblyMetadataAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly string _003CKey_003Ek__BackingField;

		[CompilerGenerated]
		private readonly string _003CValue_003Ek__BackingField;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyMetadataAttribute" /> class by using the specified metadata key and value.</summary>
		/// <param name="key">The metadata key.</param>
		/// <param name="value">The metadata value.</param>
		public AssemblyMetadataAttribute(string key, string value)
		{
		}
	}
}
