namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	[StaticAccessor("Marshalling::BindingsAllocator", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Scripting/Marshalling/BindingsAllocator.h")]
	internal static class BindingsAllocator
	{
		private struct NativeOwnedMemory
		{
			public unsafe void* data;
		}

		[ThreadSafe]
		public unsafe static void Free(void* ptr)
		{
		}

		[ThreadSafe]
		public unsafe static void FreeNativeOwnedMemory(void* ptr)
		{
		}

		public unsafe static void* GetNativeOwnedDataPointer(void* ptr)
		{
			return null;
		}
	}
}
