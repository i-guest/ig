using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Editor
{
	internal struct SampleFrequencyCalculator
	{
		private double m_LastUpdateTime;

		private int m_SampleCount;

		public float targetFrequency { get; private set; }

		public float frequency { get; private set; }

		public SampleFrequencyCalculator(float targetFrequency, double realtimeSinceStartup)
		{
			m_LastUpdateTime = 0.0;
			m_SampleCount = 0;
			this.targetFrequency = 0f;
			frequency = 0f;
		}

		public void ProcessSample(InputEventPtr eventPtr)
		{
		}

		public bool Update()
		{
			return false;
		}

		public bool Update(double realtimeSinceStartup)
		{
			return false;
		}
	}
}
