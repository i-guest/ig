using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
	[RequireComponent(typeof(Transform))]
	public sealed class AudioSource : AudioBehaviour
	{
		public float volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("SecPosition")]
		public float time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AudioClip clip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Object generatorObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isPlaying
		{
			[NativeName("IsPlayingScripting")]
			get
			{
				return false;
			}
		}

		public bool loop
		{
			set
			{
			}
		}

		public bool playOnAwake
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("SpatialBlendMix")]
		public float spatialBlend
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private static float GetPitch([NotNull] AudioSource source)
		{
			return 0f;
		}

		private static void SetPitch([NotNull] AudioSource source, float pitch)
		{
		}

		private static void PlayHelper([NotNull] AudioSource source, ulong delay)
		{
		}

		private static void PlayOneShotHelper([NotNull] AudioSource source, [NotNull] AudioClip clip, float volumeScale)
		{
		}

		private void Stop(bool stopOneShots)
		{
		}

		[ExcludeFromDocs]
		public void Play()
		{
		}

		[ExcludeFromDocs]
		public void PlayOneShot(AudioClip clip)
		{
		}

		public void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale)
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		[ExcludeFromDocs]
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position)
		{
		}

		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, [DefaultValue("1.0F")] float volume)
		{
		}

		private static float GetPitch_Injected(IntPtr source)
		{
			return 0f;
		}

		private static void SetPitch_Injected(IntPtr source, float pitch)
		{
		}

		private static void PlayHelper_Injected(IntPtr source, ulong delay)
		{
		}

		private static void PlayOneShotHelper_Injected(IntPtr source, IntPtr clip, float volumeScale)
		{
		}

		private static void Stop_Injected(IntPtr _unity_self, bool stopOneShots)
		{
		}

		private static float get_volume_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_volume_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_time_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_time_Injected(IntPtr _unity_self, float value)
		{
		}

		private static IntPtr get_generatorObject_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_generatorObject_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static void Pause_Injected(IntPtr _unity_self)
		{
		}

		private static bool get_isPlaying_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_loop_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_playOnAwake_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_playOnAwake_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static float get_spatialBlend_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_spatialBlend_Injected(IntPtr _unity_self, float value)
		{
		}
	}
}
