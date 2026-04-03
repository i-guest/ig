using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = false)]
	[VisibleToOtherModules]
	internal class UnityMarshalAsAttribute : Attribute
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly NativeType _003CNativeType_003Ek__BackingField;

		public UnityMarshalAsAttribute(NativeType nativeType)
		{
		}
	}
}
