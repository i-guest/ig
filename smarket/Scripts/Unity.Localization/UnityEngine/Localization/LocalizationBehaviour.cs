using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.Localization
{
	internal class LocalizationBehaviour : ComponentSingleton<LocalizationBehaviour>
	{
		private Queue<(int frame, AsyncOperationHandle handle)> m_ReleaseQueue;

		private const long k_MaxMsPerUpdate = 10L;

		private const bool k_DisableThrottling = false;

		protected override string GetGameObjectName()
		{
			return null;
		}

		public static void ReleaseNextFrame(AsyncOperationHandle handle)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static long TimeSinceStartupMs()
		{
			return 0L;
		}

		private void DoReleaseNextFrame(AsyncOperationHandle handle)
		{
		}

		private void LateUpdate()
		{
		}

		public static void ForceRelease()
		{
		}
	}
}
