using System;

namespace UnityEngine.Rendering
{
	internal struct GPUInstanceIndex : IEquatable<GPUInstanceIndex>, IComparable<GPUInstanceIndex>
	{
		public static readonly GPUInstanceIndex Invalid;

		public int index { get; set; }

		public bool valid => false;

		public bool Equals(GPUInstanceIndex other)
		{
			return false;
		}

		public int CompareTo(GPUInstanceIndex other)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
