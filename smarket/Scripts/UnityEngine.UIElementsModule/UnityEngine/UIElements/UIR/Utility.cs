using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements.UIR
{
	[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRendererUtility.h")]
	[VisibleToOtherModules(new string[] { "Unity.UIElements" })]
	internal class Utility
	{
		internal enum GPUBufferType
		{
			Vertex = 0,
			Index = 1
		}

		public class GPUBuffer<T> : IDisposable where T : struct
		{
			private IntPtr buffer;

			private int elemCount;

			private int elemStride;

			public int ElementStride => 0;

			internal IntPtr BufferPointer => (IntPtr)0;

			public GPUBuffer(int elementCount, GPUBufferType type)
			{
			}

			public void Dispose()
			{
			}

			public void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax)
			{
			}
		}

		private static ProfilerMarker s_MarkerRaiseEngineUpdate;

		public static event Action<bool> GraphicsResourcesRecreate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action EngineUpdate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action FlushPendingResources
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void SetVectorArray(IntPtr shaderPropertySheet, int nameID, Vector4[] vector4s)
		{
		}

		[RequiredByNativeCode]
		internal static void RaiseGraphicsResourcesRecreate(bool recreate)
		{
		}

		[RequiredByNativeCode]
		internal static void RaiseEngineUpdate()
		{
		}

		[RequiredByNativeCode]
		internal static void RaiseFlushPendingResources()
		{
		}

		[ThreadSafe]
		private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer)
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		private static void FreeBuffer(IntPtr buffer)
		{
		}

		[ThreadSafe]
		private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd)
		{
		}

		[ThreadSafe]
		private static void SetVectorArray(IntPtr shaderPropertySheet, int name, Vector4[] values, int count)
		{
		}

		[ThreadSafe]
		public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes)
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		public unsafe static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl)
		{
		}

		[ThreadSafe]
		public static IntPtr AllocateShaderPropertySheet()
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		public static void SetAllTextures(IntPtr shaderPropertySheet, IntPtr textureNames, IntPtr texturePtrs, int count)
		{
		}

		[ThreadSafe]
		public static void SetPropertyBlock(MaterialPropertyBlock props)
		{
		}

		[ThreadSafe]
		public static void ApplyShaderPropertySheet(IntPtr shaderPropertySheet)
		{
		}

		[ThreadSafe]
		public static void ReleasePropertySheet(IntPtr shaderPropertySheet)
		{
		}

		[ThreadSafe]
		public static void SetScissorRect(RectInt scissorRect)
		{
		}

		[ThreadSafe]
		public static void DisableScissor()
		{
		}

		[ThreadSafe]
		public static IntPtr CreateStencilState(StencilState stencilState)
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		public static void SetStencilState(IntPtr stencilState, int stencilRef)
		{
		}

		[ThreadSafe]
		public static bool HasMappedBufferRange()
		{
			return false;
		}

		[ThreadSafe]
		public static uint InsertCPUFence()
		{
			return 0u;
		}

		[ThreadSafe]
		public static bool CPUFencePassed(uint fence)
		{
			return false;
		}

		[ThreadSafe]
		public static void WaitForCPUFencePassed(uint fence)
		{
		}

		[ThreadSafe]
		public static void SyncRenderThread()
		{
		}

		[ThreadSafe]
		public static RectInt GetActiveViewport()
		{
			return default(RectInt);
		}

		[ThreadSafe]
		public static void ProfileDrawChainBegin()
		{
		}

		[ThreadSafe]
		public static void ProfileDrawChainEnd()
		{
		}

		public static void NotifyOfUIREvents(bool subscribe)
		{
		}

		[ThreadSafe]
		public static Matrix4x4 GetUnityProjectionMatrix()
		{
			return default(Matrix4x4);
		}

		private static void SetVectorArray_Injected(IntPtr shaderPropertySheet, int name, ref ManagedSpanWrapper values, int count)
		{
		}

		private static IntPtr GetVertexDeclaration_Injected(ref ManagedSpanWrapper vertexAttributes)
		{
			return (IntPtr)0;
		}

		private static void SetPropertyBlock_Injected(IntPtr props)
		{
		}

		private static void SetScissorRect_Injected([In] ref RectInt scissorRect)
		{
		}

		private static IntPtr CreateStencilState_Injected([In] ref StencilState stencilState)
		{
			return (IntPtr)0;
		}

		private static void GetActiveViewport_Injected(out RectInt ret)
		{
			ret = default(RectInt);
		}

		private static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}
	}
}
