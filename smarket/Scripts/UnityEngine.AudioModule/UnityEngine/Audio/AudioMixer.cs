using System;
using UnityEngine.Bindings;

namespace UnityEngine.Audio
{
	[ExcludeFromObjectFactory]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
	[ExcludeFromPreset]
	[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
	public class AudioMixer : Object
	{
		[NativeMethod]
		public bool SetFloat(string name, float value)
		{
			return false;
		}

		[NativeMethod]
		public bool GetFloat(string name, out float value)
		{
			value = default(float);
			return false;
		}

		private static bool SetFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value)
		{
			return false;
		}

		private static bool GetFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, out float value)
		{
			value = default(float);
			return false;
		}
	}
}
