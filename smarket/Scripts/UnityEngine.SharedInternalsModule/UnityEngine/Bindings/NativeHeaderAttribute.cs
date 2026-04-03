using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	[VisibleToOtherModules]
	internal class NativeHeaderAttribute : Attribute
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003CHeader_003Ek__BackingField;

		public string Header
		{
			[CompilerGenerated]
			set
			{
				_003CHeader_003Ek__BackingField = value;
			}
		}

		public NativeHeaderAttribute()
		{
		}

		public NativeHeaderAttribute(string header)
		{
		}
	}
}
