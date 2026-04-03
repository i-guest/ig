using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	internal ref struct BlittableArrayWrapper
	{
		internal enum UpdateFlags
		{
			NoUpdateNeeded = 0,
			SizeChanged = 1,
			DataIsNativePointer = 2,
			DataIsNativeOwnedMemory = 3,
			DataIsEmpty = 4,
			DataIsNull = 5
		}

		internal unsafe void* data;

		internal int size;

		internal UpdateFlags updateFlags;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe BlittableArrayWrapper(void* data, int size)
		{
			this.data = null;
			this.size = 0;
			updateFlags = default(UpdateFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Unmarshal<T>(ref T[] array) where T : struct
		{
		}
	}
}
