namespace UnityEngine.AI
{
	public struct NavMeshQueryFilter
	{
		internal float[] costs { get; }

		public int areaMask { get; }

		public int agentTypeID { get; }
	}
}
