using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Categorization
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	public sealed class CategoryInfoAttribute : Attribute
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int _003COrder_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _003CName_003Ek__BackingField;

		public int Order
		{
			[CompilerGenerated]
			set
			{
				_003COrder_003Ek__BackingField = value;
			}
		}

		public string Name
		{
			[CompilerGenerated]
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}
	}
}
