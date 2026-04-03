using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public static class CameraCaptureBridge
	{
		private class CameraEntry
		{
			internal HashSet<Action<RenderTargetIdentifier, CommandBuffer>> actions;

			internal IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> cachedEnumerator;
		}

		private static Dictionary<Camera, CameraEntry> actionDict;

		private static bool _enabled;

		public static bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera)
		{
			return null;
		}

		internal static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCachedCaptureActionsEnumerator(Camera camera)
		{
			return null;
		}

		public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action)
		{
		}

		public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action)
		{
		}
	}
}
