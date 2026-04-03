using Unity.Burst;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct DampedTransformJob : IWeightedAnimationJob, IAnimationJob
	{
		private const float k_FixedDt = 0.01667f;

		private const float k_DampFactor = 40f;

		public ReadWriteTransformHandle driven;

		public ReadOnlyTransformHandle source;

		public AffineTransform localBindTx;

		public Vector3 aimBindAxis;

		public AffineTransform prevDrivenTx;

		public FloatProperty dampPosition;

		public FloatProperty dampRotation;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}
	}
}
