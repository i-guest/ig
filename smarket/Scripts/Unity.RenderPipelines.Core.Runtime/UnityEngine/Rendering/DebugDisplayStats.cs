using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public abstract class DebugDisplayStats<TProfileId> where TProfileId : Enum
	{
		private class AccumulatedTiming
		{
			public float accumulatedValue;

			public float lastAverage;

			internal void UpdateLastAverage(int frameCount)
			{
			}
		}

		private enum DebugProfilingType
		{
			CPU = 0,
			InlineCPU = 1,
			GPU = 2
		}

		private static readonly string[] k_DetailedStatsColumnLabels;

		private Dictionary<TProfileId, AccumulatedTiming>[] m_AccumulatedTiming;

		private float m_TimeSinceLastAvgValue;

		private int m_AccumulatedFrames;

		private HashSet<TProfileId> m_HiddenProfileIds;

		private const float k_AccumulationTimeInSeconds = 1f;

		protected bool averageProfilerTimingsOverASecond;

		protected bool hideEmptyScopes;

		public abstract void EnableProfilingRecorders();

		public abstract void DisableProfilingRecorders();

		public abstract void RegisterDebugUI(List<DebugUI.Widget> list);

		public abstract void Update();

		protected List<TProfileId> GetProfilerIdsToDisplay()
		{
			return null;
		}

		protected void UpdateDetailedStats(List<TProfileId> samplers)
		{
		}

		protected DebugUI.Widget BuildDetailedStatsList(string title, List<TProfileId> samplers)
		{
			return null;
		}

		private void UpdateListOfAveragedProfilerTimings(bool needUpdatingAverages, List<TProfileId> samplers)
		{
		}

		private float GetSamplerTiming(TProfileId samplerId, ProfilingSampler sampler, DebugProfilingType type)
		{
			return 0f;
		}

		private ObservableList<DebugUI.Widget> BuildProfilingSamplerWidgetList(IEnumerable<TProfileId> samplers)
		{
			return null;
		}
	}
}
