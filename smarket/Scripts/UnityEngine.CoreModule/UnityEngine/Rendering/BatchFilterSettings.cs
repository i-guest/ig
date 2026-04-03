namespace UnityEngine.Rendering
{
	public struct BatchFilterSettings
	{
		public uint renderingLayerMask;

		public int rendererPriority;

		private ulong m_sceneCullingMask;

		public byte layer;

		private byte m_batchLayer;

		private byte m_motionMode;

		private byte m_shadowMode;

		private byte m_receiveShadows;

		private byte m_staticShadowCaster;

		private byte m_allDepthSorted;

		private byte m_isSceneCullingMaskSet;

		public byte batchLayer
		{
			set
			{
			}
		}

		public MotionVectorGenerationMode motionMode
		{
			set
			{
			}
		}

		public ShadowCastingMode shadowCastingMode
		{
			set
			{
			}
		}

		public bool receiveShadows
		{
			set
			{
			}
		}

		public bool staticShadowCaster
		{
			set
			{
			}
		}

		public bool allDepthSorted
		{
			set
			{
			}
		}
	}
}
