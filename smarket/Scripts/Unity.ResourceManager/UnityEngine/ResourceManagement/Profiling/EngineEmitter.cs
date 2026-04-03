using System;

namespace UnityEngine.ResourceManagement.Profiling
{
	public class EngineEmitter : IProfilerEmitter
	{
		public bool IsEnabled => false;

		public void EmitFrameMetaData(Guid id, int tag, Array data)
		{
		}

		public void InitialiseCallbacks(Action<float> d)
		{
		}
	}
}
