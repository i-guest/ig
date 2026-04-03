using System;

namespace UnityEngine.LowLevelPhysics2D
{
	public readonly struct PhysicsJoint : IEquatable<PhysicsJoint>
	{
		public enum JointType
		{
			DistanceJoint = 0,
			IgnoreJoint = 1,
			RelativeJoint = 2,
			SliderJoint = 3,
			HingeJoint = 4,
			FixedJoint = 5,
			WheelJoint = 6
		}

		private readonly int index1;

		private readonly ushort world0;

		private readonly ushort generation;

		public bool isValid => false;

		public JointType jointType => default(JointType);

		public object callbackTarget => null;

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(PhysicsJoint other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
