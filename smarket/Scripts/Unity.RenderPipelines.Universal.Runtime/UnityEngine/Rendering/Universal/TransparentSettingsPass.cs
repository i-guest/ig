using System;

namespace UnityEngine.Rendering.Universal
{
	internal class TransparentSettingsPass : ScriptableRenderPass
	{
		private bool m_shouldReceiveShadows;

		public TransparentSettingsPass(RenderPassEvent evt, bool shadowReceiveSupported)
		{
		}

		public bool Setup()
		{
			return false;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public static void ExecutePass(RasterCommandBuffer rasterCommandBuffer)
		{
		}
	}
}
