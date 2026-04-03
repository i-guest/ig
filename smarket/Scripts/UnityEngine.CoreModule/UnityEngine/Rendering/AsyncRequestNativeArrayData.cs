using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
	internal struct AsyncRequestNativeArrayData
	{
		public unsafe void* nativeArrayBuffer;

		public long lengthInBytes;

		public static AsyncRequestNativeArrayData CreateAndCheckAccess<T>(NativeArray<T> array) where T : struct
		{
			return default(AsyncRequestNativeArrayData);
		}
	}
}
