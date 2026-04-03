namespace UnityEngine.Rendering.Universal
{
	public struct RenderingData
	{
		internal ContextContainer frameData;

		public CameraData cameraData;

		public LightData lightData;

		public ShadowData shadowData;

		public PostProcessingData postProcessingData;

		internal UniversalRenderingData universalRenderingData => null;

		internal ref CommandBuffer commandBuffer
		{
			get
			{
				throw null;
			}
		}

		public ref CullingResults cullResults
		{
			get
			{
				throw null;
			}
		}

		public ref bool supportsDynamicBatching
		{
			get
			{
				throw null;
			}
		}

		public ref PerObjectData perObjectData
		{
			get
			{
				throw null;
			}
		}

		public ref bool postProcessingEnabled
		{
			get
			{
				throw null;
			}
		}

		internal RenderingData(ContextContainer frameData)
		{
			this.frameData = null;
			cameraData = default(CameraData);
			lightData = default(LightData);
			shadowData = default(ShadowData);
			postProcessingData = default(PostProcessingData);
		}
	}
}
