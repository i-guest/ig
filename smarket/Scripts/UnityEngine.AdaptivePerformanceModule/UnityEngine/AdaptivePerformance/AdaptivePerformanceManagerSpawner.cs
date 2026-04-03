namespace UnityEngine.AdaptivePerformance
{
	internal class AdaptivePerformanceManagerSpawner : ScriptableObject
	{
		public const string AdaptivePerformanceManagerObjectName = "AdaptivePerformanceManager";

		private GameObject m_ManagerGameObject;

		public GameObject ManagerGameObject => null;

		private void OnEnable()
		{
		}

		public void Initialize(bool isCheckingProvider)
		{
		}

		public void Deinitialize()
		{
		}

		private void InstallScalers()
		{
		}
	}
}
