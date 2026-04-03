namespace UnityEngine.Rendering
{
	internal struct BinningConfig
	{
		public int viewCount;

		public bool supportsCrossFade;

		public bool supportsMotionCheck;

		public int visibilityConfigCount => 0;
	}
}
