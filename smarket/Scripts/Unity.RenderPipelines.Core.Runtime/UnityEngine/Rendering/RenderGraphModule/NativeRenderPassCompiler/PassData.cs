using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	internal struct PassData
	{
		public int passId;

		public RenderGraphPassType type;

		public bool hasFoveatedRasterization;

		public ExtendedFeatureFlags extendedFeatureFlags;

		public int tag;

		public ShadingRateFragmentSize shadingRateFragmentSize;

		public ShadingRateCombiner primitiveShadingRateCombiner;

		public ShadingRateCombiner fragmentShadingRateCombiner;

		public PassMergeState mergeState;

		public int nativePassIndex;

		public int nativeSubPassIndex;

		public int firstInput;

		public int numInputs;

		public int firstOutput;

		public int numOutputs;

		public int firstFragment;

		public int numFragments;

		public int firstFragmentInput;

		public int numFragmentInputs;

		public int firstSampledOnlyRaster;

		public int numSampledOnlyRaster;

		public int firstRandomAccessResource;

		public int numRandomAccessResources;

		public int firstCreate;

		public int numCreated;

		public int firstDestroy;

		public int numDestroyed;

		public int shadingRateImageIndex;

		public int fragmentInfoWidth;

		public int fragmentInfoHeight;

		public int fragmentInfoVolumeDepth;

		public int fragmentInfoSamples;

		public int waitOnGraphicsFencePassId;

		public int awaitingMyGraphicsFencePassId;

		public bool asyncCompute;

		public bool hasSideEffects;

		public bool culled;

		public bool beginNativeSubpass;

		public bool fragmentInfoValid;

		public bool fragmentInfoHasDepth;

		public bool insertGraphicsFence;

		public bool hasShadingRateStates;

		public bool fragmentInfoHasShadingRateImage => false;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Name GetName(CompilerContextData ctx)
		{
			return default(Name);
		}

		public PassData(in RenderGraphPass pass, int passIndex)
		{
			passId = 0;
			type = default(RenderGraphPassType);
			hasFoveatedRasterization = false;
			extendedFeatureFlags = default(ExtendedFeatureFlags);
			tag = 0;
			shadingRateFragmentSize = default(ShadingRateFragmentSize);
			primitiveShadingRateCombiner = default(ShadingRateCombiner);
			fragmentShadingRateCombiner = default(ShadingRateCombiner);
			mergeState = default(PassMergeState);
			nativePassIndex = 0;
			nativeSubPassIndex = 0;
			firstInput = 0;
			numInputs = 0;
			firstOutput = 0;
			numOutputs = 0;
			firstFragment = 0;
			numFragments = 0;
			firstFragmentInput = 0;
			numFragmentInputs = 0;
			firstSampledOnlyRaster = 0;
			numSampledOnlyRaster = 0;
			firstRandomAccessResource = 0;
			numRandomAccessResources = 0;
			firstCreate = 0;
			numCreated = 0;
			firstDestroy = 0;
			numDestroyed = 0;
			shadingRateImageIndex = 0;
			fragmentInfoWidth = 0;
			fragmentInfoHeight = 0;
			fragmentInfoVolumeDepth = 0;
			fragmentInfoSamples = 0;
			waitOnGraphicsFencePassId = 0;
			awaitingMyGraphicsFencePassId = 0;
			asyncCompute = false;
			hasSideEffects = false;
			culled = false;
			beginNativeSubpass = false;
			fragmentInfoValid = false;
			fragmentInfoHasDepth = false;
			insertGraphicsFence = false;
			hasShadingRateStates = false;
		}

		public void ResetAndInitialize(in RenderGraphPass pass, int passIndex)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly ReadOnlySpan<PassOutputData> Outputs(CompilerContextData ctx)
		{
			return default(ReadOnlySpan<PassOutputData>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly ReadOnlySpan<PassInputData> Inputs(CompilerContextData ctx)
		{
			return default(ReadOnlySpan<PassInputData>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly ReadOnlySpan<PassFragmentData> Fragments(CompilerContextData ctx)
		{
			return default(ReadOnlySpan<PassFragmentData>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly ReadOnlySpan<ResourceHandle> SampledTexturesIfRaster(CompilerContextData ctx)
		{
			return default(ReadOnlySpan<ResourceHandle>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly PassFragmentData ShadingRateImage(CompilerContextData ctx)
		{
			return default(PassFragmentData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly ReadOnlySpan<PassFragmentData> FragmentInputs(CompilerContextData ctx)
		{
			return default(ReadOnlySpan<PassFragmentData>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly ReadOnlySpan<ResourceHandle> FirstUsedResources(CompilerContextData ctx)
		{
			return default(ReadOnlySpan<ResourceHandle>);
		}

		public ReadOnlySpan<PassRandomWriteData> RandomWriteTextures(CompilerContextData ctx)
		{
			return default(ReadOnlySpan<PassRandomWriteData>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly ReadOnlySpan<ResourceHandle> LastUsedResources(CompilerContextData ctx)
		{
			return default(ReadOnlySpan<ResourceHandle>);
		}

		private bool TrySetupAndValidateFragmentInfo(in ResourceHandle h, CompilerContextData ctx, out string errorMessage)
		{
			errorMessage = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TryAddFragment(in ResourceHandle h, CompilerContextData ctx, out string errorMessage)
		{
			errorMessage = null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TryAddFragmentInput(in ResourceHandle h, CompilerContextData ctx, out string errorMessage)
		{
			errorMessage = null;
		}

		internal void AddRandomAccessResource()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void AddFirstUse(in ResourceHandle h, CompilerContextData ctx)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void AddLastUse(in ResourceHandle h, CompilerContextData ctx)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal readonly bool IsUsedAsFragment(in ResourceHandle h, CompilerContextData ctx)
		{
			return false;
		}

		internal void DisconnectFromResources(CompilerContextData ctx, Stack<ResourceHandle> unusedVersionedResourceIdCullingStack = null, int type = 0)
		{
		}
	}
}
