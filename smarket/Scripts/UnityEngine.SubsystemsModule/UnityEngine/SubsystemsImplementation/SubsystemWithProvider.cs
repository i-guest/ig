using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.SubsystemsImplementation
{
	public abstract class SubsystemWithProvider : ISubsystem
	{
		public bool running { get; private set; }

		internal SubsystemProvider providerBase { get; }

		public void Stop()
		{
		}

		protected abstract void OnStop();

		public void Destroy()
		{
		}

		protected abstract void OnDestroy();
	}
	public abstract class SubsystemWithProvider<TSubsystem, TSubsystemDescriptor, TProvider> : SubsystemWithProvider where TSubsystem : new()
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TSubsystemDescriptor _003CsubsystemDescriptor_003Ek__BackingField;

		protected internal TProvider provider { get; }

		protected override void OnStop()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
