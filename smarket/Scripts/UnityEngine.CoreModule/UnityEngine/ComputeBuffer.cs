using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeClass("GraphicsBuffer")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
	[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
	public sealed class ComputeBuffer : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(ComputeBuffer computeBuffer)
			{
				return (IntPtr)0;
			}
		}

		internal IntPtr m_Ptr;

		public int count => 0;

		public int stride => 0;

		~ComputeBuffer()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		[FreeFunction("GraphicsBuffer_Bindings::InitComputeBuffer")]
		private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage)
		{
			return (IntPtr)0;
		}

		[FreeFunction("GraphicsBuffer_Bindings::DestroyComputeBuffer")]
		private static void DestroyBuffer(ComputeBuffer buf)
		{
		}

		public ComputeBuffer(int count, int stride)
		{
		}

		public ComputeBuffer(int count, int stride, ComputeBufferType type)
		{
		}

		private ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth)
		{
		}

		public void Release()
		{
		}

		public void SetData(Array data)
		{
		}

		public void SetData<T>(NativeArray<T> data) where T : struct
		{
		}

		public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) where T : struct
		{
		}

		[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
		}

		[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
		}

		private static void DestroyBuffer_Injected(IntPtr buf)
		{
		}

		private static int get_count_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_stride_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void InternalSetNativeData_Injected(IntPtr _unity_self, IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
		}

		private static void InternalSetData_Injected(IntPtr _unity_self, Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
		}
	}
}
