using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct MultiReferentialConstraintJob : IWeightedAnimationJob, IAnimationJob
	{
		public IntProperty driver;

		public NativeArray<ReadWriteTransformHandle> sources;

		public NativeArray<AffineTransform> sourceBindTx;

		public NativeArray<AffineTransform> offsetTx;

		private int m_PrevDriverIdx;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}

		internal void UpdateOffsets(int driver)
		{
		}
	}
}
