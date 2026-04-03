namespace UnityEngine.UIElements.Layout
{
	internal struct LayoutValue
	{
		private float value;

		private LayoutUnit unit;

		public LayoutUnit Unit => default(LayoutUnit);

		public float Value => 0f;

		public static LayoutValue Point(float value)
		{
			return default(LayoutValue);
		}

		public bool Equals(LayoutValue other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static LayoutValue Undefined()
		{
			return default(LayoutValue);
		}

		public static LayoutValue Auto()
		{
			return default(LayoutValue);
		}

		public static LayoutValue Percent(float value)
		{
			return default(LayoutValue);
		}

		public static implicit operator LayoutValue(float value)
		{
			return default(LayoutValue);
		}
	}
}
