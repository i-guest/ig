using System.Runtime.CompilerServices;

namespace System.Reflection
{
	/// <summary>Defines a copyright custom attribute for an assembly manifest.</summary>
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCopyrightAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly string _003CCopyright_003Ek__BackingField;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyCopyrightAttribute" /> class.</summary>
		/// <param name="copyright">The copyright information. </param>
		public AssemblyCopyrightAttribute(string copyright)
		{
		}
	}
}
