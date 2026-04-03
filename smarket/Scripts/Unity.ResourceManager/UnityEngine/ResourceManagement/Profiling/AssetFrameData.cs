namespace UnityEngine.ResourceManagement.Profiling
{
	internal struct AssetFrameData
	{
		public int AssetCode;

		public int BundleCode;

		public int ReferenceCount;

		public float PercentComplete;

		public ContentStatus Status;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
