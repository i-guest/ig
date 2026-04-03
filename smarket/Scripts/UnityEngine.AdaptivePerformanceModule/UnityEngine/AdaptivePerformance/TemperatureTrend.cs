namespace UnityEngine.AdaptivePerformance
{
	internal class TemperatureTrend
	{
		private bool m_UseProviderTrend;

		private double m_SumX;

		private double m_SumY;

		private double m_SumXY;

		private double m_SumXX;

		private const int MeasurementTimeframeSeconds = 20;

		private const int UpdateFrequency = 10;

		private const int SamplesCapacity = 200;

		private const double SlopeAtMaxTrend = 0.005;

		private float[] m_TimeStamps;

		private float[] m_Temperature;

		private int m_NumValues;

		private int m_NextValueIndex;

		private int m_OldestValueIndex;

		public float ThermalTrend { get; private set; }

		private void PopOldestValue()
		{
		}

		private void PushNewValue(float tempLevel, float timestamp)
		{
		}

		public TemperatureTrend(bool useProviderTrend)
		{
		}

		public void Reset()
		{
		}

		private void UpdateTrend()
		{
		}

		public void Update(float temperatureTrendFromProvider, float newTemperatureLevel, bool changed, float newTemperatureTimestamp)
		{
		}
	}
}
