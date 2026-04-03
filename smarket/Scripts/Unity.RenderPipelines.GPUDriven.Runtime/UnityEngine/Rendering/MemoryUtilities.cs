using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal static class MemoryUtilities
	{
		public unsafe static T* Malloc<T>(int count, Allocator allocator) where T : unmanaged
		{
			return null;
		}

		public unsafe static void Free<T>(T* p, Allocator allocator) where T : unmanaged
		{
		}
	}
}
