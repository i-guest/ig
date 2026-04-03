namespace UnityEngine.Rendering.Universal
{
	public sealed class TaaHistory : CameraHistoryItem
	{
		private int[] m_TaaAccumulationTextureIds;

		private int[] m_TaaAccumulationVersions;

		private static readonly string[] m_TaaAccumulationNames;

		private RenderTextureDescriptor m_Descriptor;

		private Hash128 m_DescKey;

		public override void OnCreate(BufferedRTHandleSystem owner, uint typeId)
		{
		}

		public override void Reset()
		{
		}

		public RTHandle GetAccumulationTexture(int eyeIndex = 0)
		{
			return null;
		}

		public int GetAccumulationVersion(int eyeIndex = 0)
		{
			return 0;
		}

		internal void SetAccumulationVersion(int eyeIndex, int version)
		{
		}

		private bool IsValid()
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

		internal bool Update(ref RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled = false)
		{
			return false;
		}
	}
}
