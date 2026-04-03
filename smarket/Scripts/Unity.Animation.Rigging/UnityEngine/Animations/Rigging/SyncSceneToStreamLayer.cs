using System.Collections.Generic;

namespace UnityEngine.Animations.Rigging
{
	internal class SyncSceneToStreamLayer
	{
		public IAnimationJob job;

		private IAnimationJobData m_Data;

		private List<int> m_RigIndices;

		public bool isInitialized { get; private set; }

		public bool Initialize(Animator animator, IList<IRigLayer> layers)
		{
			return false;
		}

		public void Update(IList<IRigLayer> layers)
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
