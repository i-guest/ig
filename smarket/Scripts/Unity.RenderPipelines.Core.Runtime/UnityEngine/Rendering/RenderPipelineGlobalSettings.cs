using System;

namespace UnityEngine.Rendering
{
	public abstract class RenderPipelineGlobalSettings<TGlobalRenderPipelineSettings, TRenderPipeline> : RenderPipelineGlobalSettings where TGlobalRenderPipelineSettings : RenderPipelineGlobalSettings where TRenderPipeline : RenderPipeline
	{
		private static Lazy<TGlobalRenderPipelineSettings> s_Instance;

		public static TGlobalRenderPipelineSettings instance => null;

		public virtual void Reset()
		{
		}
	}
}
