using System;

namespace UnityEngine.AdaptivePerformance
{
	[Serializable]
	public class AdaptivePerformanceIndexerSettings
	{
		private const string m_FeatureName = "Indexer";

		[SerializeField]
		[Tooltip("Active")]
		private bool m_Active;

		[SerializeField]
		[Tooltip("Thermal Action Delay")]
		private float m_ThermalActionDelay;

		[Tooltip("Performance Action Delay")]
		[SerializeField]
		private float m_PerformanceActionDelay;

		public bool active => false;

		public float thermalActionDelay => 0f;

		public float performanceActionDelay => 0f;
	}
}
