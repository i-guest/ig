using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	public class SupportedRenderingFeatures
	{
		[Flags]
		public enum ReflectionProbeModes
		{
			None = 0,
			Rotation = 1
		}

		[Flags]
		public enum LightmapMixedBakeModes
		{
			None = 0,
			IndirectOnly = 1,
			Subtractive = 2,
			Shadowmask = 4
		}

		private static SupportedRenderingFeatures s_Active;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CenlightenLightmapper_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CskyOcclusion_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003ClightProbeProxyVolumes_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CmotionVectors_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CreceiveShadows_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CreflectionProbes_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CreflectionProbesBlendDistance_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CrendererPriority_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CoverridesEnvironmentLighting_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CoverridesFog_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CoverridesRealtimeReflectionProbes_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CoverridesOtherLightingSettings_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CeditableMaterialRenderQueue_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CoverridesLODBias_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CoverridesMaximumLODLevel_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CoverridesEnableLODCrossFade_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CrendererProbes_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CparticleSystemInstancing_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CoverridesShadowmask_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CsupportsHDR_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CsupportsClouds_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _003CoverridesLightProbeSystemWarningMessage_003Ek__BackingField;

		public static SupportedRenderingFeatures active
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ReflectionProbeModes reflectionProbeModes { get; }

		public LightmapMixedBakeModes defaultMixedLightingModes { get; }

		public LightmapMixedBakeModes mixedLightingModes { get; }

		public LightmapBakeType lightmapBakeTypes { get; }

		public LightmapsMode lightmapsModes { get; }

		public bool enlighten { get; }

		public bool skyOcclusion
		{
			[CompilerGenerated]
			set
			{
				_003CskyOcclusion_003Ek__BackingField = value;
			}
		}

		public bool rendersUIOverlay { get; set; }

		public bool ambientProbeBaking { get; }

		public bool defaultReflectionProbeBaking { get; }

		public bool overridesLightProbeSystem { get; set; }

		public bool supportsHDR
		{
			[CompilerGenerated]
			set
			{
				_003CsupportsHDR_003Ek__BackingField = value;
			}
		}

		[RequiredByNativeCode]
		internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr)
		{
		}

		internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr)
		{
		}

		internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType)
		{
			return false;
		}

		[RequiredByNativeCode]
		internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsAmbientProbeBakingSupported(IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void OverridesLightProbeSystem(IntPtr overridesPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr)
		{
		}

		[RequiredByNativeCode]
		internal static void IsRotatingReflectionProbesSupported(IntPtr isSupportedPtr)
		{
		}
	}
}
