using System;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace Unity.Audio
{
	[NativeType(Header = "Modules/Audio/Public/AudioHandle.h")]
	[VisibleToOtherModules(new string[] { "UnityEngine.DSPGraphModule" })]
	internal struct Handle : IEquatable<Handle>
	{
		internal struct Node
		{
			private unsafe void* Next;

			public int Id;

			public int Version;

			public int AllocationFlags;
		}

		[NativeDisableUnsafePtrRestriction]
		private IntPtr m_Node;

		public int Version;

		internal unsafe readonly Node* AtomicNode => null;

		public readonly bool ValidAndNotDisposed => false;

		public readonly bool Equals(Handle other)
		{
			return false;
		}

		public override readonly bool Equals(object obj)
		{
			return false;
		}

		public override readonly int GetHashCode()
		{
			return 0;
		}

		public readonly void CheckValidOrThrow()
		{
		}
	}
}
