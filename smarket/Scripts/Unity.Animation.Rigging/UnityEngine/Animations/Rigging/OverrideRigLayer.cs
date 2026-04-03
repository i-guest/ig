using System;
using UnityEngine.Serialization;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public class OverrideRigLayer : IRigLayer
	{
		[SerializeField]
		[FormerlySerializedAs("rig")]
		private Rig m_Rig;

		[SerializeField]
		[FormerlySerializedAs("active")]
		private bool m_Active;

		private IRigConstraint[] m_Constraints;

		private IAnimationJob[] m_Jobs;

		public Rig rig
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool active
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string name => null;

		public IRigConstraint[] constraints => null;

		public IAnimationJob[] jobs => null;

		public bool isInitialized { get; private set; }

		public OverrideRigLayer(Rig rig, IRigConstraint[] constraints, bool active = true)
		{
		}

		public bool Initialize(Animator animator)
		{
			return false;
		}

		public void Update()
		{
		}

		public void Reset()
		{
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
