using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
	internal class StaticAccessorAttribute : Attribute
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003CName_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private StaticAccessorType _003CType_003Ek__BackingField;

		public string Name
		{
			[CompilerGenerated]
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}

		public StaticAccessorType Type
		{
			[CompilerGenerated]
			set
			{
				_003CType_003Ek__BackingField = value;
			}
		}

		[VisibleToOtherModules]
		internal StaticAccessorAttribute(string name)
		{
		}

		public StaticAccessorAttribute(string name, StaticAccessorType type)
		{
		}
	}
}
