using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("CacheWrapper", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Misc/Cache.h")]
	public struct Cache : IEquatable<Cache>
	{
		private int m_Handle;

		internal int handle => 0;

		public bool valid => false;

		public string path => null;

		public long maximumAvailableStorageSpace
		{
			set
			{
			}
		}

		public int expirationDelay
		{
			set
			{
			}
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(Cache other)
		{
			return false;
		}

		internal static bool Cache_IsValid(int handle)
		{
			return false;
		}

		[NativeThrows]
		internal static string Cache_GetPath(int handle)
		{
			return null;
		}

		[NativeThrows]
		internal static void Cache_SetMaximumDiskSpaceAvailable(int handle, long value)
		{
		}

		[NativeThrows]
		internal static void Cache_SetExpirationDelay(int handle, int value)
		{
		}

		private static void Cache_GetPath_Injected(int handle, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}
	}
}
