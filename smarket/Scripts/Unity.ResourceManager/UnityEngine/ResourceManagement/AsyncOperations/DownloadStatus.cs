namespace UnityEngine.ResourceManagement.AsyncOperations
{
	public struct DownloadStatus
	{
		public long TotalBytes;

		public long DownloadedBytes;

		public bool IsDone;

		public float Percent => 0f;
	}
}
