using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	internal class LightBuffer
	{
		internal static readonly int kMax;

		internal static readonly int kCount;

		internal static readonly int kLightMod;

		internal static readonly int kBatchMax;

		private GraphicsBuffer m_GraphicsBuffer;

		private NativeArray<int> m_Markers;

		private NativeArray<PerLight2D> m_NativeBuffer;

		internal GraphicsBuffer graphicsBuffer => null;

		internal NativeArray<int> lightMarkers => default(NativeArray<int>);

		internal NativeArray<PerLight2D> nativeBuffer => default(NativeArray<PerLight2D>);

		internal void Release()
		{
		}

		internal void Reset()
		{
		}
	}
}
