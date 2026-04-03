using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[NativeHeader("Modules/Terrain/Public/SpeedTreeWindManager.h")]
	[StaticAccessor("GetSpeedTreeWindManager()", StaticAccessorType.Dot)]
	internal static class SpeedTreeWindManager
	{
		public static void UpdateWindAndWriteBufferWindParams(ReadOnlySpan<int> renderersID, SpeedTreeWindParamsBufferIterator windParams, bool history)
		{
		}

		private static void UpdateWindAndWriteBufferWindParams_Injected(ref ManagedSpanWrapper renderersID, [In] ref SpeedTreeWindParamsBufferIterator windParams, bool history)
		{
		}
	}
}
