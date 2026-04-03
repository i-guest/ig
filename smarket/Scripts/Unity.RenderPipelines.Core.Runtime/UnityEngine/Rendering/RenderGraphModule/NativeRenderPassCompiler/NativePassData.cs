using System;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	internal struct NativePassData
	{
		public FixedAttachmentArray<LoadAudit> loadAudit;

		public FixedAttachmentArray<StoreAudit> storeAudit;

		public PassBreakAudit breakAudit;

		public FixedAttachmentArray<PassFragmentData> fragments;

		public FixedAttachmentArray<NativePassAttachment> attachments;

		public int firstGraphPass;

		public int lastGraphPass;

		public int numGraphPasses;

		public int firstNativeSubPass;

		public int numNativeSubPasses;

		public int width;

		public int height;

		public int volumeDepth;

		public int samples;

		public int shadingRateImageIndex;

		public bool hasDepth;

		public bool hasFoveatedRasterization;

		public bool hasShadingRateStates;

		public ExtendedFeatureFlags extendedFeatureFlags;

		public ShadingRateFragmentSize shadingRateFragmentSize;

		public ShadingRateCombiner primitiveShadingRateCombiner;

		public ShadingRateCombiner fragmentShadingRateCombiner;

		public bool hasShadingRateImage => false;

		public NativePassData(ref PassData pass, CompilerContextData ctx)
		{
			loadAudit = default(FixedAttachmentArray<LoadAudit>);
			storeAudit = default(FixedAttachmentArray<StoreAudit>);
			breakAudit = default(PassBreakAudit);
			fragments = default(FixedAttachmentArray<PassFragmentData>);
			attachments = default(FixedAttachmentArray<NativePassAttachment>);
			firstGraphPass = 0;
			lastGraphPass = 0;
			numGraphPasses = 0;
			firstNativeSubPass = 0;
			numNativeSubPasses = 0;
			width = 0;
			height = 0;
			volumeDepth = 0;
			samples = 0;
			shadingRateImageIndex = 0;
			hasDepth = false;
			hasFoveatedRasterization = false;
			hasShadingRateStates = false;
			extendedFeatureFlags = default(ExtendedFeatureFlags);
			shadingRateFragmentSize = default(ShadingRateFragmentSize);
			primitiveShadingRateCombiner = default(ShadingRateCombiner);
			fragmentShadingRateCombiner = default(ShadingRateCombiner);
		}

		public SubPassFlags GetSubPassFlagForMerging()
		{
			return default(SubPassFlags);
		}

		public void Clear()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool IsValid()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly ReadOnlySpan<PassData> GraphPasses(CompilerContextData ctx, out NativeArray<PassData> actualPasses)
		{
			actualPasses = default(NativeArray<PassData>);
			return default(ReadOnlySpan<PassData>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly void GetGraphPassNames(CompilerContextData ctx, DynamicArray<Name> dest)
		{
		}

		private static bool CanMergeMSAASamples(ref NativePassData nativePass, ref PassData passToMerge)
		{
			return false;
		}

		private static bool AreExtendedFeatureFlagsCompatible(ExtendedFeatureFlags flags0, ExtendedFeatureFlags flags1)
		{
			return false;
		}

		public static PassBreakAudit CanMerge(CompilerContextData contextData, int activeNativePassId, int passIdToMerge)
		{
			return default(PassBreakAudit);
		}

		private static bool TotalAttachmentsSizeExceedPixelStorageLimit(CompilerContextData contextData, ref NativePassData nativePass, ref FixedAttachmentArray<PassFragmentData> attachmentsToTryAdding)
		{
			return false;
		}

		private static bool CanMergeNativeSubPass(CompilerContextData contextData, ref NativePassData nativePass, ref PassData passToMerge)
		{
			return false;
		}

		public static void TryMergeNativeSubPass(CompilerContextData contextData, ref NativePassData nativePass, ref PassData passToMerge)
		{
		}

		private void AddDepthAttachmentFirstDuringMerge(CompilerContextData contextData, in PassFragmentData depthAttachment)
		{
		}

		public static PassBreakAudit TryMerge(CompilerContextData contextData, int activeNativePassId, int passIdToMerge)
		{
			return default(PassBreakAudit);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPassStatesForNativePass(CompilerContextData contextData, int nativePassId)
		{
		}
	}
}
