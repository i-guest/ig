using UnityEngine.Bindings;

namespace UnityEngine.UIElements.Layout
{
	[NativeHeader("Modules/UIElements/Core/Layout/Native/LayoutNative.h")]
	internal struct LayoutCacheData
	{
		public static LayoutCacheData Default;

		public LayoutCachedMeasurement CachedLayout;

		public override readonly string ToString()
		{
			return null;
		}

		public readonly int MeasurementCacheCount()
		{
			return 0;
		}

		public void ClearCachedMeasurements()
		{
		}

		private unsafe static void ClearCachedMeasurements(void* LayoutCacheData)
		{
		}
	}
}
