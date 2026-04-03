using System;

namespace UnityEngine
{
	[Obsolete("Use SubsystemDescriptorWithProvider instead.", false)]
	public abstract class SubsystemDescriptor : ISubsystemDescriptor
	{
		public string id { get; }
	}
}
