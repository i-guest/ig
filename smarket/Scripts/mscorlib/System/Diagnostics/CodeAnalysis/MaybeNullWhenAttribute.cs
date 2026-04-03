using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class MaybeNullWhenAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly bool _003CReturnValue_003Ek__BackingField;

		public MaybeNullWhenAttribute(bool returnValue)
		{
		}
	}
}
