using System;
using UnityEngine.Bindings;

namespace UnityEngine.Audio
{
	[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
	public class AudioMixerGroup : Object
	{
		[NativeProperty]
		public AudioMixer audioMixer => null;

		internal AudioMixerGroup()
		{
		}

		private static IntPtr get_audioMixer_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}
	}
}
