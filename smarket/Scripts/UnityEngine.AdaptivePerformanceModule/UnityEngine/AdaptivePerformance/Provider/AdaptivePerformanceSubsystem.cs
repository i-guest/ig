using System;
using UnityEngine.SubsystemsImplementation;

namespace UnityEngine.AdaptivePerformance.Provider
{
	public class AdaptivePerformanceSubsystem : AdaptivePerformanceSubsystemBase<AdaptivePerformanceSubsystem, AdaptivePerformanceSubsystemDescriptor, AdaptivePerformanceSubsystem.APProvider>
	{
		public abstract class APProvider : SubsystemProvider<AdaptivePerformanceSubsystem>
		{
			protected new bool m_Running;

			public abstract Feature Capabilities { get; set; }

			public abstract IApplicationLifecycle ApplicationLifecycle { get; }

			public abstract IDevicePerformanceLevelControl PerformanceLevelControl { get; }

			public abstract Version Version { get; }

			public virtual string Stats => null;

			public abstract bool Initialized { get; set; }

			public abstract PerformanceDataRecord Update();
		}

		public override IApplicationLifecycle ApplicationLifecycle => null;

		public override IDevicePerformanceLevelControl PerformanceLevelControl => null;

		public override Version Version => null;

		public override Feature Capabilities => default(Feature);

		public override string Stats => null;

		public override bool Initialized => false;

		public override PerformanceDataRecord Update()
		{
			return default(PerformanceDataRecord);
		}
	}
}
