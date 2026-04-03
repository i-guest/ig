using Unity.Burst;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	public struct OverrideTransformJob : IWeightedAnimationJob, IAnimationJob
	{
		public enum Space
		{
			World = 0,
			Local = 1,
			Pivot = 2
		}

		public ReadWriteTransformHandle driven;

		public ReadOnlyTransformHandle source;

		public AffineTransform sourceInvLocalBindTx;

		public Quaternion sourceToWorldRot;

		public Quaternion sourceToLocalRot;

		public Quaternion sourceToPivotRot;

		public CacheIndex spaceIdx;

		public CacheIndex sourceToCurrSpaceRotIdx;

		public Vector3Property position;

		public Vector3Property rotation;

		public FloatProperty positionWeight;

		public FloatProperty rotationWeight;

		public AnimationJobCache cache;

		public FloatProperty jobWeight { get; set; }

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}

		internal void UpdateSpace(int space)
		{
		}
	}
}
