using System;

namespace UnityEngine.Rendering
{
	internal struct InstanceHandle : IEquatable<InstanceHandle>, IComparable<InstanceHandle>
	{
		public static readonly InstanceHandle Invalid;

		public int index { get; private set; }

		public int instanceIndex => 0;

		public InstanceType type => default(InstanceType);

		public bool valid => false;

		public static InstanceHandle Create(int instanceIndex, InstanceType instanceType)
		{
			return default(InstanceHandle);
		}

		public static InstanceHandle FromInt(int value)
		{
			return default(InstanceHandle);
		}

		public bool Equals(InstanceHandle other)
		{
			return false;
		}

		public int CompareTo(InstanceHandle other)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
