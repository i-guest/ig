using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Properties
{
	[Serializable]
	public class MissingPropertyBagException : Exception
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly Type _003CType_003Ek__BackingField;

		public MissingPropertyBagException(Type type)
		{
		}

		private static string GetMessageForType(Type type)
		{
			return null;
		}
	}
}
