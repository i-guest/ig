using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Audio;

namespace UnityEngine.Audio
{
	public readonly struct ProcessorInstance : IEquatable<ProcessorInstance>
	{
		public struct CreationParameters
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private UpdateSetting _003CcontrolUpdateSetting_003Ek__BackingField;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private UpdateSetting _003CrealtimeUpdateSetting_003Ek__BackingField;
		}

		public enum UpdateSetting
		{
			Default = 0,
			NeverUpdate = 1,
			UpdateIfDataIsAvailable = 2,
			UpdateAlways = 3
		}

		public ref struct Message
		{
			internal long TypeHash;

			internal unsafe void* Data;

			internal IntPtr ManagedHandle;
		}

		internal readonly Handle Handle;

		internal unsafe readonly ProcessorHeader* Header;

		public bool Equals(ProcessorInstance other)
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
