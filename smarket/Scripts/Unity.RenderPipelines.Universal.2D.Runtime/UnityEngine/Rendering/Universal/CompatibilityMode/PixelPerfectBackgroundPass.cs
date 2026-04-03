using System;

namespace UnityEngine.Rendering.Universal.CompatibilityMode
{
	internal class PixelPerfectBackgroundPass : ScriptableRenderPass
	{
		private static readonly ProfilingSampler m_ProfilingScope;

		public PixelPerfectBackgroundPass(RenderPassEvent evt)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
}
