namespace UnityEngine.Experimental.GlobalIllumination
{
	public struct Cookie
	{
		public EntityId entityId;

		public float scale;

		public Vector2 sizes;

		public static Cookie Defaults()
		{
			return default(Cookie);
		}
	}
}
