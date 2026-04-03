using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.SceneManagement;

namespace UnityEngine.Rendering
{
	public class ProbeReferenceVolume
	{
		internal static class ShaderIDs
		{
			public static readonly int _APVResIndex;

			public static readonly int _APVResCellIndices;

			public static readonly int _APVResL0_L1Rx;

			public static readonly int _APVResL1G_L1Ry;

			public static readonly int _APVResL1B_L1Rz;

			public static readonly int _APVResL2_0;

			public static readonly int _APVResL2_1;

			public static readonly int _APVResL2_2;

			public static readonly int _APVResL2_3;

			public static readonly int _APVProbeOcclusion;

			public static readonly int _APVResValidity;

			public static readonly int _SkyOcclusionTexL0L1;

			public static readonly int _SkyShadingDirectionIndicesTex;

			public static readonly int _SkyPrecomputedDirections;

			public static readonly int _AntiLeakData;
		}

		[Serializable]
		internal struct IndirectionEntryInfo
		{
			public Vector3Int positionInBricks;

			public int minSubdiv;

			public Vector3Int minBrickPos;

			public Vector3Int maxBrickPosPlusOne;

			public bool hasMinMax;

			public bool hasOnlyBiggerBricks;
		}

		[Serializable]
		internal class CellDesc
		{
			public Vector3Int position;

			public int index;

			public int probeCount;

			public int minSubdiv;

			public int indexChunkCount;

			public int shChunkCount;

			public int bricksCount;

			public IndirectionEntryInfo[] indirectionEntryInfo;

			public override string ToString()
			{
				return null;
			}
		}

		internal class CellData
		{
			public struct PerScenarioData
			{
				public NativeArray<ushort> shL0L1RxData;

				public NativeArray<byte> shL1GL1RyData;

				public NativeArray<byte> shL1BL1RzData;

				public NativeArray<byte> shL2Data_0;

				public NativeArray<byte> shL2Data_1;

				public NativeArray<byte> shL2Data_2;

				public NativeArray<byte> shL2Data_3;

				public NativeArray<byte> probeOcclusion;
			}

			public NativeArray<byte> validityNeighMaskData;

			public Dictionary<string, PerScenarioData> scenarios;

			public NativeArray<ushort> skyOcclusionDataL0L1 { get; internal set; }

			public NativeArray<byte> skyShadingDirectionIndices { get; internal set; }

			public NativeArray<ProbeBrickIndex.Brick> bricks { get; internal set; }

			public NativeArray<Vector3> probePositions { get; internal set; }

			public NativeArray<float> touchupVolumeInteraction { get; internal set; }

			public NativeArray<Vector3> offsetVectors { get; internal set; }

			public NativeArray<float> validity { get; internal set; }

			public NativeArray<byte> layer { get; internal set; }

			public void CleanupPerScenarioData(in PerScenarioData data)
			{
			}

			public void Cleanup(bool cleanScenarioList)
			{
			}
		}

		internal class CellPoolInfo
		{
			public List<ProbeBrickPool.BrickChunkAlloc> chunkList;

			public int shChunkCount;

			public void Clear()
			{
			}
		}

		internal class CellIndexInfo
		{
			public int[] flatIndicesInGlobalIndirection;

			public ProbeBrickIndex.CellIndexUpdateInfo updateInfo;

			public bool indexUpdated;

			public IndirectionEntryInfo[] indirectionEntryInfo;

			public int indexChunkCount;

			public void Clear()
			{
			}
		}

		internal class CellBlendingInfo
		{
			public List<ProbeBrickPool.BrickChunkAlloc> chunkList;

			public float blendingScore;

			public float blendingFactor;

			public bool blending;

			public void MarkUpToDate()
			{
			}

			public bool IsUpToDate()
			{
				return false;
			}

			public void ForceReupload()
			{
			}

			public bool ShouldReupload()
			{
				return false;
			}

			public void Prioritize()
			{
			}

			public bool ShouldPrioritize()
			{
				return false;
			}

			public void Clear()
			{
			}
		}

		internal class CellStreamingInfo
		{
			public CellStreamingRequest request;

			public CellStreamingRequest blendingRequest0;

			public CellStreamingRequest blendingRequest1;

			public float streamingScore;

			public bool IsStreaming()
			{
				return false;
			}

			public bool IsBlendingStreaming()
			{
				return false;
			}

			public void Clear()
			{
			}
		}

		[DebuggerDisplay("Index = {desc.index} Loaded = {loaded}")]
		internal class Cell : IComparable<Cell>
		{
			public CellDesc desc;

			public CellData data;

			public CellPoolInfo poolInfo;

			public CellIndexInfo indexInfo;

			public CellBlendingInfo blendingInfo;

			public CellStreamingInfo streamingInfo;

			public int referenceCount;

			public bool loaded;

			public CellData.PerScenarioData scenario0;

			public CellData.PerScenarioData scenario1;

			public bool hasTwoScenarios;

			public CellInstancedDebugProbes debugProbes;

			public int CompareTo(Cell other)
			{
				return 0;
			}

			public bool UpdateCellScenarioData(string scenario0, string scenario1)
			{
				return false;
			}

			public void Clear()
			{
			}
		}

		internal struct Volume : IEquatable<Volume>
		{
			internal Vector3 corner;

			internal Vector3 X;

			internal Vector3 Y;

			internal Vector3 Z;

			internal float maxSubdivisionMultiplier;

			internal float minSubdivisionMultiplier;

			public Volume(Matrix4x4 trs, float maxSubdivision, float minSubdivision)
			{
				corner = default(Vector3);
				X = default(Vector3);
				Y = default(Vector3);
				Z = default(Vector3);
				maxSubdivisionMultiplier = 0f;
				minSubdivisionMultiplier = 0f;
			}

			public Volume(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1f, float minSubdivision = 0f)
			{
				this.corner = default(Vector3);
				this.X = default(Vector3);
				this.Y = default(Vector3);
				this.Z = default(Vector3);
				maxSubdivisionMultiplier = 0f;
				minSubdivisionMultiplier = 0f;
			}

			public Volume(Volume copy)
			{
				corner = default(Vector3);
				X = default(Vector3);
				Y = default(Vector3);
				Z = default(Vector3);
				maxSubdivisionMultiplier = 0f;
				minSubdivisionMultiplier = 0f;
			}

			public Volume(Bounds bounds)
			{
				corner = default(Vector3);
				X = default(Vector3);
				Y = default(Vector3);
				Z = default(Vector3);
				maxSubdivisionMultiplier = 0f;
				minSubdivisionMultiplier = 0f;
			}

			public Bounds CalculateAABB()
			{
				return default(Bounds);
			}

			public void CalculateCenterAndSize(out Vector3 center, out Vector3 size)
			{
				center = default(Vector3);
				size = default(Vector3);
			}

			public void Transform(Matrix4x4 trs)
			{
			}

			public override string ToString()
			{
				return null;
			}

			public bool Equals(Volume other)
			{
				return false;
			}
		}

		internal struct RefVolTransform
		{
			public Vector3 posWS;

			public Quaternion rot;

			public float scale;
		}

		public struct RuntimeResources
		{
			public ComputeBuffer index;

			public ComputeBuffer cellIndices;

			public RenderTexture L0_L1rx;

			public RenderTexture L1_G_ry;

			public RenderTexture L1_B_rz;

			public RenderTexture L2_0;

			public RenderTexture L2_1;

			public RenderTexture L2_2;

			public RenderTexture L2_3;

			public RenderTexture ProbeOcclusion;

			public RenderTexture Validity;

			public RenderTexture SkyOcclusionL0L1;

			public RenderTexture SkyShadingDirectionIndices;

			public ComputeBuffer SkyPrecomputedDirections;

			public ComputeBuffer QualityLeakReductionData;
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct ExtraDataActionInput
		{
		}

		internal class CellInstancedDebugProbes
		{
			public List<Matrix4x4[]> probeBuffers;

			public List<Matrix4x4[]> offsetBuffers;

			public List<MaterialPropertyBlock> props;
		}

		private class RenderFragmentationOverlayPassData
		{
			public Material debugFragmentationMaterial;

			public DebugOverlay debugOverlay;

			public int chunkCount;

			public ComputeBuffer debugFragmentationData;

			public TextureHandle colorBuffer;

			public TextureHandle depthBuffer;
		}

		internal class DiskStreamingRequest
		{
			private ReadHandle m_ReadHandle;

			private ReadCommandArray m_ReadCommandArray;

			private NativeArray<ReadCommand> m_ReadCommandBuffer;

			private int m_BytesWritten;

			public DiskStreamingRequest(int maxRequestCount)
			{
			}

			public unsafe void AddReadCommand(int offset, int size, byte* dest)
			{
			}

			public int RunCommands(FileHandle file)
			{
				return 0;
			}

			public void Clear()
			{
			}

			public void Cancel()
			{
			}

			public void Wait()
			{
			}

			public void Dispose()
			{
			}

			public ReadStatus GetStatus()
			{
				return default(ReadStatus);
			}
		}

		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@9a9c0155552c\\Runtime\\Lighting\\ProbeVolume\\ProbeReferenceVolume.Streaming.cs", needAccessors = false, generateCBuffer = true)]
		internal struct CellStreamingScratchBufferLayout
		{
			public int _SharedDestChunksOffset;

			public int _L0L1rxOffset;

			public int _L1GryOffset;

			public int _L1BrzOffset;

			public int _ValidityOffset;

			public int _ProbeOcclusionOffset;

			public int _SkyOcclusionOffset;

			public int _SkyShadingDirectionOffset;

			public int _L2_0Offset;

			public int _L2_1Offset;

			public int _L2_2Offset;

			public int _L2_3Offset;

			public int _L0Size;

			public int _L0ProbeSize;

			public int _L1Size;

			public int _L1ProbeSize;

			public int _ValiditySize;

			public int _ValidityProbeSize;

			public int _ProbeOcclusionSize;

			public int _ProbeOcclusionProbeSize;

			public int _SkyOcclusionSize;

			public int _SkyOcclusionProbeSize;

			public int _SkyShadingDirectionSize;

			public int _SkyShadingDirectionProbeSize;

			public int _L2Size;

			public int _L2ProbeSize;

			public int _ProbeCountInChunkLine;

			public int _ProbeCountInChunkSlice;
		}

		internal class CellStreamingScratchBuffer
		{
			public NativeArray<byte> stagingBuffer;

			private int m_CurrentBuffer;

			private GraphicsBuffer[] m_GraphicsBuffers;

			public GraphicsBuffer buffer => null;

			public int chunkCount { get; }

			public int chunkSize { get; }

			public CellStreamingScratchBuffer(int chunkCount, int chunkSize, bool allocateGraphicsBuffers)
			{
			}

			public void Swap()
			{
			}

			public void Dispose()
			{
			}
		}

		[DebuggerDisplay("Index = {cell.desc.index} State = {state}")]
		internal class CellStreamingRequest
		{
			public enum State
			{
				Pending = 0,
				Active = 1,
				Canceled = 2,
				Invalid = 3,
				Complete = 4
			}

			public delegate void OnStreamingCompleteDelegate(CellStreamingRequest request, CommandBuffer cmd);

			public OnStreamingCompleteDelegate onStreamingComplete;

			public DiskStreamingRequest cellDataStreamingRequest;

			public DiskStreamingRequest cellOptionalDataStreamingRequest;

			public DiskStreamingRequest cellSharedDataStreamingRequest;

			public DiskStreamingRequest cellProbeOcclusionDataStreamingRequest;

			public DiskStreamingRequest brickStreamingRequest;

			public DiskStreamingRequest supportStreamingRequest;

			public int bytesWritten;

			public Cell cell { get; set; }

			public State state { get; set; }

			public CellStreamingScratchBuffer scratchBuffer { get; set; }

			public CellStreamingScratchBufferLayout scratchBufferLayout { get; set; }

			public ProbeVolumeBakingSet.PerScenarioDataInfo scenarioData { get; set; }

			public int poolIndex { get; set; }

			public bool streamSharedData { get; set; }

			public bool IsStreaming()
			{
				return false;
			}

			public void Cancel()
			{
			}

			public void WaitAll()
			{
			}

			public bool UpdateRequestState(DiskStreamingRequest request, ref bool isComplete)
			{
				return false;
			}

			public void UpdateState()
			{
			}

			public void Clear()
			{
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		private ComputeBuffer m_EmptyIndexBuffer;

		private bool m_IsInitialized;

		private bool m_SupportScenarios;

		private bool m_SupportScenarioBlending;

		private bool m_ForceNoDiskStreaming;

		private bool m_SupportDiskStreaming;

		private bool m_SupportGPUStreaming;

		private bool m_UseStreamingAssets;

		private float m_MinBrickSize;

		private int m_MaxSubdivision;

		private Vector3 m_ProbeOffset;

		private ProbeBrickPool m_Pool;

		private ProbeBrickIndex m_Index;

		private ProbeGlobalIndirection m_CellIndices;

		private ProbeBrickBlendingPool m_BlendingPool;

		private List<ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks;

		private float[] m_PositionOffsets;

		private Bounds m_CurrGlobalBounds;

		internal Dictionary<int, Cell> cells;

		private ObjectPool<Cell> m_CellPool;

		private ProbeBrickPool.DataLocation m_TemporaryDataLocation;

		private int m_TemporaryDataLocationMemCost;

		[Obsolete("This field is only kept for migration purpose. #from(2023.3)")]
		internal ProbeVolumeSceneData sceneData;

		private Vector3Int minLoadedCellPos;

		private Vector3Int maxLoadedCellPos;

		public Action<ExtraDataActionInput> retrieveExtraDataAction;

		public Action checksDuringBakeAction;

		private Dictionary<string, (ProbeVolumeBakingSet, List<int>)> m_PendingScenesToBeLoaded;

		private Dictionary<string, List<int>> m_PendingScenesToBeUnloaded;

		private List<string> m_ActiveScenes;

		private ProbeVolumeBakingSetWeakReference m_CurrentBakingSetReference;

		private ProbeVolumeBakingSetWeakReference m_LazyBakingSetReference;

		private bool m_NeedLoadAsset;

		private bool m_ProbeReferenceVolumeInit;

		private bool m_EnabledBySRP;

		private bool m_VertexSampling;

		private bool m_NeedsIndexRebuild;

		private bool m_HasChangedIndex;

		private int m_CBShaderID;

		private ProbeVolumeTextureMemoryBudget m_MemoryBudget;

		private ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget;

		private ProbeVolumeSHBands m_SHBands;

		internal bool clearAssetsOnVolumeClear;

		internal static string defaultLightingScenario;

		private static ProbeReferenceVolume _instance;

		private const int kProbesPerBatch = 511;

		public static readonly string k_DebugPanelName;

		private Mesh m_DebugMesh;

		private DebugUI.Widget[] m_DebugItems;

		private Material m_DebugMaterial;

		private Mesh m_DebugProbeSamplingMesh;

		private Material m_ProbeSamplingDebugMaterial;

		private Material m_ProbeSamplingDebugMaterial02;

		private Texture m_DisplayNumbersTexture;

		internal static ProbeSamplingDebugData probeSamplingDebugData;

		private Mesh m_DebugOffsetMesh;

		private Material m_DebugOffsetMaterial;

		private Material m_DebugFragmentationMaterial;

		private Plane[] m_DebugFrustumPlanes;

		private GUIContent[] m_DebugScenarioNames;

		private int[] m_DebugScenarioValues;

		private string m_DebugActiveSceneGUID;

		private string m_DebugActiveScenario;

		private DebugUI.EnumField m_DebugScenarioField;

		internal Dictionary<Bounds, ProbeBrickIndex.Brick[]> realtimeSubdivisionInfo;

		private bool m_MaxSubdivVisualizedIsMaxAvailable;

		private static Vector4[] s_BoundsArray;

		private bool m_LoadMaxCellsPerFrame;

		private const int kMaxCellLoadedPerFrame = 10;

		private int m_NumberOfCellsLoadedPerFrame;

		private int m_NumberOfCellsBlendedPerFrame;

		private float m_TurnoverRate;

		private DynamicArray<Cell> m_LoadedCells;

		private DynamicArray<Cell> m_ToBeLoadedCells;

		private DynamicArray<Cell> m_WorseLoadedCells;

		private DynamicArray<Cell> m_BestToBeLoadedCells;

		private DynamicArray<Cell> m_TempCellToLoadList;

		private DynamicArray<Cell> m_TempCellToUnloadList;

		private DynamicArray<Cell> m_LoadedBlendingCells;

		private DynamicArray<Cell> m_ToBeLoadedBlendingCells;

		private DynamicArray<Cell> m_TempBlendingCellToLoadList;

		private DynamicArray<Cell> m_TempBlendingCellToUnloadList;

		private Vector3 m_FrozenCameraPosition;

		private Vector3 m_FrozenCameraDirection;

		private const float kIndexFragmentationThreshold = 0.2f;

		private bool m_IndexDefragmentationInProgress;

		private ProbeBrickIndex m_DefragIndex;

		private ProbeGlobalIndirection m_DefragCellIndices;

		private DynamicArray<Cell> m_IndexDefragCells;

		private DynamicArray<Cell> m_TempIndexDefragCells;

		internal float minStreamingScore;

		internal float maxStreamingScore;

		private Queue<CellStreamingRequest> m_StreamingQueue;

		private List<CellStreamingRequest> m_ActiveStreamingRequests;

		private ObjectPool<CellStreamingRequest> m_StreamingRequestsPool;

		private bool m_DiskStreamingUseCompute;

		private ProbeVolumeScratchBufferPool m_ScratchBufferPool;

		private CellStreamingRequest.OnStreamingCompleteDelegate m_OnStreamingComplete;

		private CellStreamingRequest.OnStreamingCompleteDelegate m_OnBlendingStreamingComplete;

		private static DynamicArray<Cell>.SortComparer s_BlendingComparer;

		private static DynamicArray<Cell>.SortComparer s_DefragComparer;

		internal Bounds globalBounds
		{
			get
			{
				return default(Bounds);
			}
			set
			{
			}
		}

		private ProbeVolumeBakingSet m_CurrentBakingSet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private ProbeVolumeBakingSet m_LazyBakingSet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isInitialized => false;

		internal bool enabledBySRP => false;

		internal bool vertexSampling => false;

		internal bool hasUnloadedCells => false;

		internal bool supportLightingScenarios => false;

		internal bool supportScenarioBlending => false;

		internal bool gpuStreamingEnabled => false;

		internal bool diskStreamingEnabled => false;

		public bool probeOcclusion => false;

		public bool skyOcclusion => false;

		public bool skyOcclusionShadingDirection => false;

		private bool useRenderingLayers => false;

		public ProbeVolumeSHBands shBands => default(ProbeVolumeSHBands);

		public ProbeVolumeBakingSet currentBakingSet => null;

		public string lightingScenario
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string otherScenario => null;

		public float scenarioBlendingFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ProbeVolumeTextureMemoryBudget memoryBudget => default(ProbeVolumeTextureMemoryBudget);

		internal List<ProbeVolumePerSceneData> perSceneDataList { get; private set; }

		internal float indexFragmentationRate => 0f;

		public static ProbeReferenceVolume instance => null;

		internal ProbeVolumeDebug probeVolumeDebug { get; }

		public Color[] subdivisionDebugColors { get; }

		private Mesh debugMesh => null;

		public bool loadMaxCellsPerFrame
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private int numberOfCellsLoadedPerFrame => 0;

		public int numberOfCellsBlendedPerFrame
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float turnoverRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void BindAPVRuntimeResources(CommandBuffer cmdBuffer, bool isProbeVolumeEnabled)
		{
		}

		public bool UpdateShaderVariablesProbeVolumes(CommandBuffer cmd, ProbeVolumesOptions probeVolumeOptions, int taaFrameIndex, bool supportRenderingLayers = false)
		{
			return false;
		}

		internal static string GetSceneGUID(Scene scene)
		{
			return null;
		}

		internal void SetActiveScenario(string scenario, bool verbose = true)
		{
		}

		public void BlendLightingScenario(string otherScenario, float blendingFactor)
		{
		}

		internal void RegisterPerSceneData(ProbeVolumePerSceneData data)
		{
		}

		internal bool ScheduleBakingSet(ProbeVolumeBakingSet bakingSet)
		{
			return false;
		}

		internal bool ProcessScheduledBakingSet()
		{
			return false;
		}

		public void SetActiveScene(Scene scene)
		{
		}

		public void SetActiveBakingSet(ProbeVolumeBakingSet bakingSet)
		{
		}

		private void SetBakingSetAsCurrent(ProbeVolumeBakingSet bakingSet)
		{
		}

		internal void RegisterBakingSet(ProbeVolumePerSceneData data)
		{
		}

		internal void UnloadBakingSet()
		{
		}

		internal void UnregisterPerSceneData(ProbeVolumePerSceneData data)
		{
		}

		internal bool TryGetPerSceneData(string sceneGUID, out ProbeVolumePerSceneData perSceneData)
		{
			perSceneData = null;
			return false;
		}

		public void Initialize(in ProbeVolumeSystemParameters parameters)
		{
		}

		public void SetEnableStateFromSRP(bool srpEnablesPV)
		{
		}

		public void SetVertexSamplingEnabled(bool value)
		{
		}

		internal void ForceMemoryBudget(ProbeVolumeTextureMemoryBudget budget)
		{
		}

		internal void ForceSHBand(ProbeVolumeSHBands shBands)
		{
		}

		internal void ForceNoDiskStreaming(bool state)
		{
		}

		public void Cleanup()
		{
		}

		public int GetVideoMemoryCost()
		{
			return 0;
		}

		private void RemoveCell(int cellIndex)
		{
		}

		internal void UnloadCell(Cell cell)
		{
		}

		internal void UnloadBlendingCell(Cell cell)
		{
		}

		internal void UnloadAllCells()
		{
		}

		internal void UnloadAllBlendingCells()
		{
		}

		private void AddCell(int cellIndex)
		{
		}

		internal bool LoadCell(Cell cell, bool ignoreErrorLog = false)
		{
			return false;
		}

		internal void LoadAllCells()
		{
		}

		private void ComputeCellGlobalInfo()
		{
		}

		internal void AddPendingSceneLoading(string sceneGUID, ProbeVolumeBakingSet bakingSet)
		{
		}

		internal void AddPendingSceneRemoval(string sceneGUID)
		{
		}

		internal void RemovePendingScene(string sceneGUID, List<int> cellList)
		{
		}

		private void PerformPendingIndexChangeAndInit()
		{
		}

		internal void SetSubdivisionDimensions(float minBrickSize, int maxSubdiv, Vector3 offset)
		{
		}

		private bool LoadCells(List<int> cellIndices)
		{
			return false;
		}

		private void PerformPendingLoading()
		{
		}

		private void PerformPendingDeletion()
		{
		}

		internal void ComputeEntryMinMax(ref IndirectionEntryInfo entryInfo, ReadOnlySpan<ProbeBrickIndex.Brick> bricks)
		{
		}

		internal static int GetNumberOfBricksAtSubdiv(IndirectionEntryInfo entryInfo)
		{
			return 0;
		}

		public void PerformPendingOperations()
		{
		}

		internal void InitializeGlobalIndirection()
		{
		}

		private void InitProbeReferenceVolume()
		{
		}

		private ProbeReferenceVolume()
		{
		}

		public RuntimeResources GetRuntimeResources()
		{
			return default(RuntimeResources);
		}

		internal void SetMaxSubdivision(int maxSubdivision)
		{
		}

		internal static int CellSize(int subdivisionLevel)
		{
			return 0;
		}

		internal float BrickSize(int subdivisionLevel)
		{
			return 0f;
		}

		internal float MinBrickSize()
		{
			return 0f;
		}

		internal float MaxBrickSize()
		{
			return 0f;
		}

		internal Vector3 ProbeOffset()
		{
			return default(Vector3);
		}

		internal int GetMaxSubdivision()
		{
			return 0;
		}

		internal int GetMaxSubdivision(float multiplier)
		{
			return 0;
		}

		internal float GetDistanceBetweenProbes(int subdivisionLevel)
		{
			return 0f;
		}

		internal float MinDistanceBetweenProbes()
		{
			return 0f;
		}

		internal int GetGlobalIndirectionEntryMaxSubdiv()
		{
			return 0;
		}

		internal int GetEntrySubdivLevel()
		{
			return 0;
		}

		internal float GetEntrySize()
		{
			return 0f;
		}

		public bool DataHasBeenLoaded()
		{
			return false;
		}

		internal void Clear()
		{
		}

		private List<ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, ProbeBrickPool.DataLocation dataLoc)
		{
			return null;
		}

		private void UpdateDataLocationTexture<T>(Texture output, NativeArray<T> input) where T : struct
		{
		}

		private void UpdateValidityTextureWithoutMask(Texture output, NativeArray<byte> input)
		{
		}

		private void UpdatePool(List<ProbeBrickPool.BrickChunkAlloc> chunkList, CellData.PerScenarioData data, NativeArray<byte> validityNeighMaskData, NativeArray<ushort> skyOcclusionL0L1Data, NativeArray<byte> skyShadingDirectionIndices, int chunkIndex, int poolIndex)
		{
		}

		private void UpdatePool(CommandBuffer cmd, List<ProbeBrickPool.BrickChunkAlloc> chunkList, CellStreamingScratchBuffer dataBuffer, CellStreamingScratchBufferLayout layout, int poolIndex)
		{
		}

		private void UpdateSharedData(List<ProbeBrickPool.BrickChunkAlloc> chunkList, NativeArray<byte> validityNeighMaskData, NativeArray<ushort> skyOcclusionData, NativeArray<byte> skyShadingDirectionIndices, int chunkIndex)
		{
		}

		private bool AddBlendingBricks(Cell cell)
		{
			return false;
		}

		private bool ReservePoolChunks(int brickCount, List<ProbeBrickPool.BrickChunkAlloc> chunkList, bool ignoreErrorLog)
		{
			return false;
		}

		private void ReleasePoolChunks(List<ProbeBrickPool.BrickChunkAlloc> chunkList)
		{
		}

		private void UpdatePoolAndIndex(Cell cell, CellStreamingScratchBuffer dataBuffer, CellStreamingScratchBufferLayout layout, int poolIndex, CommandBuffer cmd)
		{
		}

		private bool AddBricks(Cell cell)
		{
			return false;
		}

		private void UpdateCellIndex(Cell cell)
		{
		}

		private void ReleaseBricks(Cell cell)
		{
		}

		internal void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters)
		{
		}

		private void DeinitProbeReferenceVolume()
		{
		}

		private void CleanupLoadedData()
		{
		}

		[Obsolete("Use the other override to support sampling offset in debug modes. #from(6000.0)")]
		public void RenderDebug(Camera camera, Texture exposureTexture)
		{
		}

		public void RenderDebug(Camera camera, ProbeVolumesOptions options, Texture exposureTexture)
		{
		}

		public bool IsProbeSamplingDebugEnabled()
		{
			return false;
		}

		public bool GetProbeSamplingDebugResources(Camera camera, out GraphicsBuffer resultBuffer, out Vector2 coords)
		{
			resultBuffer = null;
			coords = default(Vector2);
			return false;
		}

		private bool TryCreateDebugRenderData()
		{
			return false;
		}

		private void InitializeDebug()
		{
		}

		private void CleanupDebug()
		{
		}

		private void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value)
		{
		}

		private void RegisterDebug()
		{
		}

		private void UnregisterDebug(bool destroyPanel)
		{
		}

		public void RenderFragmentationOverlay(RenderGraph renderGraph, TextureHandle colorBuffer, TextureHandle depthBuffer, DebugOverlay debugOverlay)
		{
		}

		private bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Plane[] frustumPlanes)
		{
			return false;
		}

		private static void UpdateDebugFromSelection(ref Vector4[] _AdjustmentVolumeBounds, ref int _AdjustmentVolumeCount)
		{
		}

		private Bounds GetCellBounds(Vector3 cellPosition)
		{
			return default(Bounds);
		}

		private bool ShouldCullCell(Vector3 cellPosition, Vector4[] adjustmentVolumeBounds, int adjustmentVolumeCount)
		{
			return false;
		}

		private void DrawProbeDebug(Camera camera, Texture exposureTexture)
		{
		}

		internal void ResetDebugViewToMaxSubdiv()
		{
		}

		private void ClearDebugData()
		{
		}

		private static void DecompressSH(ref SphericalHarmonicsL2 shv)
		{
		}

		internal static Vector3 DecodeSkyShadingDirection(uint directionIndex)
		{
			return default(Vector3);
		}

		internal bool GetFlattenedProbeData(string scenario, out Vector3[] positions, out SphericalHarmonicsL2[] irradiance, out float[] validity, out Vector4[] occlusion, out Vector4[] skyOcclusion, out Vector3[] skyOcclusionDirections, out Vector3[] virtualOffset)
		{
			positions = null;
			irradiance = null;
			validity = null;
			occlusion = null;
			skyOcclusion = null;
			skyOcclusionDirections = null;
			virtualOffset = null;
			return false;
		}

		private CellInstancedDebugProbes CreateInstancedProbes(Cell cell)
		{
			return null;
		}

		private void OnClearLightingdata()
		{
		}

		public void EnableMaxCellStreaming(bool value)
		{
		}

		public void SetNumberOfCellsLoadedPerFrame(int numberOfCells)
		{
		}

		private void InitStreaming()
		{
		}

		private void CleanupStreaming()
		{
		}

		internal void ScenarioBlendingChanged(bool scenarioChanged)
		{
		}

		private static void ComputeCellStreamingScore(Cell cell, Vector3 cameraPosition, Vector3 cameraDirection)
		{
		}

		private void ComputeStreamingScore(Vector3 cameraPosition, Vector3 cameraDirection, DynamicArray<Cell> cells)
		{
		}

		private void ComputeBestToBeLoadedCells(Vector3 cameraPosition, Vector3 cameraDirection)
		{
		}

		private void ComputeStreamingScoreAndWorseLoadedCells(Vector3 cameraPosition, Vector3 cameraDirection)
		{
		}

		private void ComputeBlendingScore(DynamicArray<Cell> cells, float worstScore)
		{
		}

		private bool TryLoadCell(Cell cell, ref int shBudget, ref int indexBudget, DynamicArray<Cell> loadedCells)
		{
			return false;
		}

		private void UnloadBlendingCell(Cell cell, DynamicArray<Cell> unloadedCells)
		{
		}

		private bool TryLoadBlendingCell(Cell cell, DynamicArray<Cell> loadedCells)
		{
			return false;
		}

		private void ComputeMinMaxStreamingScore()
		{
		}

		public void UpdateCellStreaming(CommandBuffer cmd, Camera camera)
		{
		}

		public void UpdateCellStreaming(CommandBuffer cmd, Camera camera, ProbeVolumesOptions options)
		{
		}

		private int FindWorstBlendingCellToBeLoaded()
		{
			return 0;
		}

		private static int BlendingComparer(Cell a, Cell b)
		{
			return 0;
		}

		private void UpdateBlendingCellStreaming(CommandBuffer cmd)
		{
		}

		private static int DefragComparer(Cell a, Cell b)
		{
			return 0;
		}

		private void StartIndexDefragmentation()
		{
		}

		private void UpdateIndexDefragmentation()
		{
		}

		private void OnStreamingComplete(CellStreamingRequest request, CommandBuffer cmd)
		{
		}

		private void OnBlendingStreamingComplete(CellStreamingRequest request, CommandBuffer cmd)
		{
		}

		private void PushDiskStreamingRequest(Cell cell, string scenario, int poolIndex, CellStreamingRequest.OnStreamingCompleteDelegate onStreamingComplete)
		{
		}

		private void CancelStreamingRequest(Cell cell)
		{
		}

		private void CancelBlendingStreamingRequest(Cell cell)
		{
		}

		private bool ProcessDiskStreamingRequest(CellStreamingRequest request)
		{
			return false;
		}

		private void AllocateScratchBufferPoolIfNeeded()
		{
		}

		private void UpdateActiveRequests(CommandBuffer cmd)
		{
		}

		private void ProcessNewRequests()
		{
		}

		private void UpdateDiskStreaming(CommandBuffer cmd)
		{
		}

		private bool HasActiveStreamingRequest(Cell cell)
		{
			return false;
		}

		[Conditional("UNITY_EDITOR")]
		[Conditional("DEVELOPMENT_BUILD")]
		private void LogStreaming(string log)
		{
		}
	}
}
