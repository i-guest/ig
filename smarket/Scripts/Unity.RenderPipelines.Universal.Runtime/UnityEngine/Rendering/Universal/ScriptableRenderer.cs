using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.VFX;

namespace UnityEngine.Rendering.Universal
{
	public abstract class ScriptableRenderer : IDisposable
	{
		private static class Profiling
		{
			public static class RenderBlock
			{
				private const string k_Name = "RenderPassBlock";

				public static readonly ProfilingSampler beforeRendering;

				public static readonly ProfilingSampler mainRenderingOpaque;

				public static readonly ProfilingSampler mainRenderingTransparent;

				public static readonly ProfilingSampler afterRendering;
			}

			public static class RenderPass
			{
				private const string k_Name = "ScriptableRenderPass";

				public static readonly ProfilingSampler configure;

				public static readonly ProfilingSampler setRenderPassAttachments;
			}

			public static readonly ProfilingSampler setMRTAttachmentsList;

			public static readonly ProfilingSampler setAttachmentList;

			public static readonly ProfilingSampler execute;

			public static readonly ProfilingSampler setupFrameData;

			private const string k_Name = "ScriptableRenderer";

			public static readonly ProfilingSampler setPerCameraShaderVariables;

			public static readonly ProfilingSampler sortRenderPasses;

			public static readonly ProfilingSampler recordRenderGraph;

			public static readonly ProfilingSampler setupCamera;

			public static readonly ProfilingSampler vfxProcessCamera;

			public static readonly ProfilingSampler addRenderPasses;

			public static readonly ProfilingSampler clearRenderingState;

			public static readonly ProfilingSampler internalFinishRenderingCommon;

			public static readonly ProfilingSampler drawGizmos;

			public static readonly ProfilingSampler drawWireOverlay;

			internal static readonly ProfilingSampler beginXRRendering;

			internal static readonly ProfilingSampler endXRRendering;

			internal static readonly ProfilingSampler initRenderGraphFrame;

			internal static readonly ProfilingSampler setEditorTarget;

			public static readonly ProfilingSampler setupLights;

			public static readonly ProfilingSampler setupRenderPasses;

			public static readonly ProfilingSampler internalStartRendering;
		}

		internal struct RenderPassDescriptor
		{
			internal int w;

			internal int h;

			internal int samples;

			internal int depthID;

			internal RenderPassDescriptor(int width, int height, int sampleCount, int rtID)
			{
				w = 0;
				h = 0;
				samples = 0;
				depthID = 0;
			}
		}

		public class RenderingFeatures
		{
			[Obsolete("cameraStacking has been deprecated use SupportedCameraRenderTypes() in ScriptableRenderer instead. #from(2022.2) #breakingFrom(2023.1)", true)]
			public bool cameraStacking { get; set; }

			public bool msaa { get; set; }
		}

		private static class RenderPassBlock
		{
			public static readonly int BeforeRendering;

			public static readonly int MainRenderingOpaque;

			public static readonly int MainRenderingTransparent;

			public static readonly int AfterRendering;
		}

		private class VFXProcessCameraPassData
		{
			internal UniversalRenderingData renderingData;

			internal Camera camera;

			internal VFXCameraXRSettings cameraXRSettings;

			internal XRPass xrPass;
		}

		private class DrawGizmosPassData
		{
			public RendererListHandle gizmoRenderList;

			public TextureHandle color;

			public TextureHandle depth;
		}

		private class DrawWireOverlayPassData
		{
			public RendererListHandle wireOverlayList;
		}

		private class BeginXRPassData
		{
			internal UniversalCameraData cameraData;
		}

		private class EndXRPassData
		{
			public UniversalCameraData cameraData;
		}

		private class DummyData
		{
		}

		private class PassData
		{
			internal ScriptableRenderer renderer;

			internal UniversalCameraData cameraData;

			internal TextureHandle target;

			internal Vector2Int cameraTargetSizeCopy;
		}

		internal struct RenderBlocks : IDisposable
		{
			public struct BlockRange : IDisposable
			{
				private int m_Current;

				private int m_End;

				public int Current => 0;

				public BlockRange(int begin, int end)
				{
					m_Current = 0;
					m_End = 0;
				}

				public BlockRange GetEnumerator()
				{
					return default(BlockRange);
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}
			}

			private NativeArray<RenderPassEvent> m_BlockEventLimits;

			private NativeArray<int> m_BlockRanges;

			private NativeArray<int> m_BlockRangeLengths;

			public RenderBlocks(List<ScriptableRenderPass> activeRenderPassQueue)
			{
				m_BlockEventLimits = default(NativeArray<RenderPassEvent>);
				m_BlockRanges = default(NativeArray<int>);
				m_BlockRangeLengths = default(NativeArray<int>);
			}

			public void Dispose()
			{
			}

			private void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue)
			{
			}

			public int GetLength(int index)
			{
				return 0;
			}

			public BlockRange GetRange(int index)
			{
				return default(BlockRange);
			}
		}

		internal const int kRenderPassMapSize = 10;

		internal const int kRenderPassMaxCount = 20;

		private int m_LastBeginSubpassPassIndex;

		private Dictionary<Hash128, int[]> m_MergeableRenderPassesMap;

		private int[][] m_MergeableRenderPassesMapArrays;

		private Hash128[] m_PassIndexToPassHash;

		private Dictionary<Hash128, int> m_RenderPassesAttachmentCount;

		private int m_firstPassIndexOfLastMergeableGroup;

		private AttachmentDescriptor[] m_ActiveColorAttachmentDescriptors;

		private AttachmentDescriptor m_ActiveDepthAttachmentDescriptor;

		private bool[] m_IsActiveColorAttachmentTransient;

		internal RenderBufferStoreAction[] m_FinalColorStoreAction;

		internal RenderBufferStoreAction m_FinalDepthStoreAction;

		internal bool hasReleasedRTs;

		internal static ScriptableRenderer current;

		private StoreActionsOptimization m_StoreActionsOptimizationSetting;

		private static bool m_UseOptimizedStoreActions;

		private const int k_RenderPassBlockCount = 4;

		protected static readonly RTHandle k_CameraTarget;

		private List<ScriptableRenderPass> m_ActiveRenderPassQueue;

		private List<ScriptableRendererFeature> m_RendererFeatures;

		private RTHandle m_CameraColorTarget;

		private RTHandle m_CameraDepthTarget;

		private RTHandle m_CameraResolveTarget;

		private bool m_FirstTimeCameraColorTargetIsBound;

		private bool m_FirstTimeCameraDepthTargetIsBound;

		private bool m_IsPipelineExecuting;

		internal bool disableNativeRenderPassInFeatures;

		internal bool useRenderPassEnabled;

		private static RenderTargetIdentifier[] m_ActiveColorAttachmentIDs;

		private static RTHandle[] m_ActiveColorAttachments;

		private static RTHandle m_ActiveDepthAttachment;

		private ContextContainer m_frameData;

		private static RenderBufferStoreAction[] m_ActiveColorStoreActions;

		private static RenderBufferStoreAction m_ActiveDepthStoreAction;

		private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopyIDs;

		private static RTHandle[][] m_TrimmedColorAttachmentCopies;

		private static Plane[] s_Planes;

		private static Vector4[] s_VectorPlanes;

		[Obsolete("cameraDepth has been renamed to cameraDepthTarget. #from(2021.1) #breakingFrom(2023.1) (UnityUpgradable) -> cameraDepthTarget", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public RenderTargetIdentifier cameraDepth => default(RenderTargetIdentifier);

		protected ProfilingSampler profilingExecute { get; set; }

		internal DebugHandler DebugHandler { get; }

		[Obsolete("Use cameraColorTargetHandle. #from(2022.1) #breakingFrom(2023.2)", true)]
		public RenderTargetIdentifier cameraColorTarget => default(RenderTargetIdentifier);

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public RTHandle cameraColorTargetHandle => null;

		[Obsolete("Use cameraDepthTargetHandle. #from(2022.1) #breakingFrom(2023.1)", true)]
		public RenderTargetIdentifier cameraDepthTarget => default(RenderTargetIdentifier);

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public RTHandle cameraDepthTargetHandle => null;

		protected List<ScriptableRendererFeature> rendererFeatures => null;

		protected List<ScriptableRenderPass> activeRenderPassQueue => null;

		public RenderingFeatures supportedRenderingFeatures { get; set; }

		public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes { get; set; }

		internal ContextContainer frameData => null;

		internal bool useDepthPriming { get; set; }

		internal bool stripShadowsOffVariants { get; set; }

		internal bool stripAdditionalLightOffVariants { get; set; }

		internal virtual bool supportsNativeRenderPassRendergraphCompiler => false;

		public virtual bool supportsGPUOcclusion => false;

		internal void ResetNativeRenderPassFrameData()
		{
		}

		internal void SetupNativeRenderPassFrameData(UniversalCameraData cameraData, bool isRenderPassEnabled)
		{
		}

		internal void UpdateFinalStoreActions(int[] currentMergeablePasses, UniversalCameraData cameraData, bool isLastMergeableGroup)
		{
		}

		internal void SetNativeRenderPassMRTAttachmentList(ScriptableRenderPass renderPass, UniversalCameraData cameraData, bool needCustomCameraColorClear, ClearFlag cameraClearFlag)
		{
		}

		private bool IsDepthOnlyRenderTexture(RenderTexture t)
		{
			return false;
		}

		internal void SetNativeRenderPassAttachmentList(ScriptableRenderPass renderPass, UniversalCameraData cameraData, RTHandle passColorAttachment, RTHandle passDepthAttachment, ClearFlag finalClearFlag, Color finalClearColor)
		{
		}

		internal void ExecuteNativeRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, UniversalCameraData cameraData, ref RenderingData renderingData)
		{
		}

		internal void SetupInputAttachmentIndices(ScriptableRenderPass pass)
		{
		}

		internal void SetupTransientInputAttachments(int attachmentCount)
		{
		}

		internal static uint GetSubPassAttachmentIndicesCount(ScriptableRenderPass pass)
		{
			return 0u;
		}

		internal static bool AreAttachmentIndicesCompatible(ScriptableRenderPass lastSubPass, ScriptableRenderPass currentSubPass)
		{
			return false;
		}

		internal static uint GetValidColorAttachmentCount(AttachmentDescriptor[] colorAttachments)
		{
			return 0u;
		}

		internal static int GetValidInputAttachmentCount(ScriptableRenderPass renderPass)
		{
			return 0;
		}

		internal static int FindAttachmentDescriptorIndexInList(int attachmentIdx, AttachmentDescriptor attachmentDescriptor, AttachmentDescriptor[] attachmentDescriptors)
		{
			return 0;
		}

		internal static int FindAttachmentDescriptorIndexInList(RenderTargetIdentifier target, AttachmentDescriptor[] attachmentDescriptors)
		{
			return 0;
		}

		internal static int GetValidPassIndexCount(int[] array)
		{
			return 0;
		}

		internal static RTHandle GetFirstAllocatedRTHandle(ScriptableRenderPass pass)
		{
			return null;
		}

		internal static bool PassHasInputAttachments(ScriptableRenderPass renderPass)
		{
			return false;
		}

		internal static Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex)
		{
			return default(Hash128);
		}

		internal static Hash128 CreateRenderPassHash(RenderPassDescriptor desc, uint hashIndex)
		{
			return default(Hash128);
		}

		internal static void GetRenderTextureDescriptor(UniversalCameraData cameraData, ScriptableRenderPass renderPass, out RenderTextureDescriptor targetRT)
		{
			targetRT = default(RenderTextureDescriptor);
		}

		private RenderPassDescriptor InitializeRenderPassDescriptor(UniversalCameraData cameraData, ScriptableRenderPass renderPass)
		{
			return default(RenderPassDescriptor);
		}

		public virtual int SupportedCameraStackingTypes()
		{
			return 0;
		}

		public bool SupportsCameraStackingType(CameraRenderType cameraRenderType)
		{
			return false;
		}

		protected internal virtual bool SupportsMotionVectors()
		{
			return false;
		}

		protected internal virtual bool SupportsCameraOpaque()
		{
			return false;
		}

		protected internal virtual bool SupportsCameraNormals()
		{
			return false;
		}

		public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices)
		{
		}

		public static void SetCameraMatrices(CommandBuffer cmd, UniversalCameraData cameraData, bool setInverseMatrices)
		{
		}

		internal static void SetCameraMatrices(RasterCommandBuffer cmd, UniversalCameraData cameraData, bool setInverseMatrices, bool isTargetFlipped)
		{
		}

		private void SetPerCameraShaderVariables(RasterCommandBuffer cmd, UniversalCameraData cameraData)
		{
		}

		private void SetPerCameraShaderVariables(RasterCommandBuffer cmd, UniversalCameraData cameraData, Vector2Int cameraTargetSizeCopy, bool isTargetFlipped)
		{
		}

		private void SetPerCameraBillboardProperties(RasterCommandBuffer cmd, UniversalCameraData cameraData)
		{
		}

		private static void CalculateBillboardProperties(in Matrix4x4 worldToCameraMatrix, out Vector3 billboardTangent, out Vector3 billboardNormal, out float cameraXZAngle)
		{
			billboardTangent = default(Vector3);
			billboardNormal = default(Vector3);
			cameraXZAngle = default(float);
		}

		private void SetPerCameraClippingPlaneProperties(RasterCommandBuffer cmd, UniversalCameraData cameraData)
		{
		}

		private void SetPerCameraClippingPlaneProperties(RasterCommandBuffer cmd, in UniversalCameraData cameraData, bool isTargetFlipped)
		{
		}

		private static void SetShaderTimeValues(IBaseCommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal virtual RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			return null;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal virtual RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
		{
			return null;
		}

		public ScriptableRenderer(ScriptableRendererData data)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		internal virtual void ReleaseRenderTargets()
		{
		}

		[Obsolete("Use RTHandles for colorTarget and depthTarget. #from(2022.1) #breakingFrom(2023.1)", true)]
		public void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget, RTHandle resolveTarget)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal void ConfigureCameraColorTarget(RTHandle colorTarget)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public virtual void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		public virtual void FinishRendering(CommandBuffer cmd)
		{
		}

		public virtual void OnBeginRenderGraphFrame()
		{
		}

		internal virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context)
		{
		}

		public virtual void OnEndRenderGraphFrame()
		{
		}

		private void InitRenderGraphFrame(RenderGraph renderGraph)
		{
		}

		internal void ProcessVFXCameraCommand(RenderGraph renderGraph)
		{
		}

		internal void SetupRenderGraphCameraProperties(RenderGraph renderGraph, TextureHandle target)
		{
		}

		internal void DrawRenderGraphGizmos(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color, TextureHandle depth, GizmoSubset gizmoSubset)
		{
		}

		internal void DrawRenderGraphWireOverlay(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color)
		{
		}

		internal void BeginRenderGraphXRRendering(RenderGraph renderGraph)
		{
		}

		internal void EndRenderGraphXRRendering(RenderGraph renderGraph)
		{
		}

		private void SetEditorTarget(RenderGraph renderGraph)
		{
		}

		internal void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context)
		{
		}

		internal void FinishRenderGraphRendering(CommandBuffer cmd)
		{
		}

		internal virtual void OnFinishRenderGraphRendering(CommandBuffer cmd)
		{
		}

		internal void RecordCustomRenderGraphPassesInEventRange(RenderGraph renderGraph, RenderPassEvent eventStart, RenderPassEvent eventEnd)
		{
		}

		internal void CalculateSplitEventRange(RenderPassEvent startInjectionPoint, RenderPassEvent targetEvent, out RenderPassEvent startEvent, out RenderPassEvent splitEvent, out RenderPassEvent endEvent)
		{
			startEvent = default(RenderPassEvent);
			splitEvent = default(RenderPassEvent);
			endEvent = default(RenderPassEvent);
		}

		internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent startInjectionPoint, RenderPassEvent endInjectionPoint)
		{
		}

		internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent injectionPoint)
		{
		}

		internal void SetPerCameraProperties(ScriptableRenderContext context, UniversalCameraData cameraData, Camera camera, CommandBuffer cmd)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public void EnqueuePass(ScriptableRenderPass pass)
		{
		}

		protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData)
		{
			return default(ClearFlag);
		}

		protected static ClearFlag GetCameraClearFlag(UniversalCameraData cameraData)
		{
			return default(ClearFlag);
		}

		internal void OnPreCullRenderPasses(in CameraData cameraData)
		{
		}

		internal void AddRenderPasses(ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		protected void SetupRenderPasses(in RenderingData renderingData)
		{
		}

		private static void ClearRenderingState(IBaseCommandBuffer cmd)
		{
		}

		internal void Clear(CameraRenderType cameraType)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		private void ExecuteBlock(int blockIndex, in RenderBlocks renderBlocks, ScriptableRenderContext context, ref RenderingData renderingData, bool submit = false)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		private bool IsRenderPassEnabled(ScriptableRenderPass renderPass)
		{
			return false;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		private void ExecuteRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, UniversalCameraData cameraData, ref RenderingData renderingData)
		{
		}

		internal bool IsSceneFilteringEnabled(Camera camera)
		{
			return false;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		private void SetRenderPassAttachments(CommandBuffer cmd, ScriptableRenderPass renderPass, UniversalCameraData cameraData)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		private void BeginXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		private void EndXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		private static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		private static void SetRenderTarget(CommandBuffer cmd, RTHandle[] colorAttachments, RenderTargetIdentifier[] colorAttachmentIDs, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
		}

		internal virtual void SwapColorBuffer(CommandBuffer cmd)
		{
		}

		internal virtual void EnableSwapBufferMSAA(bool enable)
		{
		}

		[Conditional("UNITY_EDITOR")]
		private void DrawGizmos(ScriptableRenderContext context, Camera camera, GizmoSubset gizmoSubset, ref RenderingData renderingData)
		{
		}

		[Conditional("UNITY_EDITOR")]
		private void DrawWireOverlay(ScriptableRenderContext context, Camera camera)
		{
		}

		private void InternalStartRendering(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private void InternalFinishRenderingCommon(CommandBuffer cmd, bool resolveFinalTarget)
		{
		}

		private void InternalFinishRenderingExecute(ScriptableRenderContext context, CommandBuffer cmd, bool resolveFinalTarget)
		{
		}

		private protected int AdjustAndGetScreenMSAASamples(RenderGraph renderGraph, bool useIntermediateColorTarget)
		{
			return 0;
		}

		internal static void SortStable(List<ScriptableRenderPass> list)
		{
		}
	}
}
