using UnityEngine.Bindings;

namespace Unity.Collections.LowLevel.Unsafe
{
	[NativeHeader("Runtime/Export/BurstLike/BurstLike.bindings.h")]
	[StaticAccessor("BurstLike", StaticAccessorType.DoubleColon)]
	[VisibleToOtherModules(new string[] { "UnityEngine.ParticleSystemModule", "UnityEngine.AudioModule" })]
	internal static class BurstLike
	{
		[VisibleToOtherModules(new string[] { "UnityEngine.ParticleSystemModule", "UnityEngine.AudioModule" })]
		internal readonly struct SharedStatic<T> where T : struct
		{
			private unsafe readonly void* _buffer;

			public ref T Data
			{
				get
				{
					throw null;
				}
			}

			private unsafe SharedStatic(void* buffer)
			{
				_buffer = null;
			}

			public static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0u)
			{
				return default(SharedStatic<T>);
			}
		}

		internal static class SharedStatic
		{
			public unsafe static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment)
			{
				return null;
			}
		}
	}
}
