using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[Serializable]
	[NativeClass("RenderingLayerMask", "struct RenderingLayerMask;")]
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Graphics/RenderingLayerMask.h")]
	public struct RenderingLayerMask
	{
		[NativeName("m_Bits")]
		private uint m_Bits;

		internal const int maxRenderingLayerSize = 32;

		public static RenderingLayerMask defaultRenderingLayerMask { get; }

		public static implicit operator uint(RenderingLayerMask mask)
		{
			return 0u;
		}

		public static implicit operator RenderingLayerMask(uint intVal)
		{
			return default(RenderingLayerMask);
		}

		public static implicit operator int(RenderingLayerMask mask)
		{
			return 0;
		}

		public static implicit operator RenderingLayerMask(int intVal)
		{
			return default(RenderingLayerMask);
		}

		[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
		[NativeMethod("RenderingLayerToString")]
		public static string RenderingLayerToName(int layer)
		{
			return null;
		}

		[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
		public static int GetDefinedRenderingLayerCount()
		{
			return 0;
		}

		[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
		public static uint GetDefinedRenderingLayersCombinedMaskValue()
		{
			return 0u;
		}

		[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
		public static string[] GetDefinedRenderingLayerNames()
		{
			return null;
		}

		[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
		public static int GetRenderingLayerCount()
		{
			return 0;
		}

		private static void RenderingLayerToName_Injected(int layer, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}
	}
}
