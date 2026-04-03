using System;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	internal class NativePassCompiler : IDisposable
	{
		internal struct RenderGraphInputInfo
		{
			public RenderGraphResourceRegistry m_ResourcesForDebugOnly;

			public List<RenderGraphPass> m_RenderPasses;

			public string debugName;

			public bool disablePassCulling;

			public bool disablePassMerging;

			public RenderTextureUVOriginStrategy renderTextureUVOriginStrategy;
		}

		internal enum NativeCompilerProfileId
		{
			NRPRGComp_PrepareNativePass = 0,
			NRPRGComp_SetupContextData = 1,
			NRPRGComp_BuildGraph = 2,
			NRPRGComp_CullNodes = 3,
			NRPRGComp_TryMergeNativePasses = 4,
			NRPRGComp_FindResourceUsageRanges = 5,
			NRPRGComp_DetectMemorylessResources = 6,
			NRPRGComp_PropagateTextureUVOrigin = 7,
			NRPRGComp_ExecuteInitializeResources = 8,
			NRPRGComp_ExecuteBeginRenderpassCommand = 9,
			NRPRGComp_ExecuteDestroyResources = 10
		}

		internal RenderGraphInputInfo graph;

		internal CompilerContextData contextData;

		internal CompilerContextData defaultContextData;

		internal CommandBuffer previousCommandBuffer;

		private Stack<int> m_HasSideEffectPassIdCullingStack;

		private List<Stack<ResourceHandle>> m_UnusedVersionedResourceIdCullingStacks;

		private Dictionary<int, List<ResourceHandle>> m_DelayedLastUseListPerPassMap;

		private RenderGraphCompilationCache m_CompilationCache;

		private RenderTargetIdentifier[][] m_TempMRTArrays;

		internal const int k_EstimatedPassCount = 100;

		internal const int k_MaxSubpass = 8;

		private NativeList<AttachmentDescriptor> m_BeginRenderPassAttachments;

		internal static bool s_ForceGenerateAuditsForTests;

		private const int ArbitraryMaxNbMergedPasses = 16;

		private DynamicArray<Name> graphPassNamesForDebug;

		public NativePassCompiler(RenderGraphCompilationCache cache)
		{
		}

		~NativePassCompiler()
		{
		}

		public void Dispose()
		{
		}

		public void Cleanup()
		{
		}

		public bool Initialize(RenderGraphResourceRegistry resources, List<RenderGraphPass> renderPasses, RenderGraphDebugParams debugParams, string debugName, bool useCompilationCaching, int graphHash, int frameIndex, RenderTextureUVOriginStrategy renderTextureUVOriginStrategy)
		{
			return false;
		}

		private void HandleExtendedFeatureFlags()
		{
		}

		public void Compile(RenderGraphResourceRegistry resources)
		{
		}

		public void Clear(bool clearContextData)
		{
		}

		private void SetPassStatesForNativePass(int nativePassId)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ValidatePasses()
		{
		}

		private void SetupContextData(RenderGraphResourceRegistry resources)
		{
		}

		private bool TrySetupRasterFragmentList(ref PassData ctxPass, ref RenderGraphPass inputPass, out string errorMessage)
		{
			errorMessage = null;
			return false;
		}

		private void BuildGraph()
		{
		}

		private void CullUnusedRenderGraphPasses()
		{
		}

		private void CullRenderGraphPassesWritingOnlyUnusedResources()
		{
		}

		private void TryMergeNativePasses()
		{
		}

		private bool FindFirstPassIdOnGraphicsQueueAwaitingFenceGoingForward(ref PassData startAsyncPass, out int firstPassIdAwaiting)
		{
			firstPassIdAwaiting = default(int);
			return false;
		}

		private int FindFirstNonCulledPassIdGoingBackward(int startPassId, bool startPassIsIncluded)
		{
			return 0;
		}

		private void FindResourceUsageRangeAndSynchronization()
		{
		}

		private void ClearDelayedLastUseListAtPass(int passId)
		{
		}

		private void AddDelayedLastUseToPass(in ResourceHandle releaseResource, int passId)
		{
		}

		public void AddLastUseFromDelayedList(ref PassData passData)
		{
		}

		private void PrepareNativeRenderPasses()
		{
		}

		private void PropagateTextureUVOrigin()
		{
		}

		private static bool IsGlobalTextureInPass(RenderGraphPass pass, in ResourceHandle handle)
		{
			return false;
		}

		private void DetectMemoryLessResources()
		{
		}

		internal static bool IsSameNativeSubPass(ref SubPassDescriptor a, ref SubPassDescriptor b)
		{
			return false;
		}

		private bool ExecuteInitializeResource(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, in PassData pass)
		{
			return false;
		}

		private void DetermineLoadStoreActions(ref NativePassData nativePass)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ValidateNativePass(in NativePassData nativePass, int width, int height, int depth, int samples, int attachmentCount)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ValidateAttachment(in RenderTargetInfo attRenderTargetInfo, RenderGraphResourceRegistry resources, int nativePassWidth, int nativePassHeight, int nativePassMSAASamples, bool isVrs, bool isShaderResolve)
		{
		}

		internal void ExecuteBeginRenderPass(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, ref NativePassData nativePass)
		{
		}

		private void ExecuteDestroyResource(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, ref PassData pass)
		{
		}

		private void ExecuteSetRenderTargets(RenderGraphPass pass, InternalRenderGraphContext rgContext)
		{
		}

		internal void ExecuteSetRandomWriteTarget(in CommandBuffer cmd, RenderGraphResourceRegistry resources, int index, in ResourceHandle resource, bool preserveCounterValue = true)
		{
		}

		internal void ExecuteRenderGraphPass(ref InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, RenderGraphPass pass)
		{
		}

		public void ExecuteGraph(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, in List<RenderGraphPass> passes)
		{
		}

		private void EndRenderGraphPass(ref InternalRenderGraphContext rgContext, ref PassData passData, ref bool inRenderPass, RenderGraphResourceRegistry resources, bool nrpBegan)
		{
		}

		private static RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.AttachmentInfo MakeAttachmentInfo(CompilerContextData ctx, in NativePassData nativePass, int attachmentIndex)
		{
			return null;
		}

		internal static string MakePassBreakInfoMessage(CompilerContextData ctx, in NativePassData nativePass)
		{
			return null;
		}

		internal static string MakePassMergeMessage(CompilerContextData ctx, in PassData pass, in PassData prevPass, in PassBreakAudit mergeResult)
		{
			return null;
		}

		private static string InjectSpaces(string camelCaseString)
		{
			return null;
		}

		internal void GenerateNativeCompilerDebugData(ref RenderGraph.DebugData debugData)
		{
		}
	}
}
