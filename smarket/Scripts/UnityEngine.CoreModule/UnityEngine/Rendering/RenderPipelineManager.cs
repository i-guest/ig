using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	public static class RenderPipelineManager
	{
		private static bool s_CleanUpPipeline;

		private static RenderPipelineAsset s_CurrentPipelineAsset;

		private static RenderPipeline s_CurrentPipeline;

		private static bool s_PendingRPAssignationToRaise;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action activeRenderPipelineTypeChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action activeRenderPipelineCreated;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action activeRenderPipelineDisposed;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<ScriptableRenderContext, Camera[]> endFrameRendering;

		public static RenderPipeline currentPipeline
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		internal static bool isCurrentPipelineValid => false;

		public static event Action<ScriptableRenderContext, List<Camera>> beginContextRendering
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

		public static event Action<ScriptableRenderContext, List<Camera>> endContextRendering
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

		public static event Action<ScriptableRenderContext, Camera> beginCameraRendering
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

		public static event Action<ScriptableRenderContext, Camera> endCameraRendering
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

		internal static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
		}

		internal static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		internal static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
		}

		internal static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		[RequiredByNativeCode]
		private static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to, bool raiseTypeChanged)
		{
		}

		[RequiredByNativeCode]
		internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
		{
		}

		[RequiredByNativeCode]
		internal static void RecreateCurrentPipeline(RenderPipelineAsset pipelineAsset)
		{
		}

		[RequiredByNativeCode]
		internal static void CleanupRenderPipeline()
		{
		}

		[RequiredByNativeCode]
		private static void DoRenderLoop_Internal(RenderPipelineAsset pipelineAsset, IntPtr loopPtr, Object renderRequest)
		{
		}

		internal static bool TryPrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
		{
			return false;
		}

		private static bool IsPipelineRequireCreation()
		{
			return false;
		}
	}
}
