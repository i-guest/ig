namespace UnityEngine.AdaptivePerformance
{
	internal class RunningAverage
	{
		private float[] m_Values;

		private int m_NumValues;

		private int m_LastIndex;

		private float m_AverageValue;

		public RunningAverage(int sampleWindowSize = 100)
		{
		}

		public int GetNumValues()
		{
			return 0;
		}

		public int GetSampleWindowSize()
		{
			return 0;
		}

		public float GetAverageOr(float defaultValue)
		{
			return 0f;
		}

		public float GetMostRecentValueOr(float defaultValue)
		{
			return 0f;
		}

		public void AddValue(float NewValue)
		{
		}

		public void Reset()
		{
		}
	}
}
