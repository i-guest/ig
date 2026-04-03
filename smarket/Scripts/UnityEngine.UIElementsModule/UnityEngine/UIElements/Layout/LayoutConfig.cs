namespace UnityEngine.UIElements.Layout
{
	internal readonly struct LayoutConfig
	{
		private readonly LayoutDataAccess m_Access;

		private readonly LayoutHandle m_Handle;

		public static LayoutConfig Undefined => default(LayoutConfig);

		public LayoutHandle Handle => default(LayoutHandle);

		public ref float PointScaleFactor
		{
			get
			{
				throw null;
			}
		}

		public LayoutMeasureFunction Measure
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LayoutBaselineFunction Baseline => null;

		internal LayoutConfig(LayoutDataAccess access, LayoutHandle handle)
		{
			m_Access = default(LayoutDataAccess);
			m_Handle = default(LayoutHandle);
		}
	}
}
