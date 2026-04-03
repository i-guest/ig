using Unity.IntegerTime;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Input/TimeManager.h")]
	[StaticAccessor("GetTimeManager()", StaticAccessorType.Dot)]
	public class Time
	{
		[NativeProperty("CurTime")]
		public static float time => 0f;

		[NativeProperty("CurTime")]
		public static double timeAsDouble => 0.0;

		[NativeProperty("CurTimeRational")]
		public static RationalTime timeAsRational => default(RationalTime);

		[NativeProperty("TimeSinceSceneLoad")]
		public static float timeSinceLevelLoad => 0f;

		public static float deltaTime => 0f;

		public static float fixedTime => 0f;

		public static float unscaledTime => 0f;

		public static float fixedUnscaledTime => 0f;

		public static float unscaledDeltaTime => 0f;

		public static float fixedUnscaledDeltaTime => 0f;

		public static float fixedDeltaTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float maximumDeltaTime => 0f;

		public static float smoothDeltaTime => 0f;

		public static float timeScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static int frameCount => 0;

		[NativeProperty("RenderFrameCount")]
		public static int renderedFrameCount => 0;

		[NativeProperty("Realtime")]
		public static float realtimeSinceStartup => 0f;

		[NativeProperty("Realtime")]
		public static double realtimeSinceStartupAsDouble => 0.0;

		private static void get_timeAsRational_Injected(out RationalTime ret)
		{
			ret = default(RationalTime);
		}
	}
}
