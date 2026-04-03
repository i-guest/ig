using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct TwistChainConstraintJob : IWeightedAnimationJob, IAnimationJob
	{
		public ReadWriteTransformHandle rootTarget;

		public ReadWriteTransformHandle tipTarget;

		public NativeArray<ReadWriteTransformHandle> chain;

		public NativeArray<float> steps;

		public NativeArray<float> weights;

		public NativeArray<Quaternion> rotations;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}
	}
}
