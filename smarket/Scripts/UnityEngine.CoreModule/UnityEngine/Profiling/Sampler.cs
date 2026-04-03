using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
	public class Sampler
	{
		internal IntPtr m_Ptr;

		internal static Sampler s_InvalidSampler;

		public bool isValid => false;

		internal Sampler()
		{
		}

		internal Sampler(IntPtr ptr)
		{
		}

		public Recorder GetRecorder()
		{
			return null;
		}
	}
}
