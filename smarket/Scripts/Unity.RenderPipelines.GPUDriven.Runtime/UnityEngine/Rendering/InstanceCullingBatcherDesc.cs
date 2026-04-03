namespace UnityEngine.Rendering
{
	internal struct InstanceCullingBatcherDesc
	{
		public OnCullingCompleteCallback onCompleteCallback;

		public static InstanceCullingBatcherDesc NewDefault()
		{
			return default(InstanceCullingBatcherDesc);
		}
	}
}
