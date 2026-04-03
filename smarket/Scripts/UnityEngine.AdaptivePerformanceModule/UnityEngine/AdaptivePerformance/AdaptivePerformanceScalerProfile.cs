using System;

namespace UnityEngine.AdaptivePerformance
{
	[Serializable]
	public class AdaptivePerformanceScalerProfile : AdaptivePerformanceScalerSettings
	{
		[SerializeField]
		[Tooltip("Name of the scaler profile.")]
		private string m_Name;

		public string Name => null;
	}
}
