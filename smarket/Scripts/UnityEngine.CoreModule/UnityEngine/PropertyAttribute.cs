using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public abstract class PropertyAttribute : Attribute
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly bool _003CapplyToCollection_003Ek__BackingField;

		protected PropertyAttribute()
		{
		}

		protected PropertyAttribute(bool applyToCollection)
		{
		}
	}
}
