using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct ChainIKConstraintJob : IWeightedAnimationJob, IAnimationJob
	{
		public NativeArray<ReadWriteTransformHandle> chain;

		public ReadOnlyTransformHandle target;

		public AffineTransform targetOffset;

		public NativeArray<float> linkLengths;

		public NativeArray<Vector3> linkPositions;

		public FloatProperty chainRotationWeight;

		public FloatProperty tipRotationWeight;

		public CacheIndex toleranceIdx;

		public CacheIndex maxIterationsIdx;

		public AnimationJobCache cache;

		public float maxReach;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}
	}
}
