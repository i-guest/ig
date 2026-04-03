namespace UnityEngine.Rendering
{
	public struct OcclusionCullingSettings
	{
		public int viewInstanceID;

		public OcclusionTest occlusionTest;

		public int instanceMultiplier;

		public OcclusionCullingSettings(int viewInstanceID, OcclusionTest occlusionTest)
		{
			this.viewInstanceID = 0;
			this.occlusionTest = default(OcclusionTest);
			instanceMultiplier = 0;
		}
	}
}
