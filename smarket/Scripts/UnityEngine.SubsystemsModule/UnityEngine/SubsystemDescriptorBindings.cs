using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	internal static class SubsystemDescriptorBindings
	{
		public static string GetId(IntPtr descriptorPtr)
		{
			return null;
		}

		private static void GetId_Injected(IntPtr descriptorPtr, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}
	}
}
