namespace UnityEngine.Rendering
{
	public abstract class CameraHistoryItem : ContextItem
	{
		private BufferedRTHandleSystem m_owner;

		private uint m_TypeId;

		protected BufferedRTHandleSystem storage => null;

		public virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId)
		{
		}

		protected int MakeId(uint index)
		{
			return 0;
		}

		protected RTHandle AllocHistoryFrameRT(int id, int count, ref RenderTextureDescriptor desc, string name = "")
		{
			return null;
		}

		protected RTHandle AllocHistoryFrameRT(int id, int count, ref RenderTextureDescriptor desc, FilterMode filterMode, string name = "")
		{
			return null;
		}

		protected void ReleaseHistoryFrameRT(int id)
		{
		}

		protected RTHandle GetPreviousFrameRT(int id)
		{
			return null;
		}

		protected RTHandle GetCurrentFrameRT(int id)
		{
			return null;
		}
	}
}
