namespace UnityEngine
{
	public struct QueryParameters
	{
		public int layerMask;

		public bool hitMultipleFaces;

		public QueryTriggerInteraction hitTriggers;

		public bool hitBackfaces;

		public QueryParameters(int layerMask = -5, bool hitMultipleFaces = false, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal, bool hitBackfaces = false)
		{
			this.layerMask = 0;
			this.hitMultipleFaces = false;
			this.hitTriggers = default(QueryTriggerInteraction);
			this.hitBackfaces = false;
		}
	}
}
