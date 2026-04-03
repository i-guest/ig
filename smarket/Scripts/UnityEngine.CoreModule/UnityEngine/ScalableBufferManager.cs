using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("ScalableBufferManager::GetInstance()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/GfxDevice/ScalableBufferManager.h")]
	public static class ScalableBufferManager
	{
		public static float widthScaleFactor => 0f;

		public static float heightScaleFactor => 0f;

		public static void ResizeBuffers(float widthScale, float heightScale)
		{
		}
	}
}
