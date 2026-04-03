using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct TwistCorrectionJob : IWeightedAnimationJob, IAnimationJob
	{
		public ReadOnlyTransformHandle source;

		public Quaternion sourceInverseBindRotation;

		public Vector3 axisMask;

		public NativeArray<ReadWriteTransformHandle> twistTransforms;

		public NativeArray<PropertyStreamHandle> twistWeights;

		public NativeArray<Quaternion> twistBindRotations;

		public NativeArray<float> weightBuffer;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}

		private static Quaternion TwistRotation(Vector3 axis, Quaternion rot)
		{
			return default(Quaternion);
		}
	}
}
