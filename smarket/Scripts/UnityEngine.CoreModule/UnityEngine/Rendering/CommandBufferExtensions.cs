using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Export/Graphics/RenderingCommandBufferExtensions.bindings.h")]
	public static class CommandBufferExtensions
	{
		[FreeFunction("RenderingCommandBufferExtensions_Bindings::Internal_SwitchIntoFastMemory")]
		private static void Internal_SwitchIntoFastMemory([NotNull] CommandBuffer cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
		}

		[FreeFunction("RenderingCommandBufferExtensions_Bindings::Internal_SwitchOutOfFastMemory")]
		private static void Internal_SwitchOutOfFastMemory([NotNull] CommandBuffer cmd, ref RenderTargetIdentifier rt, bool copyContents)
		{
		}

		[NativeConditional("UNITY_XBOXONE || UNITY_GAMECORE_XBOXONE")]
		public static void SwitchIntoFastMemory(this CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
		}

		[NativeConditional("UNITY_XBOXONE || UNITY_GAMECORE_XBOXONE")]
		public static void SwitchOutOfFastMemory(this CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents)
		{
		}

		private static void Internal_SwitchIntoFastMemory_Injected(IntPtr cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
		}

		private static void Internal_SwitchOutOfFastMemory_Injected(IntPtr cmd, ref RenderTargetIdentifier rt, bool copyContents)
		{
		}
	}
}
