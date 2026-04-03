using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Categorization
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	public sealed class ElementInfoAttribute : Attribute
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int _003COrder_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003CName_003Ek__BackingField;

		public int Order
		{
			[CompilerGenerated]
			set
			{
				_003COrder_003Ek__BackingField = value;
			}
		}
	}
}
