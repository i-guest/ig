using System;
using System.Collections.Generic;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct MultiReferentialConstraintData : IAnimationJobData, IMultiReferentialConstraintData
	{
		[SyncSceneToStream]
		[SerializeField]
		private int m_Driver;

		[SyncSceneToStream]
		[SerializeField]
		private List<Transform> m_SourceObjects;

		public int driver
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<Transform> sourceObjects
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		Transform[] IMultiReferentialConstraintData.sourceObjects => null;

		int IMultiReferentialConstraintData.driverValue => 0;

		string IMultiReferentialConstraintData.driverIntProperty => null;

		bool IAnimationJobData.IsValid()
		{
			return false;
		}

		void IAnimationJobData.SetDefaultValues()
		{
		}

		public void UpdateDriver()
		{
		}
	}
}
