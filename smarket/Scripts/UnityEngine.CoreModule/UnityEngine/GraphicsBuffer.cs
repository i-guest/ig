using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
	[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
	[UsedByNativeCode]
	public sealed class GraphicsBuffer : IDisposable
	{
		[Flags]
		public enum Target
		{
			Vertex = 1,
			Index = 2,
			CopySource = 4,
			CopyDestination = 8,
			Structured = 0x10,
			Raw = 0x20,
			Append = 0x40,
			Counter = 0x80,
			IndirectArguments = 0x100,
			Constant = 0x200
		}

		[Flags]
		public enum UsageFlags
		{
			None = 0,
			LockBufferForWrite = 1
		}

		public struct IndirectDrawIndexedArgs
		{
			public const int size = 20;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private uint _003CindexCountPerInstance_003Ek__BackingField;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private uint _003CinstanceCount_003Ek__BackingField;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private uint _003CstartIndex_003Ek__BackingField;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private uint _003CbaseVertexIndex_003Ek__BackingField;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private uint _003CstartInstance_003Ek__BackingField;

			public uint indexCountPerInstance
			{
				[CompilerGenerated]
				set
				{
					_003CindexCountPerInstance_003Ek__BackingField = value;
				}
			}

			public uint instanceCount
			{
				[CompilerGenerated]
				set
				{
					_003CinstanceCount_003Ek__BackingField = value;
				}
			}

			public uint startIndex
			{
				[CompilerGenerated]
				set
				{
					_003CstartIndex_003Ek__BackingField = value;
				}
			}

			public uint baseVertexIndex
			{
				[CompilerGenerated]
				set
				{
					_003CbaseVertexIndex_003Ek__BackingField = value;
				}
			}
		}

		internal static class BindingsMarshaller
		{
			public static GraphicsBuffer ConvertToManaged(IntPtr ptr)
			{
				return null;
			}

			public static IntPtr ConvertToNative(GraphicsBuffer graphicsBuffer)
			{
				return (IntPtr)0;
			}
		}

		internal IntPtr m_Ptr;

		public int count => 0;

		public int stride => 0;

		public UsageFlags usageFlags => default(UsageFlags);

		public GraphicsBufferHandle bufferHandle => default(GraphicsBufferHandle);

		public string name
		{
			set
			{
			}
		}

		~GraphicsBuffer()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		private static bool RequiresCompute(Target target)
		{
			return false;
		}

		private static bool IsVertexIndexOrCopyOnly(Target target)
		{
			return false;
		}

		[FreeFunction("GraphicsBuffer_Bindings::InitBuffer")]
		private static IntPtr InitBuffer(Target target, UsageFlags usageFlags, int count, int stride)
		{
			return (IntPtr)0;
		}

		[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
		private static void DestroyBuffer(GraphicsBuffer buf)
		{
		}

		private GraphicsBuffer(IntPtr ptr)
		{
		}

		public GraphicsBuffer(Target target, int count, int stride)
		{
		}

		public GraphicsBuffer(Target target, UsageFlags usageFlags, int count, int stride)
		{
		}

		private void InternalInitialization(Target target, UsageFlags usageFlags, int count, int stride)
		{
		}

		public void Release()
		{
		}

		[FreeFunction("GraphicsBuffer_Bindings::IsValidBuffer")]
		private static bool IsValidBuffer(GraphicsBuffer buf)
		{
			return false;
		}

		public bool IsValid()
		{
			return false;
		}

		[FreeFunction(Name = "GraphicsBuffer_Bindings::GetUsageFlags", HasExplicitThis = true)]
		private UsageFlags GetUsageFlags()
		{
			return default(UsageFlags);
		}

		public void SetData(Array data)
		{
		}

		public void SetData<T>(NativeArray<T> data) where T : struct
		{
		}

		public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
		}

		public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
		}

		[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
		}

		[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalGetData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
		}

		private unsafe void* BeginBufferWrite(int offset = 0, int size = 0)
		{
			return null;
		}

		public NativeArray<T> LockBufferForWrite<T>(int bufferStartIndex, int count) where T : struct
		{
			return default(NativeArray<T>);
		}

		private void EndBufferWrite(int bytesWritten = 0)
		{
		}

		public void UnlockBufferAfterWrite<T>(int countWritten) where T : struct
		{
		}

		[FreeFunction(Name = "GraphicsBuffer_Bindings::SetName", HasExplicitThis = true)]
		private void SetName(string name)
		{
		}

		private static void DestroyBuffer_Injected(IntPtr buf)
		{
		}

		private static bool IsValidBuffer_Injected(IntPtr buf)
		{
			return false;
		}

		private static int get_count_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int get_stride_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static UsageFlags GetUsageFlags_Injected(IntPtr _unity_self)
		{
			return default(UsageFlags);
		}

		private static void get_bufferHandle_Injected(IntPtr _unity_self, out GraphicsBufferHandle ret)
		{
			ret = default(GraphicsBufferHandle);
		}

		private static void InternalSetNativeData_Injected(IntPtr _unity_self, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		private static void InternalSetData_Injected(IntPtr _unity_self, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		private static void InternalGetData_Injected(IntPtr _unity_self, Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
		}

		private unsafe static void* BeginBufferWrite_Injected(IntPtr _unity_self, int offset, int size)
		{
			return null;
		}

		private static void EndBufferWrite_Injected(IntPtr _unity_self, int bytesWritten)
		{
		}

		private static void SetName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
		}
	}
}
