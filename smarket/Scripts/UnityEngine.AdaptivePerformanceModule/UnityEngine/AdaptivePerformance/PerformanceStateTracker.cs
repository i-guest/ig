using System.Collections.Generic;

namespace UnityEngine.AdaptivePerformance
{
	internal class PerformanceStateTracker
	{
		private Queue<float> m_Samples;

		private int m_SampleCapacity;

		public float Trend { get; set; }

		public PerformanceStateTracker(int sampleCapacity)
		{
		}

		public StateAction Update()
		{
			return default(StateAction);
		}

		protected virtual float GetEffectiveTargetFrameRate()
		{
			return 0f;
		}
	}
}
