using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	internal abstract class RenderGraphPass
	{
		public struct RandomWriteResourceInfo
		{
			public ResourceHandle h;

			public bool preserveCounterValue;
		}

		public List<ResourceHandle>[] resourceReadLists;

		public List<ResourceHandle>[] resourceWriteLists;

		public List<ResourceHandle>[] transientResourceList;

		public List<RendererListHandle> usedRendererListList;

		public List<(TextureHandle, int)> setGlobalsList;

		public bool useAllGlobalTextures;

		public List<ResourceHandle> implicitReadsList;

		public string name { get; protected set; }

		public int index { get; protected set; }

		public RenderGraphPassType type { get; internal set; }

		public ProfilingSampler customSampler { get; protected set; }

		public bool enableAsyncCompute { get; protected set; }

		public bool allowPassCulling { get; protected set; }

		public bool allowGlobalState { get; protected set; }

		public bool enableFoveatedRasterization { get; protected set; }

		public ExtendedFeatureFlags extendedFeatureFlags { get; protected set; }

		public TextureAccess depthAccess { get; protected set; }

		public TextureAccess[] colorBufferAccess { get; protected set; }

		public int colorBufferMaxIndex { get; protected set; }

		public bool hasShadingRateImage { get; protected set; }

		public TextureAccess shadingRateAccess { get; protected set; }

		public bool hasShadingRateStates { get; protected set; }

		public ShadingRateFragmentSize shadingRateFragmentSize { get; protected set; }

		public ShadingRateCombiner primitiveShadingRateCombiner { get; protected set; }

		public ShadingRateCombiner fragmentShadingRateCombiner { get; protected set; }

		public TextureAccess[] fragmentInputAccess { get; protected set; }

		public int fragmentInputMaxIndex { get; protected set; }

		public RandomWriteResourceInfo[] randomAccessResource { get; protected set; }

		public int randomAccessResourceMaxIndex { get; protected set; }

		public bool generateDebugData { get; protected set; }

		public bool allowRendererListCulling { get; protected set; }

		public abstract void Execute(InternalRenderGraphContext renderGraphContext);

		public abstract void Release(RenderGraphObjectPool pool);

		public abstract bool HasRenderFunc();

		public abstract int GetRenderFuncHash();

		public RenderGraphPass()
		{
		}

		public void Clear()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool HasRenderAttachments()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsTransient(in ResourceHandle res)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsWritten(in ResourceHandle res)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsRead(in ResourceHandle res)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsAttachment(in TextureHandle res)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AddResourceWrite(in ResourceHandle res)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AddResourceRead(in ResourceHandle res)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AddTransientResource(in ResourceHandle res)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void UseRendererList(in RendererListHandle rendererList)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void EnableAsyncCompute(bool value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AllowPassCulling(bool value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void EnableFoveatedRasterization(bool value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AllowRendererListCulling(bool value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AllowGlobalState(bool value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void GenerateDebugData(bool value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetColorBuffer(in TextureHandle resource, int index)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetColorBufferRaw(in TextureHandle resource, int index, AccessFlags accessFlags, int mipLevel, int depthSlice)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetFragmentInputRaw(in TextureHandle resource, int index, AccessFlags accessFlags, int mipLevel, int depthSlice)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetRandomWriteResourceRaw(in ResourceHandle resource, int index, bool preserveCounterValue, AccessFlags accessFlags)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetDepthBuffer(in TextureHandle resource, DepthAccess flags)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetDepthBufferRaw(in TextureHandle resource, AccessFlags accessFlags, int mipLevel, int depthSlice)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ComputeTextureHash(ref HashFNV1A32 generator, in ResourceHandle handle, RenderGraphResourceRegistry resources)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void ComputeHashForTextureAccess(ref HashFNV1A32 generator, in ResourceHandle handle, in TextureAccess textureAccess)
		{
		}

		public void ComputeHash(ref HashFNV1A32 generator, RenderGraphResourceRegistry resources)
		{
		}

		public void SetShadingRateImageRaw(in TextureHandle shadingRateImage)
		{
		}

		public void SetShadingRateImage(in TextureHandle shadingRateImage, AccessFlags accessFlags, int mipLevel, int depthSlice)
		{
		}

		public void SetShadingRateFragmentSize(ShadingRateFragmentSize shadingRateFragmentSize)
		{
		}

		public void SetShadingRateCombiner(ShadingRateCombinerStage stage, ShadingRateCombiner combiner)
		{
		}

		public void SetExtendedFeatureFlags(ExtendedFeatureFlags value)
		{
		}
	}
	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	[Obsolete("RenderGraphPass is deprecated, use RasterRenderGraphPass/ComputeRenderGraphPass/UnsafeRenderGraphPass instead.")]
	internal sealed class RenderGraphPass<PassData> : BaseRenderGraphPass<PassData, RenderGraphContext> where PassData : class, new()
	{
		internal static RenderGraphContext c;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Execute(InternalRenderGraphContext renderGraphContext)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Release(RenderGraphObjectPool pool)
		{
		}
	}
}
