namespace UnityEngine.Rendering.Universal
{
	internal static class ScriptableRenderPass2DExtension
	{
		internal static void GetInjectionPoint2D(this ScriptableRenderPass renderPass, out RenderPassEvent2D rpEvent, out int rpLayer)
		{
			rpEvent = default(RenderPassEvent2D);
			rpLayer = default(int);
		}
	}
}
