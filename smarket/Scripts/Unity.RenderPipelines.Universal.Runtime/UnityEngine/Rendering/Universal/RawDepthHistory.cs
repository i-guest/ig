namespace UnityEngine.Rendering.Universal
{
	public sealed class RawDepthHistory : CameraHistoryItem
	{
		private int[] m_Ids;

		private static readonly string[] m_Names;

		private RenderTextureDescriptor m_Descriptor;

		private Hash128 m_DescKey;

		public override void OnCreate(BufferedRTHandleSystem owner, uint typeId)
		{
		}

		public RTHandle GetCurrentTexture(int eyeIndex = 0)
		{
			return null;
		}

		public RTHandle GetPreviousTexture(int eyeIndex = 0)
		{
			return null;
		}

		private bool IsAllocated()
		{
			return false;
		}

		private bool IsDirty(ref RenderTextureDescriptor desc)
		{
			return false;
		}

		private void Alloc(ref RenderTextureDescriptor desc, bool xrMultipassEnabled)
		{
		}

		public override void Reset()
		{
		}

		internal RenderTextureDescriptor GetHistoryDescriptor(ref RenderTextureDescriptor cameraDesc)
		{
			return default(RenderTextureDescriptor);
		}

		internal bool Update(ref RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled)
		{
			return false;
		}
	}
}
