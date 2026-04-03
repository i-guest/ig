using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[RequiredByNativeCode]
	public class OnDemandRendering
	{
		private static int m_RenderFrameInterval;

		public static bool willCurrentFrameRender => false;

		public static int renderFrameInterval => 0;

		public static int effectiveRenderFrameRate => 0;

		[RequiredByNativeCode]
		internal static void GetRenderFrameInterval(out int frameInterval)
		{
			frameInterval = default(int);
		}

		[FreeFunction]
		internal static float GetEffectiveRenderFrameRate()
		{
			return 0f;
		}
	}
}
