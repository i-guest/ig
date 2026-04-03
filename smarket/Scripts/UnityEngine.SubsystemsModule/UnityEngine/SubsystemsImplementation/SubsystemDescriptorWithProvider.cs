using System;

namespace UnityEngine.SubsystemsImplementation
{
	public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor
	{
		public string id { get; set; }

		protected internal Type providerType { get; set; }

		protected internal Type subsystemTypeOverride { get; set; }

		internal abstract void ThrowIfInvalid();
	}
	public class SubsystemDescriptorWithProvider<TSubsystem, TProvider> : SubsystemDescriptorWithProvider where TSubsystem : new()
	{
		internal sealed override void ThrowIfInvalid()
		{
		}
	}
}
