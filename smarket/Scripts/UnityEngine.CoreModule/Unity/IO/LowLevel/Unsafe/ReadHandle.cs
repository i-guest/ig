using System;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
	public struct ReadHandle : IDisposable
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr ptr;

		internal int version;

		public JobHandle JobHandle => default(JobHandle);

		public ReadStatus Status => default(ReadStatus);

		public bool IsValid()
		{
			return false;
		}

		public void Dispose()
		{
		}

		public void Cancel()
		{
		}

		[FreeFunction("AsyncReadManagerManaged::CancelReadRequest")]
		private static void CancelInternal(ReadHandle handle)
		{
		}

		[ThreadAndSerializationSafe]
		[FreeFunction("AsyncReadManagerManaged::GetReadStatus", IsThreadSafe = true)]
		private static ReadStatus GetReadStatus(ReadHandle handle)
		{
			return default(ReadStatus);
		}

		[FreeFunction("AsyncReadManagerManaged::ReleaseReadHandle", IsThreadSafe = true)]
		[ThreadAndSerializationSafe]
		private static void ReleaseReadHandle(ReadHandle handle)
		{
		}

		[ThreadAndSerializationSafe]
		[FreeFunction("AsyncReadManagerManaged::IsReadHandleValid", IsThreadSafe = true)]
		private static bool IsReadHandleValid(ReadHandle handle)
		{
			return false;
		}

		[ThreadAndSerializationSafe]
		[FreeFunction("AsyncReadManagerManaged::GetJobHandle", IsThreadSafe = true)]
		private static JobHandle GetJobHandle(ReadHandle handle)
		{
			return default(JobHandle);
		}

		private static void CancelInternal_Injected([In] ref ReadHandle handle)
		{
		}

		private static ReadStatus GetReadStatus_Injected([In] ref ReadHandle handle)
		{
			return default(ReadStatus);
		}

		private static void ReleaseReadHandle_Injected([In] ref ReadHandle handle)
		{
		}

		private static bool IsReadHandleValid_Injected([In] ref ReadHandle handle)
		{
			return false;
		}

		private static void GetJobHandle_Injected([In] ref ReadHandle handle, out JobHandle ret)
		{
			ret = default(JobHandle);
		}
	}
}
