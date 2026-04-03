namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal struct GeometryPoolEntryInfo
	{
		public bool valid;

		public uint refCount;

		public static GeometryPoolEntryInfo NewDefault()
		{
			return default(GeometryPoolEntryInfo);
		}
	}
}
