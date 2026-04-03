using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct MultiParentConstraintJob : IWeightedAnimationJob, IAnimationJob
	{
		private const float k_Epsilon = 1E-05f;

		public ReadWriteTransformHandle driven;

		public ReadOnlyTransformHandle drivenParent;

		public NativeArray<ReadOnlyTransformHandle> sourceTransforms;

		public NativeArray<PropertyStreamHandle> sourceWeights;

		public NativeArray<AffineTransform> sourceOffsets;

		public NativeArray<float> weightBuffer;

		public Vector3 positionAxesMask;

		public Vector3 rotationAxesMask;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}
	}
}
