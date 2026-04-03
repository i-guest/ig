using System;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
	public readonly struct FileHandle
	{
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr fileCommandPtr;

		internal readonly int version;

		public JobHandle JobHandle => default(JobHandle);

		public bool IsValid()
		{
			return false;
		}

		public JobHandle Close(JobHandle dependency = default(JobHandle))
		{
			return default(JobHandle);
		}

		[FreeFunction("AsyncReadManagerManaged::IsFileHandleValid")]
		private static bool IsFileHandleValid(in FileHandle handle)
		{
			return false;
		}

		[FreeFunction("AsyncReadManagerManaged::GetJobFenceFromManagedHandle")]
		private static JobHandle GetJobHandle_Internal(in FileHandle handle)
		{
			return default(JobHandle);
		}

		private static void GetJobHandle_Internal_Injected(in FileHandle handle, out JobHandle ret)
		{
			ret = default(JobHandle);
		}
	}
}
