using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine
{
	public struct RenderParams
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _003Clayer_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private uint _003CrenderingLayerMask_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int _003CrendererPriority_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EntityId _003CentityId_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Bounds _003CworldBounds_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Camera _003Ccamera_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private MotionVectorGenerationMode _003CmotionVectorMode_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ReflectionProbeUsage _003CreflectionProbeUsage_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Material _003Cmaterial_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ShadowCastingMode _003CshadowCastingMode_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CreceiveShadows_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private LightProbeUsage _003ClightProbeUsage_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private LightProbeProxyVolume _003ClightProbeProxyVolume_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CoverrideSceneCullingMask_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ulong _003CsceneCullingMask_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int _003CforceMeshLod_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private float _003CmeshLodSelectionBias_003Ek__BackingField;

		public int layer
		{
			[CompilerGenerated]
			set
			{
				_003Clayer_003Ek__BackingField = value;
			}
		}

		public uint renderingLayerMask
		{
			[CompilerGenerated]
			set
			{
				_003CrenderingLayerMask_003Ek__BackingField = value;
			}
		}

		public int rendererPriority
		{
			[CompilerGenerated]
			set
			{
				_003CrendererPriority_003Ek__BackingField = value;
			}
		}

		public EntityId entityId
		{
			[CompilerGenerated]
			set
			{
				_003CentityId_003Ek__BackingField = value;
			}
		}

		public Bounds worldBounds
		{
			[CompilerGenerated]
			set
			{
				_003CworldBounds_003Ek__BackingField = value;
			}
		}

		public Camera camera
		{
			[CompilerGenerated]
			set
			{
				_003Ccamera_003Ek__BackingField = value;
			}
		}

		public MotionVectorGenerationMode motionVectorMode
		{
			[CompilerGenerated]
			set
			{
				_003CmotionVectorMode_003Ek__BackingField = value;
			}
		}

		public ReflectionProbeUsage reflectionProbeUsage
		{
			[CompilerGenerated]
			set
			{
				_003CreflectionProbeUsage_003Ek__BackingField = value;
			}
		}

		public Material material
		{
			[CompilerGenerated]
			set
			{
				_003Cmaterial_003Ek__BackingField = value;
			}
		}

		public MaterialPropertyBlock matProps { get; set; }

		public ShadowCastingMode shadowCastingMode
		{
			[CompilerGenerated]
			set
			{
				_003CshadowCastingMode_003Ek__BackingField = value;
			}
		}

		public bool receiveShadows
		{
			[CompilerGenerated]
			set
			{
				_003CreceiveShadows_003Ek__BackingField = value;
			}
		}

		public LightProbeUsage lightProbeUsage
		{
			[CompilerGenerated]
			set
			{
				_003ClightProbeUsage_003Ek__BackingField = value;
			}
		}

		public LightProbeProxyVolume lightProbeProxyVolume
		{
			[CompilerGenerated]
			set
			{
				_003ClightProbeProxyVolume_003Ek__BackingField = value;
			}
		}

		public bool overrideSceneCullingMask
		{
			[CompilerGenerated]
			set
			{
				_003CoverrideSceneCullingMask_003Ek__BackingField = value;
			}
		}

		public ulong sceneCullingMask
		{
			[CompilerGenerated]
			set
			{
				_003CsceneCullingMask_003Ek__BackingField = value;
			}
		}

		public int forceMeshLod
		{
			[CompilerGenerated]
			set
			{
				_003CforceMeshLod_003Ek__BackingField = value;
			}
		}

		public float meshLodSelectionBias
		{
			[CompilerGenerated]
			set
			{
				_003CmeshLodSelectionBias_003Ek__BackingField = value;
			}
		}

		public RenderParams(Material mat)
		{
			_003Clayer_003Ek__BackingField = 0;
			_003CrenderingLayerMask_003Ek__BackingField = 0u;
			_003CrendererPriority_003Ek__BackingField = 0;
			_003CentityId_003Ek__BackingField = default(EntityId);
			_003CworldBounds_003Ek__BackingField = default(Bounds);
			_003Ccamera_003Ek__BackingField = null;
			_003CmotionVectorMode_003Ek__BackingField = default(MotionVectorGenerationMode);
			_003CreflectionProbeUsage_003Ek__BackingField = default(ReflectionProbeUsage);
			_003Cmaterial_003Ek__BackingField = null;
			matProps = null;
			_003CshadowCastingMode_003Ek__BackingField = default(ShadowCastingMode);
			_003CreceiveShadows_003Ek__BackingField = false;
			_003ClightProbeUsage_003Ek__BackingField = default(LightProbeUsage);
			_003ClightProbeProxyVolume_003Ek__BackingField = null;
			_003CoverrideSceneCullingMask_003Ek__BackingField = false;
			_003CsceneCullingMask_003Ek__BackingField = 0uL;
			_003CforceMeshLod_003Ek__BackingField = 0;
			_003CmeshLodSelectionBias_003Ek__BackingField = 0f;
		}
	}
}
