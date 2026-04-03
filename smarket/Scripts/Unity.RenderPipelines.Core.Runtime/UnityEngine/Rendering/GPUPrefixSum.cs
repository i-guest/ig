using System;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	public struct GPUPrefixSum
	{
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@9a9c0155552c\\Runtime\\Utilities\\GPUPrefixSum\\GPUPrefixSum.Data.cs")]
		internal static class ShaderDefs
		{
			public const int GroupSize = 128;

			public const int ArgsBufferStride = 16;

			public const int ArgsBufferUpper = 0;

			public const int ArgsBufferLower = 8;

			public static int DivUpGroup(int value)
			{
				return 0;
			}

			public static int AlignUpGroup(int value)
			{
				return 0;
			}

			public static void CalculateTotalBufferSize(int maxElementCount, out int totalSize, out int levelCounts)
			{
				totalSize = default(int);
				levelCounts = default(int);
			}
		}

		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@9a9c0155552c\\Runtime\\Utilities\\GPUPrefixSum\\GPUPrefixSum.Data.cs")]
		public struct LevelOffsets
		{
			public uint count;

			public uint offset;

			public uint parentOffset;
		}

		public struct RenderGraphResources
		{
			internal int alignedElementCount;

			internal int maxBufferCount;

			internal int maxLevelCount;

			internal BufferHandle prefixBuffer0;

			internal BufferHandle prefixBuffer1;

			internal BufferHandle totalLevelCountBuffer;

			internal BufferHandle levelOffsetBuffer;

			internal BufferHandle indirectDispatchArgsBuffer;

			public BufferHandle output => default(BufferHandle);

			[Obsolete("This Create signature is deprecated and will be removed in the future. Please use Create(IBaseRenderGraphBuilder) instead. #from(6000.3)")]
			public static RenderGraphResources Create(int newMaxElementCount, RenderGraph renderGraph, RenderGraphBuilder builder, bool outputIsTemp = false)
			{
				return default(RenderGraphResources);
			}

			private void Initialize(int newMaxElementCount, RenderGraph renderGraph, RenderGraphBuilder builder, bool outputIsTemp = false)
			{
			}

			public static RenderGraphResources Create(int newMaxElementCount, RenderGraph renderGraph, IBaseRenderGraphBuilder builder, bool outputIsTemp = false)
			{
				return default(RenderGraphResources);
			}

			private void Initialize(int newMaxElementCount, RenderGraph renderGraph, IBaseRenderGraphBuilder builder, bool outputIsTemp = false)
			{
			}
		}

		public struct SupportResources
		{
			internal bool ownsResources;

			internal int alignedElementCount;

			internal int maxBufferCount;

			internal int maxLevelCount;

			internal GraphicsBuffer prefixBuffer0;

			internal GraphicsBuffer prefixBuffer1;

			internal GraphicsBuffer totalLevelCountBuffer;

			internal GraphicsBuffer levelOffsetBuffer;

			internal GraphicsBuffer indirectDispatchArgsBuffer;

			public GraphicsBuffer output => null;

			public static SupportResources Create(int maxElementCount)
			{
				return default(SupportResources);
			}

			public static SupportResources Load(RenderGraphResources shaderGraphResources)
			{
				return default(SupportResources);
			}

			internal void Resize(int newMaxElementCount)
			{
			}

			private void LoadFromShaderGraph(RenderGraphResources shaderGraphResources)
			{
			}

			public void Dispose()
			{
			}
		}

		public struct DirectArgs
		{
			public bool exclusive;

			public int inputCount;

			public GraphicsBuffer input;

			public SupportResources supportResources;
		}

		public struct IndirectDirectArgs
		{
			public bool exclusive;

			public int inputCountBufferByteOffset;

			public ComputeBuffer inputCountBuffer;

			public GraphicsBuffer input;

			public SupportResources supportResources;
		}

		public struct SystemResources
		{
			public ComputeShader computeAsset;

			internal int kernelCalculateLevelDispatchArgsFromConst;

			internal int kernelCalculateLevelDispatchArgsFromBuffer;

			internal int kernelPrefixSumOnGroup;

			internal int kernelPrefixSumOnGroupExclusive;

			internal int kernelPrefixSumNextInput;

			internal int kernelPrefixSumResolveParent;

			internal int kernelPrefixSumResolveParentExclusive;

			internal void LoadKernels()
			{
			}
		}

		private static class ShaderIDs
		{
			public static readonly int _InputBuffer;

			public static readonly int _OutputBuffer;

			public static readonly int _InputCountBuffer;

			public static readonly int _TotalLevelsBuffer;

			public static readonly int _OutputTotalLevelsBuffer;

			public static readonly int _OutputDispatchLevelArgsBuffer;

			public static readonly int _LevelsOffsetsBuffer;

			public static readonly int _OutputLevelsOffsetsBuffer;

			public static readonly int _PrefixSumIntArgs;
		}

		private SystemResources resources;

		public GPUPrefixSum(SystemResources resources)
		{
			this.resources = default(SystemResources);
		}

		private Vector4 PackPrefixSumArgs(int a, int b, int c, int d)
		{
			return default(Vector4);
		}

		internal void ExecuteCommonIndirect(CommandBuffer cmdBuffer, GraphicsBuffer inputBuffer, in SupportResources supportResources, bool isExclusive)
		{
		}

		public void DispatchDirect(IComputeCommandBuffer cmdBuffer, in DirectArgs arguments)
		{
		}

		public void DispatchDirect(CommandBuffer cmdBuffer, in DirectArgs arguments)
		{
		}

		public void DispatchIndirect(IComputeCommandBuffer cmdBuffer, in IndirectDirectArgs arguments)
		{
		}

		public void DispatchIndirect(CommandBuffer cmdBuffer, in IndirectDirectArgs arguments)
		{
		}
	}
}
