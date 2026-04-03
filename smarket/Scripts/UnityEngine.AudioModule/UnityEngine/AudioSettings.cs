using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
	public sealed class AudioSettings
	{
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static AudioConfigurationChangeHandler OnAudioConfigurationChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnAudioSystemShuttingDown;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action OnAudioSystemStartedUp;

		[RequiredByNativeCode]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemShuttingDown()
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemStartedUp()
		{
		}
	}
}
