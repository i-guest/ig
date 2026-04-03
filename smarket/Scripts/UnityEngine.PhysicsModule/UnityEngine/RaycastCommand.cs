using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
	[NativeHeader("Modules/Physics/BatchCommands/RaycastCommand.h")]
	public struct RaycastCommand
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _003Cfrom_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _003Cdirection_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private PhysicsScene _003CphysicsScene_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _003Cdistance_003Ek__BackingField;

		public QueryParameters queryParameters;

		public Vector3 from
		{
			[CompilerGenerated]
			set
			{
				_003Cfrom_003Ek__BackingField = value;
			}
		}

		public Vector3 direction
		{
			[CompilerGenerated]
			set
			{
				_003Cdirection_003Ek__BackingField = value;
			}
		}

		public PhysicsScene physicsScene
		{
			[CompilerGenerated]
			set
			{
				_003CphysicsScene_003Ek__BackingField = value;
			}
		}

		public float distance
		{
			[CompilerGenerated]
			set
			{
				_003Cdistance_003Ek__BackingField = value;
			}
		}

		public RaycastCommand(Vector3 from, Vector3 direction, QueryParameters queryParameters, float distance = 3.4028235E+38f)
		{
			this._003Cfrom_003Ek__BackingField = default(Vector3);
			this._003Cdirection_003Ek__BackingField = default(Vector3);
			_003CphysicsScene_003Ek__BackingField = default(PhysicsScene);
			this._003Cdistance_003Ek__BackingField = 0f;
			this.queryParameters = default(QueryParameters);
		}

		public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, int maxHits, JobHandle dependsOn = default(JobHandle))
		{
			return default(JobHandle);
		}

		public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = default(JobHandle))
		{
			return default(JobHandle);
		}

		[FreeFunction("ScheduleRaycastCommandBatch", ThrowsException = true)]
		private unsafe static JobHandle ScheduleRaycastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits)
		{
			return default(JobHandle);
		}

		private unsafe static void ScheduleRaycastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, int maxHits, out JobHandle ret)
		{
			ret = default(JobHandle);
		}
	}
}
