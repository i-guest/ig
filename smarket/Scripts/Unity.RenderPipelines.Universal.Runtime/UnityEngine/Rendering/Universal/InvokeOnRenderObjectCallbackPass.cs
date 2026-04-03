using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	internal class InvokeOnRenderObjectCallbackPass : ScriptableRenderPass
	{
		private class PassData
		{
			internal TextureHandle colorTarget;

			internal TextureHandle depthTarget;
		}

		public InvokeOnRenderObjectCallbackPass(RenderPassEvent evt)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		internal void Render(RenderGraph renderGraph, TextureHandle colorTarget, TextureHandle depthTarget)
		{
		}
	}
}
