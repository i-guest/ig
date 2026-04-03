using System;
using Unity.Collections;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	internal struct IndirectBufferContextStorage : IDisposable
	{
		private const int kAllocatorCount = 2;

		internal const int kInstanceInfoGpuOffsetMultiplier = 2;

		private IndirectBufferLimits m_BufferLimits;

		private GraphicsBuffer m_InstanceBuffer;

		private GraphicsBuffer m_InstanceInfoBuffer;

		private NativeArray<IndirectInstanceInfo> m_InstanceInfoStaging;

		private GraphicsBuffer m_DispatchArgsBuffer;

		private GraphicsBuffer m_DrawArgsBuffer;

		private GraphicsBuffer m_DrawInfoBuffer;

		private NativeArray<IndirectDrawInfo> m_DrawInfoStaging;

		private int m_ContextAllocCounter;

		private NativeHashMap<int, int> m_ContextIndexFromViewID;

		private NativeList<IndirectBufferContext> m_Contexts;

		private NativeArray<IndirectBufferAllocInfo> m_ContextAllocInfo;

		private NativeArray<int> m_AllocationCounters;

		public GraphicsBuffer instanceBuffer => null;

		public GraphicsBuffer instanceInfoBuffer => null;

		public GraphicsBuffer dispatchArgsBuffer => null;

		public GraphicsBuffer drawArgsBuffer => null;

		public GraphicsBuffer drawInfoBuffer => null;

		public GraphicsBufferHandle visibleInstanceBufferHandle => default(GraphicsBufferHandle);

		public GraphicsBufferHandle indirectDrawArgsBufferHandle => default(GraphicsBufferHandle);

		public NativeArray<IndirectInstanceInfo> instanceInfoGlobalArray => default(NativeArray<IndirectInstanceInfo>);

		public NativeArray<IndirectDrawInfo> drawInfoGlobalArray => default(NativeArray<IndirectDrawInfo>);

		public NativeArray<int> allocationCounters => default(NativeArray<int>);

		public IndirectBufferContextHandles ImportBuffers(RenderGraph renderGraph)
		{
			return default(IndirectBufferContextHandles);
		}

		public void Init()
		{
		}

		private void AllocateInstanceBuffers(int maxInstanceCount)
		{
		}

		private void FreeInstanceBuffers()
		{
		}

		private void AllocateDrawBuffers(int maxDrawCount)
		{
		}

		private void FreeDrawBuffers()
		{
		}

		public void Dispose()
		{
		}

		private void SyncContexts()
		{
		}

		private void ResetAllocators()
		{
		}

		private void GrowBuffers()
		{
		}

		public void ClearContextsAndGrowBuffers()
		{
		}

		public int TryAllocateContext(int viewID)
		{
			return 0;
		}

		public int TryGetContextIndex(int viewID)
		{
			return 0;
		}

		public NativeArray<IndirectBufferAllocInfo> GetAllocInfoSubArray(int contextIndex)
		{
			return default(NativeArray<IndirectBufferAllocInfo>);
		}

		public IndirectBufferAllocInfo GetAllocInfo(int contextIndex)
		{
			return default(IndirectBufferAllocInfo);
		}

		public void CopyFromStaging(CommandBuffer cmd, in IndirectBufferAllocInfo allocInfo)
		{
		}

		public IndirectBufferLimits GetLimits(int contextIndex)
		{
			return default(IndirectBufferLimits);
		}

		public IndirectBufferContext GetBufferContext(int contextIndex)
		{
			return default(IndirectBufferContext);
		}

		public void SetBufferContext(int contextIndex, IndirectBufferContext ctx)
		{
		}
	}
}
