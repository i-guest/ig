using System;
using Unity.IntegerTime;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
	public struct GeneratorInstance : IEquatable<GeneratorInstance>
	{
		public interface ICapabilities
		{
			bool isFinite { get; }

			bool isRealtime { get; }

			DiscreteTime? length { get; }
		}

		public readonly struct Setup
		{
			public readonly AudioSpeakerMode speakerMode;

			public readonly int sampleRate;
		}

		public struct Properties
		{
			private byte m_Reserved;
		}

		public struct Configuration
		{
			internal Setup Setup;

			internal Properties Properties;

			internal DiscreteTime ReportedLength;

			internal bool IsFinite;

			internal bool IsRealtime;

			internal bool HasKnownLength;

			public bool isRealtime => false;

			public DiscreteTime? length => null;
		}

		[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ScriptBindings/GeneratorHandle.h")]
		[RequiredByNativeCode]
		internal struct GeneratorHeader
		{
			internal ProcessorHeader Processor;

			internal Configuration Configuration;
		}

		internal readonly ProcessorInstance m_ProcessorInstance;

		public static implicit operator ProcessorInstance(in GeneratorInstance generatorInstance)
		{
			return default(ProcessorInstance);
		}

		public bool Equals(GeneratorInstance other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
