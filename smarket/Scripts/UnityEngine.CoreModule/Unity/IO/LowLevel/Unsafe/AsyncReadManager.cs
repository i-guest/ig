using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
	[NativeHeader("Runtime/File/AsyncReadManagerManagedApi.h")]
	public static class AsyncReadManager
	{
		[ThreadAndSerializationSafe]
		[FreeFunction("AsyncReadManagerManaged::GetFileInfo", IsThreadSafe = true)]
		private unsafe static ReadHandle GetFileInfoInternal(string filename, void* cmd)
		{
			return default(ReadHandle);
		}

		public unsafe static ReadHandle GetFileInfo(string filename, FileInfoResult* result)
		{
			return default(ReadHandle);
		}

		[ThreadAndSerializationSafe]
		[FreeFunction("AsyncReadManagerManaged::ReadWithHandles_NativeCopy", IsThreadSafe = true)]
		private unsafe static ReadHandle ReadWithHandlesInternal_NativeCopy(in FileHandle fileHandle, void* readCmdArray)
		{
			return default(ReadHandle);
		}

		public static ReadHandle Read(in FileHandle fileHandle, ReadCommandArray readCmdArray)
		{
			return default(ReadHandle);
		}

		[FreeFunction("AsyncReadManagerManaged::ScheduleOpenRequest", IsThreadSafe = true)]
		[ThreadAndSerializationSafe]
		private static FileHandle OpenFileAsync_Internal(string fileName)
		{
			return default(FileHandle);
		}

		public static FileHandle OpenFileAsync(string fileName)
		{
			return default(FileHandle);
		}

		[FreeFunction("AsyncReadManagerManaged::ScheduleCloseRequest", IsThreadSafe = true)]
		[ThreadAndSerializationSafe]
		internal static JobHandle CloseFileAsync(in FileHandle fileHandle, JobHandle dependency)
		{
			return default(JobHandle);
		}

		private unsafe static void GetFileInfoInternal_Injected(ref ManagedSpanWrapper filename, void* cmd, out ReadHandle ret)
		{
			ret = default(ReadHandle);
		}

		private unsafe static void ReadWithHandlesInternal_NativeCopy_Injected(in FileHandle fileHandle, void* readCmdArray, out ReadHandle ret)
		{
			ret = default(ReadHandle);
		}

		private static void OpenFileAsync_Internal_Injected(ref ManagedSpanWrapper fileName, out FileHandle ret)
		{
			ret = default(FileHandle);
		}

		private static void CloseFileAsync_Injected(in FileHandle fileHandle, [In] ref JobHandle dependency, out JobHandle ret)
		{
			ret = default(JobHandle);
		}
	}
}
