namespace UnityEngine.UIElements.Layout
{
	internal readonly struct LayoutHandle
	{
		public readonly int Index;

		public readonly int Version;

		public static LayoutHandle Undefined => default(LayoutHandle);

		internal LayoutHandle(int index, int version)
		{
			Index = 0;
			Version = 0;
		}

		public bool Equals(LayoutHandle other)
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
	}
}
