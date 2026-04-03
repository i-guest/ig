using System;

namespace UnityEngine.SceneManagement
{
	[Serializable]
	public struct LoadSceneParameters
	{
		[SerializeField]
		private LoadSceneMode m_LoadSceneMode;

		[SerializeField]
		private LocalPhysicsMode m_LocalPhysicsMode;

		public LoadSceneParameters(LoadSceneMode mode)
		{
			m_LoadSceneMode = default(LoadSceneMode);
			m_LocalPhysicsMode = default(LocalPhysicsMode);
		}
	}
}
