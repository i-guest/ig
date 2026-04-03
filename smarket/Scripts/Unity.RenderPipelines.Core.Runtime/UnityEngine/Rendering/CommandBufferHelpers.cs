using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.VFX;

namespace UnityEngine.Rendering
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct CommandBufferHelpers
	{
		internal static RasterCommandBuffer rasterCmd;

		internal static ComputeCommandBuffer computeCmd;

		internal static UnsafeCommandBuffer unsafeCmd;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static RasterCommandBuffer GetRasterCommandBuffer(CommandBuffer baseBuffer)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ComputeCommandBuffer GetComputeCommandBuffer(CommandBuffer baseBuffer)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UnsafeCommandBuffer GetUnsafeCommandBuffer(CommandBuffer baseBuffer)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static CommandBuffer GetNativeCommandBuffer(UnsafeCommandBuffer baseBuffer)
		{
			return null;
		}

		public static void VFXManager_ProcessCameraCommand(Camera cam, UnsafeCommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results)
		{
		}
	}
}
