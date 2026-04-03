using System;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[StaticAccessor("AsyncGPUReadbackManager::GetInstance()", StaticAccessorType.Dot)]
	public static class AsyncGPUReadback
	{
		public static AsyncGPUReadbackRequest Request(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback = null)
		{
			return default(AsyncGPUReadbackRequest);
		}

		public static AsyncGPUReadbackRequest Request(GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback = null)
		{
			return default(AsyncGPUReadbackRequest);
		}

		[NativeMethod("Request")]
		private unsafe static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1([NotNull] GraphicsBuffer buffer, AsyncRequestNativeArrayData* data)
		{
			return default(AsyncGPUReadbackRequest);
		}

		[NativeMethod("Request")]
		private unsafe static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_2([NotNull] GraphicsBuffer src, int size, int offset, AsyncRequestNativeArrayData* data)
		{
			return default(AsyncGPUReadbackRequest);
		}

		private unsafe static void Request_Internal_GraphicsBuffer_1_Injected(IntPtr buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			ret = default(AsyncGPUReadbackRequest);
		}

		private unsafe static void Request_Internal_GraphicsBuffer_2_Injected(IntPtr src, int size, int offset, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
		{
			ret = default(AsyncGPUReadbackRequest);
		}
	}
}
