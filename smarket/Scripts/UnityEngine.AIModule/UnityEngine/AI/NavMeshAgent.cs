using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@2.0/manual/NavMeshAgent.html")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
	[MovedFrom("UnityEngine")]
	public sealed class NavMeshAgent : Behaviour
	{
		public Vector3 destination => default(Vector3);

		public float stoppingDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 velocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 desiredVelocity => default(Vector3);

		public float remainingDistance => 0f;

		public bool autoBraking
		{
			set
			{
			}
		}

		public bool pathPending
		{
			[NativeName("PathPending")]
			get
			{
				return false;
			}
		}

		public bool isStopped
		{
			[FreeFunction("NavMeshAgentScriptBindings::SetIsStopped", HasExplicitThis = true)]
			set
			{
			}
		}

		public NavMeshPath path => null;

		public float speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angularSpeed
		{
			set
			{
			}
		}

		public float acceleration
		{
			set
			{
			}
		}

		public bool updatePosition
		{
			set
			{
			}
		}

		public bool updateRotation
		{
			set
			{
			}
		}

		public float height => 0f;

		public ObstacleAvoidanceType obstacleAvoidanceType
		{
			set
			{
			}
		}

		public bool isOnNavMesh
		{
			[NativeName("InCrowdSystem")]
			get
			{
				return false;
			}
		}

		public bool SetDestination(Vector3 target)
		{
			return false;
		}

		public bool Warp(Vector3 newPosition)
		{
			return false;
		}

		public void ResetPath()
		{
		}

		public bool SetPath([NotNull] NavMeshPath path)
		{
			return false;
		}

		[NativeMethod("CopyPath")]
		internal void CopyPathTo([NotNull] NavMeshPath path)
		{
		}

		public bool CalculatePath(Vector3 targetPosition, NavMeshPath path)
		{
			return false;
		}

		[FreeFunction("NavMeshAgentScriptBindings::CalculatePathInternal", HasExplicitThis = true)]
		private bool CalculatePathInternal(Vector3 targetPosition, [NotNull] NavMeshPath path)
		{
			return false;
		}

		private static bool SetDestination_Injected(IntPtr _unity_self, [In] ref Vector3 target)
		{
			return false;
		}

		private static void get_destination_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static float get_stoppingDistance_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_stoppingDistance_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void get_velocity_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_velocity_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static void get_desiredVelocity_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static float get_remainingDistance_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_autoBraking_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_pathPending_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool Warp_Injected(IntPtr _unity_self, [In] ref Vector3 newPosition)
		{
			return false;
		}

		private static void set_isStopped_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void ResetPath_Injected(IntPtr _unity_self)
		{
		}

		private static bool SetPath_Injected(IntPtr _unity_self, IntPtr path)
		{
			return false;
		}

		private static void CopyPathTo_Injected(IntPtr _unity_self, IntPtr path)
		{
		}

		private static bool CalculatePathInternal_Injected(IntPtr _unity_self, [In] ref Vector3 targetPosition, IntPtr path)
		{
			return false;
		}

		private static float get_speed_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_speed_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_angularSpeed_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_acceleration_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void set_updatePosition_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void set_updateRotation_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static float get_height_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_obstacleAvoidanceType_Injected(IntPtr _unity_self, ObstacleAvoidanceType value)
		{
		}

		private static bool get_isOnNavMesh_Injected(IntPtr _unity_self)
		{
			return false;
		}
	}
}
