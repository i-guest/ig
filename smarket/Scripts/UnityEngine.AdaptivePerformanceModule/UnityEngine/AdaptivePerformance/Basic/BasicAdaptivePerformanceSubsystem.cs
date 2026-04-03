using System;
using UnityEngine.AdaptivePerformance.Provider;

namespace UnityEngine.AdaptivePerformance.Basic
{
	internal class BasicAdaptivePerformanceSubsystem : AdaptivePerformanceSubsystem
	{
		internal class BasicProvider : APProvider, IApplicationLifecycle, IDevicePerformanceLevelControl
		{
			private PerformanceDataRecord m_UpdatedPerfRecord;

			public override IApplicationLifecycle ApplicationLifecycle => null;

			public override IDevicePerformanceLevelControl PerformanceLevelControl => null;

			public override string Stats => null;

			public override bool Initialized { get; set; }

			public override Feature Capabilities { get; set; }

			public override Version Version => null;

			public int MaxCpuPerformanceLevel => 0;

			public int MaxGpuPerformanceLevel => 0;

			public override void Stop()
			{
			}

			public override void Destroy()
			{
			}

			public override PerformanceDataRecord Update()
			{
				return default(PerformanceDataRecord);
			}

			public void ApplicationPause()
			{
			}

			public void ApplicationResume()
			{
			}

			public bool SetPerformanceLevel(ref int cpuLevel, ref int gpuLevel)
			{
				return false;
			}

			public bool EnableCpuBoost()
			{
				return false;
			}

			public bool EnableGpuBoost()
			{
				return false;
			}
		}
	}
}
