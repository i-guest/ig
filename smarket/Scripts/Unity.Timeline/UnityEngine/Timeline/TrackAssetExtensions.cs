namespace UnityEngine.Timeline
{
	public static class TrackAssetExtensions
	{
		public static GroupTrack GetGroup(this TrackAsset asset)
		{
			return null;
		}

		public static void SetGroup(this TrackAsset asset, GroupTrack group)
		{
		}

		internal static void ComputeBlendsFromOverlaps(this TrackAsset asset, bool force = false)
		{
		}
	}
}
