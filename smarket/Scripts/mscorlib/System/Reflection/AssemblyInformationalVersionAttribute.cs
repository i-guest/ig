using System.Runtime.CompilerServices;

namespace System.Reflection
{
	/// <summary>Defines additional version information for an assembly manifest.</summary>
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyInformationalVersionAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly string _003CInformationalVersion_003Ek__BackingField;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyInformationalVersionAttribute" /> class.</summary>
		/// <param name="informationalVersion">The assembly version information. </param>
		public AssemblyInformationalVersionAttribute(string informationalVersion)
		{
		}
	}
}
