using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct MultiRotationConstraintJob : IWeightedAnimationJob, IAnimationJob
	{
		private const float k_Epsilon = 1E-05f;

		public ReadWriteTransformHandle driven;

		public ReadOnlyTransformHandle drivenParent;

		public Vector3Property drivenOffset;

		public NativeArray<ReadOnlyTransformHandle> sourceTransforms;

		public NativeArray<PropertyStreamHandle> sourceWeights;

		public NativeArray<Quaternion> sourceOffsets;

		public NativeArray<float> weightBuffer;

		public Vector3 axesMask;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}
	}
}
