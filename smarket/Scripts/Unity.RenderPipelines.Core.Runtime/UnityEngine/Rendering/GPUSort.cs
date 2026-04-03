using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	public struct GPUSort
	{
		private enum Stage
		{
			LocalBMS = 0,
			LocalDisperse = 1,
			BigFlip = 2,
			BigDisperse = 3
		}

		public struct Args
		{
			public uint count;

			public uint maxDepth;

			public GraphicsBuffer inputKeys;

			public GraphicsBuffer inputValues;

			public SupportResources resources;

			internal int workGroupCount;
		}

		public struct RenderGraphResources
		{
			public BufferHandle sortBufferKeys;

			public BufferHandle sortBufferValues;

			[Obsolete("This Create signature is deprecated and will be removed in the future. Please use Create(IBaseRenderGraphBuilder) instead. #from(6000.3)")]
			public static RenderGraphResources Create(int count, RenderGraph renderGraph, RenderGraphBuilder builder)
			{
				return default(RenderGraphResources);
			}

			public static RenderGraphResources Create(int count, RenderGraph renderGraph, IBaseRenderGraphBuilder builder)
			{
				return default(RenderGraphResources);
			}
		}

		public struct SupportResources
		{
			public GraphicsBuffer sortBufferKeys;

			public GraphicsBuffer sortBufferValues;

			public static SupportResources Load(RenderGraphResources renderGraphResources)
			{
				return default(SupportResources);
			}

			public void Dispose()
			{
			}
		}

		public struct SystemResources
		{
			public ComputeShader computeAsset;
		}

		private const uint kWorkGroupSize = 1024u;

		private LocalKeyword[] m_Keywords;

		private SystemResources resources;

		public GPUSort(SystemResources resources)
		{
			m_Keywords = null;
			this.resources = default(SystemResources);
		}

		private void DispatchStage(CommandBuffer cmd, Args args, uint h, Stage stage)
		{
		}

		private void CopyBuffer(CommandBuffer cmd, GraphicsBuffer src, GraphicsBuffer dst)
		{
		}

		internal static int DivRoundUp(int x, int y)
		{
			return 0;
		}

		public void Dispatch(IComputeCommandBuffer cmd, Args args)
		{
		}

		public void Dispatch(CommandBuffer cmd, Args args)
		{
		}
	}
}
