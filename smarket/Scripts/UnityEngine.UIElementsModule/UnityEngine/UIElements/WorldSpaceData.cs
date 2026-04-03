namespace UnityEngine.UIElements
{
	internal struct WorldSpaceData
	{
		public static readonly Bounds k_Empty3DBounds;

		public Bounds localBounds3D;

		public Bounds localBoundsPicking3D;

		public Bounds localBoundsWithoutNested3D;

		public Rect boundingBoxWithoutNested;
	}
}
