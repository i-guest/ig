using System;
using System.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class CapturePass : ScriptableRenderPass
	{
		private class UnsafePassData
		{
			internal TextureHandle source;

			public IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> captureActions;
		}

		private RTHandle m_CameraColorHandle;

		public CapturePass(RenderPassEvent evt)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}
	}
}
