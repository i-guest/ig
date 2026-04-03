using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct MultiAimConstraintJob : IWeightedAnimationJob, IAnimationJob
	{
		public enum WorldUpType
		{
			None = 0,
			SceneUp = 1,
			ObjectUp = 2,
			ObjectRotationUp = 3,
			Vector = 4
		}

		private const float k_Epsilon = 1E-05f;

		public ReadWriteTransformHandle driven;

		public ReadOnlyTransformHandle drivenParent;

		public Vector3Property drivenOffset;

		public NativeArray<ReadOnlyTransformHandle> sourceTransforms;

		public NativeArray<PropertyStreamHandle> sourceWeights;

		public NativeArray<Quaternion> sourceOffsets;

		public NativeArray<float> weightBuffer;

		public Vector3 aimAxis;

		public Vector3 upAxis;

		public WorldUpType worldUpType;

		public Vector3 worldUpAxis;

		public ReadOnlyTransformHandle worldUpObject;

		public Vector3 axesMask;

		public FloatProperty minLimit;

		public FloatProperty maxLimit;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}

		private Vector3 ComputeWorldUpVector(AnimationStream stream)
		{
			return default(Vector3);
		}
	}
}
