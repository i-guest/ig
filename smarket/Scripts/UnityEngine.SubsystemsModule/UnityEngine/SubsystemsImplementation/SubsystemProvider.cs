namespace UnityEngine.SubsystemsImplementation
{
	public abstract class SubsystemProvider
	{
		internal bool m_Running;
	}
	public abstract class SubsystemProvider<TSubsystem> : SubsystemProvider where TSubsystem : new()
	{
		public abstract void Stop();

		public abstract void Destroy();
	}
}
