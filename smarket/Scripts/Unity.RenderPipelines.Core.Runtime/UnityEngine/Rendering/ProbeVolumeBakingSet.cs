using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.IO.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering
{
	public sealed class ProbeVolumeBakingSet : ScriptableObject, ISerializationCallbackReceiver
	{
		internal enum Version
		{
			Initial = 0,
			RemoveProbeVolumeSceneData = 1,
			AssetsAlwaysReferenced = 2
		}

		[Serializable]
		internal class PerScenarioDataInfo
		{
			public int sceneHash;

			public ProbeVolumeStreamableAsset cellDataAsset;

			public ProbeVolumeStreamableAsset cellOptionalDataAsset;

			public ProbeVolumeStreamableAsset cellProbeOcclusionDataAsset;

			private bool m_HasValidData;

			public void Initialize(ProbeVolumeSHBands shBands)
			{
			}

			public bool IsValid()
			{
				return false;
			}

			public bool HasValidData(ProbeVolumeSHBands shBands)
			{
				return false;
			}

			public bool ComputeHasValidData(ProbeVolumeSHBands shBands)
			{
				return false;
			}
		}

		[Serializable]
		internal struct CellCounts
		{
			public int bricksCount;

			public int chunksCount;

			public void Add(CellCounts o)
			{
			}
		}

		[Serializable]
		private struct SerializedPerSceneCellList
		{
			public string sceneGUID;

			public List<int> cellList;
		}

		[Serializable]
		internal struct ProbeLayerMask
		{
			public RenderingLayerMask mask;

			public string name;
		}

		[SerializeField]
		internal bool singleSceneMode;

		[SerializeField]
		internal bool dialogNoProbeVolumeInSetShown;

		[SerializeField]
		internal ProbeVolumeBakingProcessSettings settings;

		[SerializeField]
		private List<string> m_SceneGUIDs;

		[SerializeField]
		[Obsolete("This is now contained in the SceneBakeData structure. #from(2023.3)")]
		[FormerlySerializedAs("scenesToNotBake")]
		internal List<string> obsoleteScenesToNotBake;

		[SerializeField]
		[FormerlySerializedAs("lightingScenarios")]
		internal List<string> m_LightingScenarios;

		[SerializeField]
		internal SerializedDictionary<int, ProbeReferenceVolume.CellDesc> cellDescs;

		internal Dictionary<int, ProbeReferenceVolume.CellData> cellDataMap;

		private List<int> m_TotalIndexList;

		[SerializeField]
		private List<SerializedPerSceneCellList> m_SerializedPerSceneCellList;

		internal Dictionary<string, List<int>> perSceneCellLists;

		[SerializeField]
		internal ProbeVolumeStreamableAsset cellSharedDataAsset;

		[SerializeField]
		internal SerializedDictionary<string, PerScenarioDataInfo> scenarios;

		[SerializeField]
		internal ProbeVolumeStreamableAsset cellBricksDataAsset;

		[SerializeField]
		internal ProbeVolumeStreamableAsset cellSupportDataAsset;

		[SerializeField]
		internal int chunkSizeInBricks;

		[SerializeField]
		internal Vector3Int maxCellPosition;

		[SerializeField]
		internal Vector3Int minCellPosition;

		[SerializeField]
		internal Bounds globalBounds;

		[SerializeField]
		internal int bakedSimplificationLevels;

		[SerializeField]
		internal float bakedMinDistanceBetweenProbes;

		[SerializeField]
		internal bool bakedProbeOcclusion;

		[SerializeField]
		internal int bakedSkyOcclusionValue;

		[SerializeField]
		internal int bakedSkyShadingDirectionValue;

		[SerializeField]
		internal Vector3 bakedProbeOffset;

		[SerializeField]
		internal int bakedMaskCount;

		[SerializeField]
		internal uint4 bakedLayerMasks;

		[SerializeField]
		internal int maxSHChunkCount;

		[SerializeField]
		internal int L0ChunkSize;

		[SerializeField]
		internal int L1ChunkSize;

		[SerializeField]
		internal int L2TextureChunkSize;

		[SerializeField]
		internal int ProbeOcclusionChunkSize;

		[SerializeField]
		internal int sharedValidityMaskChunkSize;

		[SerializeField]
		internal int sharedSkyOcclusionL0L1ChunkSize;

		[SerializeField]
		internal int sharedSkyShadingDirectionIndicesChunkSize;

		[SerializeField]
		internal int sharedDataChunkSize;

		[SerializeField]
		internal int supportPositionChunkSize;

		[SerializeField]
		internal int supportValidityChunkSize;

		[SerializeField]
		internal int supportTouchupChunkSize;

		[SerializeField]
		internal int supportLayerMaskChunkSize;

		[SerializeField]
		internal int supportOffsetsChunkSize;

		[SerializeField]
		internal int supportDataChunkSize;

		[SerializeField]
		internal string lightingScenario;

		private string m_OtherScenario;

		private float m_ScenarioBlendingFactor;

		private ReadCommandArray m_ReadCommandArray;

		private NativeArray<ReadCommand> m_ReadCommandBuffer;

		private Stack<NativeArray<byte>> m_ReadOperationScratchBuffers;

		private List<int> m_PrunedIndexList;

		private List<int> m_PrunedScenarioIndexList;

		internal const int k_MaxSkyOcclusionBakingSamples = 8192;

		[SerializeField]
		private Version version;

		[SerializeField]
		internal bool freezePlacement;

		[SerializeField]
		public Vector3 probeOffset;

		[Range(2f, 5f)]
		public int simplificationLevels;

		[Min(0.1f)]
		public float minDistanceBetweenProbes;

		public LayerMask renderersLayerMask;

		[Min(0f)]
		public float minRendererVolumeSize;

		public bool skyOcclusion;

		[Logarithmic(1, 8192)]
		public int skyOcclusionBakingSamples;

		[Range(0f, 5f)]
		public int skyOcclusionBakingBounces;

		[Range(0f, 1f)]
		public float skyOcclusionAverageAlbedo;

		public bool skyOcclusionBackFaceCulling;

		public bool skyOcclusionShadingDirection;

		[SerializeField]
		internal bool useRenderingLayers;

		[SerializeField]
		internal ProbeLayerMask[] renderingLayerMasks;

		private bool m_HasSupportData;

		private bool m_SharedDataIsValid;

		private bool m_UseStreamingAsset;

		internal bool hasDilation => false;

		public IReadOnlyList<string> sceneGUIDs => null;

		public IReadOnlyList<string> lightingScenarios => null;

		internal bool bakedSkyOcclusion
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool bakedSkyShadingDirection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal string otherScenario => null;

		internal float scenarioBlendingFactor => 0f;

		public int cellSizeInBricks => 0;

		public int maxSubdivision => 0;

		public float minBrickSize => 0f;

		public float cellSizeInMeters => 0f;

		internal uint4 ComputeRegionMasks()
		{
			return default(uint4);
		}

		internal static int GetCellSizeInBricks(int simplificationLevels)
		{
			return 0;
		}

		internal static int GetMaxSubdivision(int simplificationLevels)
		{
			return 0;
		}

		internal static float GetMinBrickSize(float minDistanceBetweenProbes)
		{
			return 0f;
		}

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		internal void Migrate()
		{
		}

		private bool ComputeHasValidSharedData()
		{
			return false;
		}

		internal bool HasValidSharedData()
		{
			return false;
		}

		internal bool CheckCompatibleCellLayout()
		{
			return false;
		}

		private bool ComputeHasSupportData()
		{
			return false;
		}

		internal bool HasSupportData()
		{
			return false;
		}

		public bool HasBakedData(string scenario = null)
		{
			return false;
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		internal void Initialize(bool useStreamingAsset)
		{
		}

		internal void Cleanup()
		{
		}

		internal void SetActiveScenario(string scenario, bool verbose = true)
		{
		}

		internal void BlendLightingScenario(string otherScenario, float blendingFactor)
		{
		}

		internal int GetBakingHashCode()
		{
			return 0;
		}

		private static int AlignUp16(int count)
		{
			return 0;
		}

		private NativeArray<T> GetSubArray<T>(NativeArray<byte> input, int count, ref int offset) where T : struct
		{
			return default(NativeArray<T>);
		}

		private NativeArray<byte> RequestScratchBuffer(int size)
		{
			return default(NativeArray<byte>);
		}

		private bool FileExists(string path)
		{
			return false;
		}

		private NativeArray<T> LoadStreambleAssetData<T>(ProbeVolumeStreamableAsset asset, List<int> cellIndices) where T : struct
		{
			return default(NativeArray<T>);
		}

		private void ReleaseStreamableAssetData<T>(NativeArray<T> buffer) where T : struct
		{
		}

		private void PruneCellIndexList(List<int> cellIndices, List<int> prunedIndexList)
		{
		}

		private void PruneCellIndexListForScenario(List<int> cellIndices, PerScenarioDataInfo scenarioData, List<int> prunedIndexList)
		{
		}

		internal List<int> GetSceneCellIndexList(string sceneGUID)
		{
			return null;
		}

		private bool ResolveAllCellData()
		{
			return false;
		}

		internal bool ResolveCellData(List<int> cellIndices)
		{
			return false;
		}

		private void ResolveSharedCellData(List<int> cellIndices, NativeArray<ProbeBrickIndex.Brick> bricksData, NativeArray<byte> cellSharedData, NativeArray<byte> cellSupportData)
		{
		}

		internal bool ResolveSharedCellData(List<int> cellIndices)
		{
			return false;
		}

		internal bool ResolvePerScenarioCellData(List<int> cellIndices)
		{
			return false;
		}

		internal bool ResolvePerScenarioCellData(NativeArray<byte> cellData, NativeArray<byte> cellOptionalData, NativeArray<byte> cellProbeOcclusionData, string scenario, List<int> cellIndices)
		{
			return false;
		}

		internal void ReleaseCell(int cellIndex)
		{
		}

		internal ProbeReferenceVolume.CellDesc GetCellDesc(int cellIndex)
		{
			return null;
		}

		internal ProbeReferenceVolume.CellData GetCellData(int cellIndex)
		{
			return null;
		}

		internal int GetChunkGPUMemory(ProbeVolumeSHBands shBands)
		{
			return 0;
		}

		internal bool HasSameSceneGUIDs(ProbeVolumeBakingSet other)
		{
			return false;
		}
	}
}
