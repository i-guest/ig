using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public struct SceneInstance
	{
		private Scene m_Scene;

		private bool m_ReleaseOnSceneUnloaded;

		internal AsyncOperation m_Operation;

		public Scene Scene
		{
			get
			{
				return default(Scene);
			}
			internal set
			{
			}
		}

		internal bool ReleaseSceneOnSceneUnloaded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AsyncOperation ActivateAsync()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
