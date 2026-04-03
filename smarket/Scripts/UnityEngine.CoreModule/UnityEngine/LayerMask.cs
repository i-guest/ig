using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/BaseClasses/TagManager.h")]
	[NativeHeader("Runtime/BaseClasses/BitField.h")]
	[NativeClass("BitField", "struct BitField;")]
	public struct LayerMask
	{
		[NativeName("m_Bits")]
		private int m_Mask;

		public int value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static implicit operator int(LayerMask mask)
		{
			return 0;
		}

		public static implicit operator LayerMask(int intVal)
		{
			return default(LayerMask);
		}

		[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
		[NativeMethod("LayerToString")]
		public static string LayerToName(int layer)
		{
			return null;
		}

		[NativeMethod("StringToLayer")]
		[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
		public static int NameToLayer(string layerName)
		{
			return 0;
		}

		public static int GetMask(params string[] layerNames)
		{
			return 0;
		}

		private static void LayerToName_Injected(int layer, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static int NameToLayer_Injected(ref ManagedSpanWrapper layerName)
		{
			return 0;
		}
	}
}
