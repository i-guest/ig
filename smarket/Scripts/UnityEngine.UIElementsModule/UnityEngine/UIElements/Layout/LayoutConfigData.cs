namespace UnityEngine.UIElements.Layout
{
	internal struct LayoutConfigData
	{
		public float PointScaleFactor;

		public int ManagedMeasureFunctionIndex;

		public int ManagedBaselineFunctionIndex;

		public bool ShouldLog;

		public static LayoutConfigData Default => default(LayoutConfigData);
	}
}
