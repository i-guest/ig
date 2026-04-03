namespace UnityEngine.Rendering.Universal
{
	internal sealed class StpHistory : CameraHistoryItem
	{
		private STP.HistoryContext[] m_historyContexts;

		public override void OnCreate(BufferedRTHandleSystem owner, uint typeId)
		{
		}

		public override void Reset()
		{
		}

		internal STP.HistoryContext GetHistoryContext(int eyeIndex)
		{
			return null;
		}

		internal bool Update(UniversalCameraData cameraData)
		{
			return false;
		}
	}
}
