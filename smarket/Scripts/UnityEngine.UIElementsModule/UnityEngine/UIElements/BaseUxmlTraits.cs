using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	[Obsolete("BaseUxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public abstract class BaseUxmlTraits
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CcanHaveAnyAttribute_003Ek__BackingField;

		protected bool canHaveAnyAttribute
		{
			[CompilerGenerated]
			set
			{
				_003CcanHaveAnyAttribute_003Ek__BackingField = value;
			}
		}
	}
}
