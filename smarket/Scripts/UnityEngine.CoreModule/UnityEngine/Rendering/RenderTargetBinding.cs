namespace UnityEngine.Rendering
{
	public struct RenderTargetBinding
	{
		private RenderTargetIdentifier[] m_ColorRenderTargets;

		private RenderTargetIdentifier m_DepthRenderTarget;

		private RenderBufferLoadAction[] m_ColorLoadActions;

		private RenderBufferStoreAction[] m_ColorStoreActions;

		private RenderBufferLoadAction m_DepthLoadAction;

		private RenderBufferStoreAction m_DepthStoreAction;

		private RenderTargetFlags m_Flags;

		public RenderTargetIdentifier[] colorRenderTargets => null;

		public RenderTargetIdentifier depthRenderTarget => default(RenderTargetIdentifier);

		public RenderBufferLoadAction[] colorLoadActions => null;

		public RenderBufferStoreAction[] colorStoreActions => null;

		public RenderBufferLoadAction depthLoadAction => default(RenderBufferLoadAction);

		public RenderBufferStoreAction depthStoreAction => default(RenderBufferStoreAction);

		public RenderTargetFlags flags => default(RenderTargetFlags);
	}
}
