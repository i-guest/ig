using System.Runtime.CompilerServices;

namespace System.Reflection
{
	/// <summary>Provides a text description for an assembly.</summary>
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDescriptionAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly string _003CDescription_003Ek__BackingField;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyDescriptionAttribute" /> class.</summary>
		/// <param name="description">The assembly description. </param>
		public AssemblyDescriptionAttribute(string description)
		{
		}
	}
}
