using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	[MovedFrom("UnityEngine.Experimental.Rendering")]
	public sealed class RayTracingAccelerationStructure : IDisposable
	{
		[Flags]
		public enum RayTracingModeMask
		{
			Nothing = 0,
			Static = 2,
			DynamicTransform = 4,
			DynamicGeometry = 8,
			DynamicGeometryManualUpdate = 0x10,
			Everything = 0x1E
		}

		public enum ManagementMode
		{
			Manual = 0,
			Automatic = 1
		}

		public struct BuildSettings
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private RayTracingAccelerationStructureBuildFlags _003CbuildFlags_003Ek__BackingField;

			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Vector3 _003CrelativeOrigin_003Ek__BackingField;

			public RayTracingAccelerationStructureBuildFlags buildFlags
			{
				[CompilerGenerated]
				set
				{
					_003CbuildFlags_003Ek__BackingField = value;
				}
			}

			public Vector3 relativeOrigin
			{
				[CompilerGenerated]
				set
				{
					_003CrelativeOrigin_003Ek__BackingField = value;
				}
			}

			public BuildSettings()
			{
				_003CbuildFlags_003Ek__BackingField = default(RayTracingAccelerationStructureBuildFlags);
				_003CrelativeOrigin_003Ek__BackingField = default(Vector3);
			}
		}

		public struct Settings
		{
			public ManagementMode managementMode;

			public RayTracingModeMask rayTracingModeMask;

			public int layerMask;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private RayTracingAccelerationStructureBuildFlags _003CbuildFlagsStaticGeometries_003Ek__BackingField;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private RayTracingAccelerationStructureBuildFlags _003CbuildFlagsDynamicGeometries_003Ek__BackingField;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private bool _003CenableCompaction_003Ek__BackingField;

			public RayTracingAccelerationStructureBuildFlags buildFlagsStaticGeometries
			{
				[CompilerGenerated]
				set
				{
					_003CbuildFlagsStaticGeometries_003Ek__BackingField = value;
				}
			}

			public RayTracingAccelerationStructureBuildFlags buildFlagsDynamicGeometries
			{
				[CompilerGenerated]
				set
				{
					_003CbuildFlagsDynamicGeometries_003Ek__BackingField = value;
				}
			}

			public bool enableCompaction
			{
				[CompilerGenerated]
				set
				{
					_003CenableCompaction_003Ek__BackingField = value;
				}
			}

			public Settings()
			{
				managementMode = default(ManagementMode);
				rayTracingModeMask = default(RayTracingModeMask);
				layerMask = 0;
				_003CbuildFlagsStaticGeometries_003Ek__BackingField = default(RayTracingAccelerationStructureBuildFlags);
				_003CbuildFlagsDynamicGeometries_003Ek__BackingField = default(RayTracingAccelerationStructureBuildFlags);
				_003CenableCompaction_003Ek__BackingField = false;
			}
		}

		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(RayTracingAccelerationStructure rayTracingAccelerationStructure)
			{
				return (IntPtr)0;
			}
		}

		internal IntPtr m_Ptr;

		~RayTracingAccelerationStructure()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		public RayTracingAccelerationStructure(Settings settings)
		{
		}

		public int AddInstance(in RayTracingMeshInstanceConfig config, Matrix4x4 matrix, [DefaultValue("null")] Matrix4x4? prevMatrix = null, uint id = 4294967295u)
		{
			return 0;
		}

		public void RemoveInstance(int handle)
		{
		}

		public void UpdateInstanceTransform(int handle, Matrix4x4 matrix)
		{
		}

		public void UpdateInstanceID(int handle, uint instanceID)
		{
		}

		public void UpdateInstanceMask(int handle, uint mask)
		{
		}

		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::ClearInstances", HasExplicitThis = true)]
		public void ClearInstances()
		{
		}

		[FreeFunction("RayTracingAccelerationStructure_Bindings::Create")]
		private static IntPtr Create(Settings desc)
		{
			return (IntPtr)0;
		}

		[FreeFunction("RayTracingAccelerationStructure_Bindings::Destroy")]
		private static void Destroy(RayTracingAccelerationStructure accelStruct)
		{
		}

		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::RemoveInstance", HasExplicitThis = true)]
		private void RemoveInstance_InstanceID(int instanceID)
		{
		}

		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceTransform", HasExplicitThis = true)]
		private void UpdateInstanceTransform_Handle(int handle, Matrix4x4 matrix)
		{
		}

		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceMask", HasExplicitThis = true)]
		private void UpdateInstanceMask_Handle(int handle, uint mask)
		{
		}

		[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceID", HasExplicitThis = true)]
		private void UpdateInstanceID_Handle(int handle, uint id)
		{
		}

		[FreeFunction("RayTracingAccelerationStructure_Bindings::AddMeshInstance", HasExplicitThis = true)]
		private unsafe int AddMeshInstance(RayTracingMeshInstanceConfig config, Matrix4x4 matrix, Matrix4x4* prevMatrix, uint id = 4294967295u)
		{
			return 0;
		}

		private static void ClearInstances_Injected(IntPtr _unity_self)
		{
		}

		private static IntPtr Create_Injected([In] ref Settings desc)
		{
			return (IntPtr)0;
		}

		private static void Destroy_Injected(IntPtr accelStruct)
		{
		}

		private static void RemoveInstance_InstanceID_Injected(IntPtr _unity_self, int instanceID)
		{
		}

		private static void UpdateInstanceTransform_Handle_Injected(IntPtr _unity_self, int handle, [In] ref Matrix4x4 matrix)
		{
		}

		private static void UpdateInstanceMask_Handle_Injected(IntPtr _unity_self, int handle, uint mask)
		{
		}

		private static void UpdateInstanceID_Handle_Injected(IntPtr _unity_self, int handle, uint id)
		{
		}

		private unsafe static int AddMeshInstance_Injected(IntPtr _unity_self, [In] ref RayTracingMeshInstanceConfig config, [In] ref Matrix4x4 matrix, Matrix4x4* prevMatrix, uint id)
		{
			return 0;
		}
	}
}
