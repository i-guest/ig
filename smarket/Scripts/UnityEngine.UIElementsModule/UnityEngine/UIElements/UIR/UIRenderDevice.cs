using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	internal class UIRenderDevice : IDisposable
	{
		internal struct AllocToUpdate
		{
			public uint id;

			public uint allocTime;

			public MeshHandle meshHandle;

			public Alloc permAllocVerts;

			public Alloc permAllocIndices;

			public Page permPage;

			public bool copyBackIndices;
		}

		private struct AllocToFree
		{
			public Alloc alloc;

			public Page page;

			public bool vertices;
		}

		private struct DeviceToFree
		{
			public uint handle;

			public Page page;

			public CommandListManager commandListManager;

			public void Dispose()
			{
			}
		}

		[Flags]
		private enum EvaluationFlags
		{
			None = 0,
			MustApplyMaterial = 1,
			MustApplyBatchProps = 2,
			MustApplyStencil = 4,
			ForceRenderTypeBitOffset = 3,
			ForceRenderTypeSolid = 8,
			ForceRenderTypeTextured = 0x10,
			ForceRenderTypeText = 0x18,
			ForceRenderTypeSvgGradient = 0x20,
			ForceRenderTypeBits = 0x38,
			TextureSlotCountBitOffset = 6,
			TextureSlotCount1 = 0x40,
			TextureSlotCount2 = 0x80,
			TextureSlotCount4 = 0xC0,
			TextureSlotCount8 = 0x100,
			TextureSlotCountBits = 0x1C0,
			IsSerializing = 0x200,
			IsRenderingNestedTreeRT = 0x400
		}

		private struct EvaluationState
		{
			public CommandList activeCommandList;

			public MaterialPropertyBlock constantProps;

			public MaterialPropertyBlock batchProps;

			public MaterialPropertyBlock userProps;

			public Material material;

			public int stencilRef;

			public Page curPage;

			public EvaluationFlags flags;

			public VisualElement commandListOwner;
		}

		internal struct DrawStatistics
		{
			public int currentFrameIndex;

			public uint totalIndices;

			public uint commandCount;

			public uint skippedCommandCount;

			public uint drawCommandCount;

			public uint disableCommandCount;

			public uint materialSetCount;

			public uint drawRangeCount;

			public uint drawRangeCallCount;

			public uint immediateDraws;

			public uint stencilRefChanges;
		}

		internal const uint k_MaxQueuedFrameCount = 4u;

		internal const int k_PruneEmptyPageFrameCount = 60;

		private IntPtr m_DefaultStencilState;

		private IntPtr m_VertexDecl;

		private Page m_FirstPage;

		private uint m_NextPageVertexCount;

		private uint m_LargeMeshVertexCount;

		private float m_IndexToVertexCountRatio;

		private List<List<AllocToFree>> m_DeferredFrees;

		private List<List<AllocToUpdate>> m_Updates;

		private CommandListManager m_CommandListManager;

		private uint[] m_Fences;

		private MaterialPropertyBlock m_ConstantProps;

		private MaterialPropertyBlock m_BatchProps;

		private uint m_FrameIndex;

		private uint m_NextUpdateID;

		private DrawStatistics m_DrawStats;

		private readonly LinkedPool<MeshHandle> m_MeshHandles;

		private readonly DrawParams m_DrawParams;

		private readonly TextureSlotManager m_TextureSlotManager;

		private HashSet<Material> m_ScreenSpaceAlteredMaterials;

		private static LinkedList<DeviceToFree> m_DeviceFreeQueue;

		private static int m_ActiveDeviceCount;

		private static bool m_SubscribedToNotifications;

		private static bool m_SynchronousFree;

		private static readonly int s_GradientSettingsTexID;

		private static readonly int s_ShaderInfoTexID;

		private static ProfilerMarker s_MarkerAllocate;

		private static ProfilerMarker s_MarkerFree;

		private static ProfilerMarker s_MarkerAdvanceFrame;

		private static ProfilerMarker s_MarkerFence;

		private static ProfilerMarker s_MarkerBeforeDraw;

		private static readonly int[] s_EvaluationFlagsToTextureSlotCount;

		private static readonly int[] s_TextureSlotCountToEvaluationFlags;

		internal static uint maxVerticesPerPage => 0u;

		internal bool breakBatches { get; set; }

		internal bool isFlat { get; }

		internal bool forceGammaRendering { get; }

		protected bool disposed { get; private set; }

		static UIRenderDevice()
		{
		}

		public UIRenderDevice(uint initialVertexCapacity = 0u, uint initialIndexCapacity = 0u, bool isFlat = true, bool forceGammaRendering = false)
		{
		}

		private void InitVertexDeclaration()
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
		{
			vertexData = default(NativeSlice<Vertex>);
			indexData = default(NativeSlice<ushort>);
			indexOffset = default(ushort);
			return null;
		}

		public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex> vertexData)
		{
			vertexData = default(NativeSlice<Vertex>);
		}

		public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
		{
			vertexData = default(NativeSlice<Vertex>);
			indexData = default(NativeSlice<ushort>);
			indexOffset = default(ushort);
		}

		private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices)
		{
		}

		internal List<AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh)
		{
			return null;
		}

		private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived)
		{
			return false;
		}

		private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived)
		{
			vertexData = default(NativeSlice<Vertex>);
			indexData = default(NativeSlice<ushort>);
		}

		private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices)
		{
			vertexData = default(NativeSlice<Vertex>);
			indexData = default(NativeSlice<ushort>);
			indexOffset = default(ushort);
			allocToUpdate = default(AllocToUpdate);
		}

		public void Free(MeshHandle mesh)
		{
		}

		public void OnFrameRenderingBegin()
		{
		}

		internal unsafe static NativeSlice<T> PtrToSlice<T>(void* p, int count) where T : struct
		{
			return default(NativeSlice<T>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int FlagsToTextureSlotCount(EvaluationFlags flags)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EvaluationFlags TextureSlotCountToFlags(TextureSlotCount count)
		{
			return default(EvaluationFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, MaterialPropertyBlock userProps, EvaluationFlags defaultTextureSlotCountFlags, bool kickRanges, Texture gradientSettings, Texture shaderInfo, ref EvaluationState st)
		{
		}

		private void ApplyBatchState(ref EvaluationState st)
		{
		}

		public void EvaluateChain(RenderChainCommand head, Material defaultMat, Texture gradientSettings, Texture shaderInfo, Rect? scissor, float pixelsPerPoint, bool isSerializing, TextureSlotCount defaultTextureSlotCount, bool isRenderingNestedTreeRT, ref Exception immediateException)
		{
		}

		private void ResetScreenSpaceMaterials()
		{
		}

		private void InitializeConstantProperties(MaterialPropertyBlock constantProps, Texture gradientSettings, Texture shaderInfo)
		{
		}

		private void SetupCommandList(ref EvaluationState st, Texture gradientSettings, Texture shaderInfo, CommandFlags commandFlags)
		{
		}

		private void UpdateFenceValue()
		{
		}

		private unsafe void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage, CommandList commandList)
		{
		}

		private void DrawRanges(Utility.GPUBuffer<ushort> ib, Utility.GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges, CommandList commandList)
		{
		}

		private void WaitOnCpuFence(uint fence)
		{
		}

		public void AdvanceFrame()
		{
		}

		private void PruneUnusedPages()
		{
		}

		internal static void PrepareForGfxDeviceRecreate()
		{
		}

		internal static void WrapUpGfxDeviceRecreate()
		{
		}

		internal static void FlushAllPendingDeviceDisposes()
		{
		}

		internal DrawStatistics GatherDrawStatistics()
		{
			return default(DrawStatistics);
		}

		public static void ProcessDeviceFreeQueue()
		{
		}

		private static void OnEngineUpdateGlobal()
		{
		}

		private static void OnFlushPendingResources()
		{
		}
	}
}
