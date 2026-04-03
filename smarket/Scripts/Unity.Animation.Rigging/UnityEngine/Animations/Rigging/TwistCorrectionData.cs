using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct TwistCorrectionData : IAnimationJobData, ITwistCorrectionData
	{
		public enum Axis
		{
			X = 0,
			Y = 1,
			Z = 2
		}

		[SyncSceneToStream]
		[SerializeField]
		private Transform m_Source;

		[NotKeyable]
		[SerializeField]
		private Axis m_TwistAxis;

		[SyncSceneToStream]
		[SerializeField]
		[WeightRange(-1f, 1f)]
		private WeightedTransformArray m_TwistNodes;

		public Transform sourceObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public WeightedTransformArray twistNodes
		{
			get
			{
				return default(WeightedTransformArray);
			}
			set
			{
			}
		}

		public Axis twistAxis
		{
			get
			{
				return default(Axis);
			}
			set
			{
			}
		}

		Transform ITwistCorrectionData.source => null;

		Vector3 ITwistCorrectionData.twistAxis => default(Vector3);

		string ITwistCorrectionData.twistNodesProperty => null;

		private static Vector3 Convert(Axis axis)
		{
			return default(Vector3);
		}

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}
	}
}
