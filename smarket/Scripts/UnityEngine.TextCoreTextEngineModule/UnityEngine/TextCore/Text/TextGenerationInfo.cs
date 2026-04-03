using System;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal static class TextGenerationInfo
	{
		public static int CurrentGenerationIteration { get; private set; }

		[ThreadSafe]
		public static IntPtr Create(bool isPermanent)
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		public static void Destroy(IntPtr ptr)
		{
		}

		public static void OnRepaintEnd()
		{
		}

		private static void DestroyAllTempAllocations()
		{
		}
	}
}
