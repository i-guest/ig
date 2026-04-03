using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	[MovedFrom("UnityEngine.Experimental.Rendering")]
	public struct RayTracingMeshInstanceConfig
	{
		public Mesh mesh;

		public uint subMeshIndex;

		public RayTracingSubMeshFlags subMeshFlags;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private RayTracingMode _003CrayTracingMode_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CdynamicGeometry_003Ek__BackingField;

		public Material material;

		public MaterialPropertyBlock materialProperties;

		public bool enableTriangleCulling;

		public bool frontTriangleCounterClockwise;

		public int layer;

		public uint renderingLayerMask;

		public uint mask;

		public MotionVectorGenerationMode motionVectorMode;

		public LightProbeUsage lightProbeUsage;

		public LightProbeProxyVolume lightProbeProxyVolume;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private RayTracingAccelerationStructureBuildFlags _003CaccelerationStructureBuildFlags_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CaccelerationStructureBuildFlagsOverride_003Ek__BackingField;

		public int meshLod;

		public RayTracingMode rayTracingMode
		{
			[CompilerGenerated]
			set
			{
				_003CrayTracingMode_003Ek__BackingField = value;
			}
		}

		[Obsolete("dynamicGeometry has been deprecated and will be removed in the future. Use rayTracingMode instead.", false)]
		public bool dynamicGeometry
		{
			[CompilerGenerated]
			set
			{
				_003CdynamicGeometry_003Ek__BackingField = value;
			}
		}

		public RayTracingAccelerationStructureBuildFlags accelerationStructureBuildFlags
		{
			[CompilerGenerated]
			set
			{
				_003CaccelerationStructureBuildFlags_003Ek__BackingField = value;
			}
		}

		public bool accelerationStructureBuildFlagsOverride
		{
			[CompilerGenerated]
			set
			{
				_003CaccelerationStructureBuildFlagsOverride_003Ek__BackingField = value;
			}
		}

		public RayTracingMeshInstanceConfig()
		{
			mesh = null;
			subMeshIndex = 0u;
			subMeshFlags = default(RayTracingSubMeshFlags);
			_003CrayTracingMode_003Ek__BackingField = default(RayTracingMode);
			_003CdynamicGeometry_003Ek__BackingField = false;
			material = null;
			materialProperties = null;
			enableTriangleCulling = false;
			frontTriangleCounterClockwise = false;
			layer = 0;
			renderingLayerMask = 0u;
			mask = 0u;
			motionVectorMode = default(MotionVectorGenerationMode);
			lightProbeUsage = default(LightProbeUsage);
			lightProbeProxyVolume = null;
			_003CaccelerationStructureBuildFlags_003Ek__BackingField = default(RayTracingAccelerationStructureBuildFlags);
			_003CaccelerationStructureBuildFlagsOverride_003Ek__BackingField = false;
			meshLod = 0;
		}

		public RayTracingMeshInstanceConfig(Mesh mesh, uint subMeshIndex, Material material)
		{
			this.mesh = null;
			this.subMeshIndex = 0u;
			subMeshFlags = default(RayTracingSubMeshFlags);
			_003CrayTracingMode_003Ek__BackingField = default(RayTracingMode);
			_003CdynamicGeometry_003Ek__BackingField = false;
			this.material = null;
			materialProperties = null;
			enableTriangleCulling = false;
			frontTriangleCounterClockwise = false;
			layer = 0;
			renderingLayerMask = 0u;
			mask = 0u;
			motionVectorMode = default(MotionVectorGenerationMode);
			lightProbeUsage = default(LightProbeUsage);
			lightProbeProxyVolume = null;
			_003CaccelerationStructureBuildFlags_003Ek__BackingField = default(RayTracingAccelerationStructureBuildFlags);
			_003CaccelerationStructureBuildFlagsOverride_003Ek__BackingField = false;
			meshLod = 0;
		}
	}
}
