namespace UnityEngine.UIElements.Layout
{
	internal struct LayoutCachedMeasurement
	{
		public static LayoutCachedMeasurement Default;

		public float AvailableWidth;

		public float AvailableHeight;

		public float ParentWidth;

		public float ParentHeight;

		public LayoutMeasureMode WidthMeasureMode;

		public LayoutMeasureMode HeightMeasureMode;

		public float ComputedWidth;

		public float ComputedHeight;

		private unsafe void* m_NextMeasurementCachePtr;

		public unsafe LayoutCachedMeasurement* NextMeasurementCache => null;

		public override readonly string ToString()
		{
			return null;
		}
	}
}
