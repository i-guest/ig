using Unity.Burst;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct TwoBoneIKConstraintJob : IWeightedAnimationJob, IAnimationJob
	{
		public ReadWriteTransformHandle root;

		public ReadWriteTransformHandle mid;

		public ReadWriteTransformHandle tip;

		public ReadOnlyTransformHandle hint;

		public ReadOnlyTransformHandle target;

		public AffineTransform targetOffset;

		public FloatProperty targetPositionWeight;

		public FloatProperty targetRotationWeight;

		public FloatProperty hintWeight;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}
	}
}
