namespace UnityEngine.Rendering.Universal
{
	internal abstract class SingleHistoryBase : CameraHistoryItem
	{
		private int m_Id;

		private RenderTextureDescriptor m_Descriptor;

		private Hash128 m_DescKey;

		public override void OnCreate(BufferedRTHandleSystem owner, uint typeId)
		{
		}

		public RTHandle GetTexture(int frameIndex = 0)
		{
			return null;
		}

		public RTHandle GetCurrentTexture()
		{
			return null;
		}

		public RTHandle GetPreviousTexture()
		{
			return null;
		}

		internal bool IsAllocated()
		{
			return false;
		}

		internal bool IsDirty(ref RenderTextureDescriptor desc)
		{
			return false;
		}

		private void Alloc(ref RenderTextureDescriptor desc)
		{
		}

		public override void Reset()
		{
		}

		internal bool Update(ref RenderTextureDescriptor cameraDesc)
		{
			return false;
		}

		protected abstract int GetHistoryFrameCount();

		protected abstract string GetHistoryName();

		protected abstract RenderTextureDescriptor GetHistoryDescriptor(ref RenderTextureDescriptor cameraDesc);
	}
}
