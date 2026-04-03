using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.SubsystemsImplementation;

namespace UnityEngine.AdaptivePerformance.Provider
{
	public sealed class AdaptivePerformanceSubsystemDescriptor : SubsystemDescriptorWithProvider<AdaptivePerformanceSubsystem, AdaptivePerformanceSubsystem.APProvider>
	{
		public struct Cinfo
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Type _003CsubsystemImplementationType_003Ek__BackingField;

			public string id { get; set; }

			public Type providerType { get; set; }

			public Type subsystemTypeOverride { get; set; }
		}

		public AdaptivePerformanceSubsystemDescriptor(Cinfo cinfo)
		{
		}

		public static AdaptivePerformanceSubsystemDescriptor RegisterDescriptor(Cinfo cinfo)
		{
			return null;
		}
	}
}
