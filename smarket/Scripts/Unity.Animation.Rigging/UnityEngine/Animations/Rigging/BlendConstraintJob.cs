using Unity.Burst;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct BlendConstraintJob : IWeightedAnimationJob, IAnimationJob
	{
		private const int k_BlendTranslationMask = 1;

		private const int k_BlendRotationMask = 2;

		public ReadWriteTransformHandle driven;

		public ReadOnlyTransformHandle sourceA;

		public ReadOnlyTransformHandle sourceB;

		public AffineTransform sourceAOffset;

		public AffineTransform sourceBOffset;

		public BoolProperty blendPosition;

		public BoolProperty blendRotation;

		public FloatProperty positionWeight;

		public FloatProperty rotationWeight;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}
	}
}
