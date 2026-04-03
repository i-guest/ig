using System;

namespace UnityEngine.Rendering
{
	internal struct SharedInstanceHandle : IEquatable<SharedInstanceHandle>, IComparable<SharedInstanceHandle>
	{
		public static readonly SharedInstanceHandle Invalid;

		public int index { get; set; }

		public bool valid => false;

		public bool Equals(SharedInstanceHandle other)
		{
			return false;
		}

		public int CompareTo(SharedInstanceHandle other)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
