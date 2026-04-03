using System;
using System.Runtime.CompilerServices;
using Unity.IntegerTime;
using UnityEngine.Audio;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StaticAccessor("AudioClipBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	public sealed class AudioClip : AudioResource, IAudioGenerator, GeneratorInstance.ICapabilities
	{
		public delegate void PCMReaderCallback(float[] data);

		public delegate void PCMSetPositionCallback(int position);

		[NativeProperty("LengthSec")]
		public float length => 0f;

		[NativeProperty("SampleCount")]
		public int samples => 0;

		[NativeProperty("ChannelCount")]
		public int channels => 0;

		public int frequency => 0;

		bool GeneratorInstance.ICapabilities.isRealtime => false;

		bool GeneratorInstance.ICapabilities.isFinite => false;

		DiscreteTime? GeneratorInstance.ICapabilities.length => null;

		private event PCMReaderCallback m_PCMReaderCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private event PCMSetPositionCallback m_PCMSetPositionCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private AudioClip()
		{
		}

		private static bool GetData([NotNull] AudioClip clip, Span<float> data, int samplesOffset)
		{
			return false;
		}

		private static bool SetData([NotNull] AudioClip clip, ReadOnlySpan<float> data, int samplesOffset)
		{
			return false;
		}

		private static AudioClip Construct_Internal()
		{
			return null;
		}

		private string GetName()
		{
			return null;
		}

		private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
		}

		public bool GetData(float[] data, int offsetSamples)
		{
			return false;
		}

		public bool SetData(float[] data, int offsetSamples)
		{
			return false;
		}

		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
			return null;
		}

		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback)
		{
			return null;
		}

		[RequiredByNativeCode]
		private void InvokePCMReaderCallback_Internal(float[] data)
		{
		}

		[RequiredByNativeCode]
		private void InvokePCMSetPositionCallback_Internal(int position)
		{
		}

		GeneratorInstance IAudioGenerator.CreateInstance(ControlContext context, AudioFormat? nestedFormat, ProcessorInstance.CreationParameters parameters)
		{
			return default(GeneratorInstance);
		}

		private static bool GetData_Injected(IntPtr clip, ref ManagedSpanWrapper data, int samplesOffset)
		{
			return false;
		}

		private static bool SetData_Injected(IntPtr clip, ref ManagedSpanWrapper data, int samplesOffset)
		{
			return false;
		}

		private static IntPtr Construct_Internal_Injected()
		{
			return (IntPtr)0;
		}

		private static void GetName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void CreateUserSound_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, int lengthSamples, int channels, int frequency, bool stream)
		{
		}

		private static float get_length_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static int get_samples_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_channels_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_frequency_Injected(IntPtr _unity_self)
		{
			return 0;
		}
	}
}
