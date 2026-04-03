using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;
using UnityEngine.Rendering.RendererUtils;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	public class RenderGraph
	{
		internal class DebugExecutionItem
		{
			public EntityId id { get; }

			public string name { get; }

			public DebugExecutionItem(EntityId id, string name)
			{
			}
		}

		[Serializable]
		internal class DebugData
		{
			[Serializable]
			public class ResourceLists<T>
			{
				[SerializeField]
				private List<T> m_Textures;

				[SerializeField]
				private List<T> m_Buffers;

				[SerializeField]
				private List<T> m_AccelerationStructures;

				public List<T> this[int index]
				{
					get
					{
						return null;
					}
					set
					{
					}
				}

				public void Clear()
				{
				}
			}

			[Serializable]
			public class ResourceDataLists : ResourceLists<ResourceData>
			{
			}

			[Serializable]
			public class SerializableNativePassAttachment
			{
				public RenderBufferLoadAction loadAction;

				public RenderBufferStoreAction storeAction;

				public bool memoryless;

				public int mipLevel;

				public int depthSlice;

				public SerializableNativePassAttachment(NativePassAttachment att)
				{
				}
			}

			[Serializable]
			[DebuggerDisplay("PassDebug: {name}")]
			public struct PassData
			{
				[Serializable]
				public class ResourceIdLists : ResourceLists<int>
				{
				}

				[Serializable]
				public class NRPInfo
				{
					[Serializable]
					public class NativeRenderPassInfo
					{
						[Serializable]
						public class AttachmentInfo
						{
							public string resourceName;

							public string loadReason;

							public string storeReason;

							public string storeMsaaReason;

							public int attachmentIndex;

							public SerializableNativePassAttachment attachment;
						}

						[Serializable]
						public struct PassCompatibilityInfo
						{
							public string message;

							public bool isCompatible;
						}

						public string passBreakReasoning;

						public List<AttachmentInfo> attachmentInfos;

						public SerializedDictionary<int, PassCompatibilityInfo> passCompatibility;

						public List<int> mergedPassIds;
					}

					[SerializeReference]
					public NativeRenderPassInfo nativePassInfo;

					public List<int> textureFBFetchList;

					public List<int> setGlobals;

					public int width;

					public int height;

					public int volumeDepth;

					public int samples;

					public bool hasDepth;
				}

				public string name;

				public RenderGraphPassType type;

				public ResourceIdLists resourceReadLists;

				public ResourceIdLists resourceWriteLists;

				public bool culled;

				public bool async;

				public int nativeSubPassIndex;

				public int syncToPassIndex;

				public int syncFromPassIndex;

				public bool generateDebugData;

				[SerializeReference]
				public NRPInfo nrpInfo;

				public PassScriptInfo scriptInfo;
			}

			[Serializable]
			public class BufferResourceData
			{
				public int count;

				public int stride;

				public GraphicsBuffer.Target target;

				public GraphicsBuffer.UsageFlags usage;
			}

			[Serializable]
			public class TextureResourceData
			{
				public int width;

				public int height;

				public int depth;

				public bool bindMS;

				public int samples;

				public GraphicsFormat format;

				public bool clearBuffer;
			}

			[Serializable]
			[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
			public struct ResourceData
			{
				public string name;

				public bool imported;

				public int creationPassIndex;

				public int releasePassIndex;

				public List<int> consumerList;

				public List<int> producerList;

				public bool memoryless;

				[SerializeReference]
				public TextureResourceData textureData;

				[SerializeReference]
				public BufferResourceData bufferData;
			}

			[Serializable]
			public struct PassScriptInfo
			{
				public string filePath;

				public int line;
			}

			public string executionName;

			public bool valid;

			public int graphHash;

			public bool isNRPCompiler;

			public List<PassData> passList;

			public ResourceDataLists resourceLists;

			public DebugData(string executionName)
			{
			}

			public void Clear()
			{
			}
		}

		internal static class DebugDataSerialization
		{
			public static string ToJson(DebugData debugData)
			{
				return null;
			}

			public static DebugData FromJson(string json)
			{
				return null;
			}
		}

		internal struct CompiledResourceInfo
		{
			public List<int> producers;

			public List<int> consumers;

			public int refCount;

			public bool imported;

			public void Reset()
			{
			}
		}

		[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
		internal struct CompiledPassInfo
		{
			public string name;

			public int index;

			public List<int>[] resourceCreateList;

			public List<int>[] resourceReleaseList;

			public GraphicsFence fence;

			public int refCount;

			public int syncToPassIndex;

			public int syncFromPassIndex;

			public bool enableAsyncCompute;

			public bool allowPassCulling;

			public bool needGraphicsFence;

			public bool culled;

			public bool culledByRendererList;

			public bool hasSideEffect;

			public bool enableFoveatedRasterization;

			public ExtendedFeatureFlags extendedFeatureFlags;

			public bool hasShadingRateImage;

			public bool hasShadingRateStates;

			public void Reset(RenderGraphPass pass, int index)
			{
			}
		}

		internal interface ICompiledGraph
		{
			void Clear();
		}

		internal class CompiledGraph : ICompiledGraph
		{
			public DynamicArray<CompiledResourceInfo>[] compiledResourcesInfos;

			public DynamicArray<CompiledPassInfo> compiledPassInfos;

			public int lastExecutionFrame;

			public void Clear()
			{
			}

			private void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count)
			{
			}

			public void InitializeCompilationData(List<RenderGraphPass> passes, RenderGraphResourceRegistry resources)
			{
			}
		}

		private class ProfilingScopePassData
		{
			public ProfilingSampler sampler;
		}

		internal delegate void OnGraphRegisteredDelegate(string graphName);

		internal delegate void OnExecutionRegisteredDelegate(string graphName, EntityId executionId, string executionName);

		internal static class RenderGraphExceptionMessages
		{
			internal static bool enableCaller;

			internal const string k_RenderGraphExecutionError = "Render Graph Execution error";

			private static readonly Dictionary<RenderGraphState, string> m_RenderGraphStateMessages;

			private const string k_ErrorDefaultMessage = "Invalid render graph state, impossible to log the exception.";

			internal const string k_NonTextureAsAttachmentError = "Only textures can be used as a fragment attachment.";

			internal const string k_OneResourceTwoVersionsError = "A pass is using SetAttachment or UseTexture on two versions of the same resource. Make sure you only access the latest version.";

			internal const string k_UseTextureRandWriteTwoVersionsError = "A pass is using UseTextureRandomWrite on two versions of the same resource.  Make sure you only access the latest version.";

			internal const string k_InvalidGetRenderTargetInfoResultsError = "GetRenderTargetInfo returned invalid results. Check that the width, height, and number of MSAA samples is not 0.";

			internal const string k_CannotDetermineSubPassFlagNoDepth = "SubPassFlag for merging cannot be determined if native pass doesn't have a depth attachment. Make sure your pass has a depth attachment.";

			internal const string k_AddingOlderAttachmentVersion = "The pass adds an older version while a higher version is already registered with the pass. Make sure you only access the latest version.";

			internal const string k_NonIncrementalCreationCall = "Something went wrong when compiling the graph. The Creation lists must be set-up incrementally for all passes, but AddFirstUse is called in an arbitrary non-incremental way.";

			internal const string k_NonIncrementalDestructionCall = "Something went wrong when compiling the graph. The Destruction lists must be set-up incrementally for all passes, AddLastUse is called in an arbitrary non-incremental way.";

			internal const string k_UndisposedBuilderPreviousPass = "Finish building the previous pass first by disposing of the pass builder object before adding a new pass. You can manually dispose of the builder with 'builder.Dispose()'.";

			internal const string k_WriteToVersionedResource = "The pass writes to a versioned resource handle. You can only write to unversioned resource handles to avoid branches in the resource history.";

			internal const string k_WriteToResourceTwice = "The pass writes to a resource twice. You can only write the same resource once within a pass.";

			internal const string k_TextureAlreadyBeingUsedThroughSetAttachment = "UseTexture is called on a texture that is already used through SetRenderAttachment. Check your code and make sure the texture is only used once.";

			internal const string k_SetRenderAttachmentTextureAlreadyUsed = "SetRenderAttachment is called on a texture that is already used through UseTexture/SetRenderAttachment. Check your code and make sure the texture is only used once.";

			internal const string k_SetRenderAttachmentOnDepthTexture = "SetRenderAttachment is called on a texture that has a depth format. Use a texture with a color format instead, or call SetRenderDepthAttachment.";

			internal const string k_SetRenderAttachmentOnGlobalTexture = "SetRenderAttachment is called on a texture that is currently bound to a global texture slot. Shaders might be using the texture using samplers. Make sure textures are not set as globals when using them as fragment attachments.";

			internal const string k_InvalidResource = "Using an invalid resource. Invalid resources can be resources leftover from a previous execution.";

			internal const string k_ReadWriteTransient = "This pass is reading or writing a transient resource. Transient resources are always assumed to be both read and written using 'AccessFlags.ReadWrite'.";

			internal const string k_MoreThanOneResourceForMRTIndex = "You can only bind a single texture to a single index in a multiple render texture (MRT). Verify your indexes are correct.";

			internal const string k_MoreThanOneTextureForFragInputIndex = "You can only bind a single texture to a fragment input index. Verify your indexes are correct.";

			internal const string k_MoreThanOneTextureRandomWriteInputIndex = "You can only bind a single texture to a random write input index. Verify your indexes are correct.";

			internal const string k_MultipleDepthTextures = "You can only set a single depth texture per pass.";

			internal const string k_LoadingMemorylessResource = "This pass is loading a resource marked as memoryless.";

			internal const string k_ResolvignMemorylessResource = "This pass is storing or resolving a resource marked as memoryless";

			internal const string k_RenderPassIsEmpty = "Empty render pass";

			internal const string k_RenderPassHasInvalidProperties = "Invalid render pass properties. One or more properties are zero.";

			internal const string k_ShadingRateImageAttachmentDoesNotMatch = "Low level rendergraph error: Shading rate image attachment in renderpass does not match.";

			internal const string k_AttachmentsDoNotMatch = "Low level rendergraph error: Attachments in renderpass do not match.";

			internal const string k_MultisampledShaderResolveInvalidAttachmentSetup = "Low level rendergraph error: last subpass with shader resolve must have one color attachment.";

			internal const string k_MultisampledShaderResolveInputAttachmentNotMemoryless = "Low level rendergraph error: last subpass with shader resolve must have all input attachments as memoryless attachments.";

			internal const string k_InvalidMRTSetup = "Multiple render texture (MRT) setup is invalid. Some indices are not used.";

			internal const string k_NoDepthBufferMRT = "Setting multiple render textures (MRTs) without a depth buffer is not supported.";

			internal const string k_InvalidDepthAndColorTargets = "Neither depth nor color render targets are correctly set up.";

			internal const string k_InvalidResourceType = "Invalid resource type, expected texture or buffer";

			internal const string k_NoRenderFunction = "RenderPass was not provided with an execute function.";

			internal const string k_BeginNoActivePass = "Compiler error: Pass is marked as beginning a native sub pass but no pass is currently active.";

			internal const string k_NoActivePassForSubpass = "Compiler error: Generated a subpass pass but no pass is currently active.";

			internal static string MismatchInDimensions(string name, int fragWidth, int fragHeight, int fragVolumeDepth, ResourceUnversionedData resInfo)
			{
				return null;
			}

			internal static string MismatchInMSAASamlpes(string name, int expectedSamples, int actualSamples)
			{
				return null;
			}

			internal static string NoGlobalTextureAtPropertyID(int propertyId)
			{
				return null;
			}

			internal static string UseDepthWithColorFormat(GraphicsFormat colorFormat)
			{
				return null;
			}

			internal static string UseTransientTextureInWrongPass(int transientIndex)
			{
				return null;
			}

			internal static string IncompatibleTextureUVOrigin(TextureUVOriginSelection origin, string attachmentType, string attachmentName, RenderGraphResourceType attachmentResourceType, int attachmentResourceIndex, TextureUVOriginSelection attachmentOrigin)
			{
				return null;
			}

			internal static string IncompatibleTextureUVOriginUseTexture(TextureUVOriginSelection origin)
			{
				return null;
			}

			internal static string UsingLegacyRenderGraph(string passName)
			{
				return null;
			}

			internal static string IncompatibleTextureUVOriginStore(string firstAttachmentName, TextureUVOriginSelection firstAttachmentOrigin, string secondAttachmentName, TextureUVOriginSelection secondAttachmentOrigin)
			{
				return null;
			}

			internal static string GetExceptionMessage(RenderGraphState state)
			{
				return null;
			}

			private static string GetHigherCaller()
			{
				return null;
			}
		}

		private NativePassCompiler nativeCompiler;

		public static readonly int kMaxMRTCount;

		internal RenderGraphResourceRegistry m_Resources;

		private RenderGraphObjectPool m_RenderGraphPool;

		private RenderGraphBuilders m_builderInstance;

		internal List<RenderGraphPass> m_RenderPasses;

		private List<RendererListHandle> m_RendererLists;

		private RenderGraphDebugParams m_DebugParameters;

		private RenderGraphLogger m_FrameInformationLogger;

		private RenderGraphDefaultResources m_DefaultResources;

		private Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers;

		private InternalRenderGraphContext m_RenderGraphContext;

		private CommandBuffer m_PreviousCommandBuffer;

		private List<int>[] m_ImmediateModeResourceList;

		private RenderGraphCompilationCache m_CompilationCache;

		private RenderTargetIdentifier[][] m_TempMRTArrays;

		private Stack<int> m_CullingStack;

		private EntityId m_CurrentExecutionId;

		private bool m_CurrentExecutionCanGenerateDebugData;

		private int m_ExecutionCount;

		private int m_CurrentFrameIndex;

		private int m_CurrentImmediatePassIndex;

		private bool m_ExecutionExceptionWasRaised;

		private bool m_RendererListCulling;

		private bool m_EnableCompilationCaching;

		internal static bool? s_EnableCompilationCachingForTests;

		private CompiledGraph m_DefaultCompiledGraph;

		private CompiledGraph m_CurrentCompiledGraph;

		private RenderGraphState m_RenderGraphState;

		private RenderTextureUVOriginStrategy m_renderTextureUVOriginStrategy;

		private static Dictionary<RenderGraph, List<DebugExecutionItem>> s_RegisteredExecutions;

		private const string k_BeginProfilingSamplerPassName = "BeginProfile";

		private const string k_EndProfilingSamplerPassName = "EndProfile";

		private static bool s_DebugSessionWasActive;

		private Dictionary<int, TextureHandle> registeredGlobals;

		public bool nativeRenderPassesEnabled { get; set; }

		internal static bool hasAnyRenderGraphWithNativeRenderPassesEnabled => false;

		public string name { get; private set; }

		internal RenderGraphState RenderGraphState
		{
			get
			{
				return default(RenderGraphState);
			}
			set
			{
			}
		}

		public RenderTextureUVOriginStrategy renderTextureUVOriginStrategy
		{
			get
			{
				return default(RenderTextureUVOriginStrategy);
			}
			internal set
			{
			}
		}

		public static bool isRenderGraphViewerActive => false;

		internal static bool enableValidityChecks { get; private set; }

		public RenderGraphDefaultResources defaultResources => null;

		internal RenderGraphDebugParams debugParams => null;

		internal bool areAnySettingsActive => false;

		internal static event OnGraphRegisteredDelegate onGraphRegistered
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

		internal static event OnGraphRegisteredDelegate onGraphUnregistered
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

		internal static event OnExecutionRegisteredDelegate onExecutionRegistered
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

		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		private void AddPassDebugMetadata(RenderGraphPass renderPass, string file, int line)
		{
		}

		internal NativePassCompiler CompileNativeRenderGraph(int graphHash)
		{
			return null;
		}

		private void ExecuteNativeRenderGraph()
		{
		}

		public RenderGraph(string name = "RenderGraph")
		{
		}

		internal void CleanupResourcesAndGraph()
		{
		}

		public void Cleanup()
		{
		}

		internal List<DebugUI.Widget> GetWidgetList()
		{
			return null;
		}

		public void RegisterDebug(DebugUI.Panel panel = null)
		{
		}

		public void UnRegisterDebug()
		{
		}

		public static List<RenderGraph> GetRegisteredRenderGraphs()
		{
			return null;
		}

		internal static Dictionary<RenderGraph, List<DebugExecutionItem>> GetRegisteredExecutions()
		{
			return null;
		}

		public void EndFrame()
		{
		}

		public TextureHandle ImportTexture(RTHandle rt)
		{
			return default(TextureHandle);
		}

		public TextureHandle ImportShadingRateImageTexture(RTHandle rt)
		{
			return default(TextureHandle);
		}

		public TextureHandle ImportTexture(RTHandle rt, ImportResourceParams importParams)
		{
			return default(TextureHandle);
		}

		public TextureHandle ImportTexture(RTHandle rt, RenderTargetInfo info, ImportResourceParams importParams = default(ImportResourceParams))
		{
			return default(TextureHandle);
		}

		internal TextureHandle ImportTexture(RTHandle rt, bool isBuiltin)
		{
			return default(TextureHandle);
		}

		public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt, RenderTargetInfo info, ImportResourceParams importParams = default(ImportResourceParams))
		{
			return default(TextureHandle);
		}

		public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt)
		{
			return default(TextureHandle);
		}

		public TextureHandle CreateTexture(in TextureDesc desc)
		{
			return default(TextureHandle);
		}

		[Obsolete("CreateSharedTexture() and shared texture workflow are deprecated, use ImportTexture() workflow instead.")]
		public TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease = false)
		{
			return default(TextureHandle);
		}

		[Obsolete("RefreshSharedTextureDesc() and shared texture workflow are deprecated, use ImportTexture() workflow instead.")]
		public void RefreshSharedTextureDesc(TextureHandle handle, in TextureDesc desc)
		{
		}

		[Obsolete("ReleaseSharedTexture() and shared texture workflow are deprecated, use ImportTexture() workflow instead.")]
		public void ReleaseSharedTexture(TextureHandle texture)
		{
		}

		public TextureHandle CreateTexture(TextureHandle texture)
		{
			return default(TextureHandle);
		}

		public TextureHandle CreateTexture(TextureHandle texture, string name, bool clear = false)
		{
			return default(TextureHandle);
		}

		public void CreateTextureIfInvalid(in TextureDesc desc, ref TextureHandle texture)
		{
		}

		public TextureDesc GetTextureDesc(in TextureHandle texture)
		{
			return default(TextureDesc);
		}

		public RenderTargetInfo GetRenderTargetInfo(TextureHandle texture)
		{
			return default(RenderTargetInfo);
		}

		public RendererListHandle CreateRendererList(in RendererListDesc desc)
		{
			return default(RendererListHandle);
		}

		public RendererListHandle CreateRendererList(in RendererListParams desc)
		{
			return default(RendererListHandle);
		}

		public RendererListHandle CreateShadowRendererList(ref ShadowDrawingSettings shadowDrawingSettings)
		{
			return default(RendererListHandle);
		}

		public RendererListHandle CreateGizmoRendererList(in Camera camera, in GizmoSubset gizmoSubset)
		{
			return default(RendererListHandle);
		}

		public RendererListHandle CreateUIOverlayRendererList(in Camera camera)
		{
			return default(RendererListHandle);
		}

		public RendererListHandle CreateUIOverlayRendererList(in Camera camera, in UISubset uiSubset)
		{
			return default(RendererListHandle);
		}

		public RendererListHandle CreateWireOverlayRendererList(in Camera camera)
		{
			return default(RendererListHandle);
		}

		public RendererListHandle CreateSkyboxRendererList(in Camera camera)
		{
			return default(RendererListHandle);
		}

		public RendererListHandle CreateSkyboxRendererList(in Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix)
		{
			return default(RendererListHandle);
		}

		public RendererListHandle CreateSkyboxRendererList(in Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR)
		{
			return default(RendererListHandle);
		}

		[Obsolete("ImportBuffer with forceRelease parameter is deprecated. Use ImportBuffer without it instead. #from(6000.3)")]
		public BufferHandle ImportBuffer(GraphicsBuffer graphicsBuffer, bool forceRelease = false)
		{
			return default(BufferHandle);
		}

		public BufferHandle ImportBuffer(GraphicsBuffer graphicsBuffer)
		{
			return default(BufferHandle);
		}

		public BufferHandle CreateBuffer(in BufferDesc desc)
		{
			return default(BufferHandle);
		}

		public BufferHandle CreateBuffer(in BufferHandle graphicsBuffer)
		{
			return default(BufferHandle);
		}

		public BufferDesc GetBufferDesc(in BufferHandle graphicsBuffer)
		{
			return default(BufferDesc);
		}

		public RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(in RayTracingAccelerationStructure accelStruct, string name = null)
		{
			return default(RayTracingAccelerationStructureHandle);
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckNotUsedWhenExecuting()
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckNotUsedWhenRecordingGraph()
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckNotUsedWhenRecordPassOrExecute()
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckNotUsedWhenRecordingPass()
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckNotUsingNativeRenderPassCompiler()
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckUsingNativeRenderPassCompiler()
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckNotUsedWhenActive()
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void CheckNotUsedWhenIdle()
		{
		}

		public IRasterRenderGraphBuilder AddRasterRenderPass<PassData>(string passName, out PassData passData, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0) where PassData : class, new()
		{
			passData = null;
			return null;
		}

		public IRasterRenderGraphBuilder AddRasterRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0) where PassData : class, new()
		{
			passData = null;
			return null;
		}

		public IComputeRenderGraphBuilder AddComputePass<PassData>(string passName, out PassData passData, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0) where PassData : class, new()
		{
			passData = null;
			return null;
		}

		public IComputeRenderGraphBuilder AddComputePass<PassData>(string passName, out PassData passData, ProfilingSampler sampler, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0) where PassData : class, new()
		{
			passData = null;
			return null;
		}

		public IUnsafeRenderGraphBuilder AddUnsafePass<PassData>(string passName, out PassData passData, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0) where PassData : class, new()
		{
			passData = null;
			return null;
		}

		public IUnsafeRenderGraphBuilder AddUnsafePass<PassData>(string passName, out PassData passData, ProfilingSampler sampler, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0) where PassData : class, new()
		{
			passData = null;
			return null;
		}

		[Obsolete("AddRenderPass() is deprecated, use AddRasterRenderPass/AddComputePass/AddUnsafePass() instead.")]
		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0) where PassData : class, new()
		{
			passData = null;
			return default(RenderGraphBuilder);
		}

		[Obsolete("AddRenderPass() is deprecated, use AddRasterRenderPass/AddComputePass/AddUnsafePass() instead.")]
		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0) where PassData : class, new()
		{
			passData = null;
			return default(RenderGraphBuilder);
		}

		public void BeginRecording(in RenderGraphParameters parameters)
		{
		}

		public void EndRecordingAndExecute()
		{
		}

		public bool ResetGraphAndLogException(Exception e)
		{
			return false;
		}

		internal void Execute()
		{
		}

		public void BeginProfilingSampler(ProfilingSampler sampler, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		public void EndProfilingSampler(ProfilingSampler sampler, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		internal DynamicArray<CompiledPassInfo> GetCompiledPassInfos()
		{
			return null;
		}

		internal void ClearCurrentCompiledGraph()
		{
		}

		private void ClearCompiledGraph(CompiledGraph compiledGraph, bool useCompilationCaching)
		{
		}

		private void InvalidateContext()
		{
		}

		internal void OnPassAdded(RenderGraphPass pass)
		{
		}

		internal int ComputeGraphHash()
		{
			return 0;
		}

		private void CountReferences()
		{
		}

		private void CullUnusedPasses()
		{
		}

		private void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex)
		{
		}

		private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, in CompiledResourceInfo resource)
		{
		}

		private int GetFirstValidConsumerIndex(int passIndex, in CompiledResourceInfo info)
		{
			return 0;
		}

		private int FindTextureProducer(int consumerPass, in CompiledResourceInfo info, out int index)
		{
			index = default(int);
			return 0;
		}

		private int GetLatestProducerIndex(int passIndex, in CompiledResourceInfo info)
		{
			return 0;
		}

		private int GetLatestValidReadIndex(in CompiledResourceInfo info)
		{
			return 0;
		}

		private int GetFirstValidWriteIndex(in CompiledResourceInfo info)
		{
			return 0;
		}

		private int GetLatestValidWriteIndex(in CompiledResourceInfo info)
		{
			return 0;
		}

		private void CreateRendererLists()
		{
		}

		internal bool GetImportedFallback(TextureDesc desc, out TextureHandle fallback)
		{
			fallback = default(TextureHandle);
			return false;
		}

		private void AllocateCulledPassResources(ref CompiledPassInfo passInfo)
		{
		}

		private void UpdateResourceAllocationAndSynchronization()
		{
		}

		private void UpdateAllSharedResourceLastFrameIndex()
		{
		}

		private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists)
		{
			return false;
		}

		private void TryCullPassAtIndex(int passIndex)
		{
		}

		private void CullRendererLists()
		{
		}

		private bool UpdateCurrentCompiledGraph(int graphHash, bool forceNoCaching = false)
		{
			return false;
		}

		internal void CompileRenderGraph(int graphHash)
		{
		}

		private ref CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass)
		{
			throw null;
		}

		private void ExecutePassImmediately(RenderGraphPass pass)
		{
		}

		private void ExecuteCompiledPass(ref CompiledPassInfo passInfo)
		{
		}

		private void ExecuteRenderGraph()
		{
		}

		private void PreRenderPassSetRenderTargets(in CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext)
		{
		}

		private void PreRenderPassExecute(in CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext)
		{
		}

		private void PostRenderPassExecute(ref CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext)
		{
		}

		private void ClearRenderPasses()
		{
		}

		private void ReleaseImmediateModeResources()
		{
		}

		private void LogFrameInformation()
		{
		}

		private void LogRendererListsCreation()
		{
		}

		private void LogRenderPassBegin(in CompiledPassInfo passInfo)
		{
		}

		private void LogCulledPasses()
		{
		}

		private ProfilingSampler GetDefaultProfilingSampler(string name)
		{
			return null;
		}

		private void UpdateImportedResourceLifeTime(ref DebugData.ResourceData data, List<int> passList)
		{
		}

		private void RegisterGraph()
		{
		}

		private void UnregisterGraph()
		{
		}

		private static string GetExecutionNameAllocates(EntityId entityId)
		{
			return null;
		}

		private void ClearCacheIfNewActiveDebugSession()
		{
		}

		private void GenerateDebugData(int graphHash)
		{
		}

		private void GenerateCompilerDebugData(ref DebugData debugData)
		{
		}

		internal void SetGlobal(in TextureHandle h, int globalPropertyId)
		{
		}

		internal bool IsGlobal(int globalPropertyId)
		{
			return false;
		}

		internal Dictionary<int, TextureHandle>.ValueCollection AllGlobals()
		{
			return null;
		}

		internal TextureHandle GetGlobal(int globalPropertyId)
		{
			return default(TextureHandle);
		}

		internal void ClearGlobalBindings()
		{
		}
	}
}
