using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
	public static class Random
	{
		[Serializable]
		public struct State
		{
			[SerializeField]
			private int s0;

			[SerializeField]
			private int s1;

			[SerializeField]
			private int s2;

			[SerializeField]
			private int s3;
		}

		[StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
		public static State state
		{
			get
			{
				return default(State);
			}
			set
			{
			}
		}

		public static float value
		{
			[FreeFunction]
			get
			{
				return 0f;
			}
		}

		public static Vector3 insideUnitSphere
		{
			[FreeFunction]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector2 insideUnitCircle => default(Vector2);

		public static Vector3 onUnitSphere
		{
			[FreeFunction]
			get
			{
				return default(Vector3);
			}
		}

		public static Quaternion rotation
		{
			[FreeFunction]
			get
			{
				return default(Quaternion);
			}
		}

		[NativeMethod("SetSeed")]
		[StaticAccessor("GetScriptingRand()", StaticAccessorType.Dot)]
		public static void InitState(int seed)
		{
		}

		[FreeFunction]
		public static float Range(float minInclusive, float maxInclusive)
		{
			return 0f;
		}

		public static int Range(int minInclusive, int maxExclusive)
		{
			return 0;
		}

		[FreeFunction]
		private static int RandomRangeInt(int minInclusive, int maxExclusive)
		{
			return 0;
		}

		[FreeFunction]
		private static void GetRandomUnitCircle(out Vector2 output)
		{
			output = default(Vector2);
		}

		private static void get_state_Injected(out State ret)
		{
			ret = default(State);
		}

		private static void set_state_Injected([In] ref State value)
		{
		}

		private static void get_insideUnitSphere_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void get_onUnitSphere_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void get_rotation_Injected(out Quaternion ret)
		{
			ret = default(Quaternion);
		}
	}
}
