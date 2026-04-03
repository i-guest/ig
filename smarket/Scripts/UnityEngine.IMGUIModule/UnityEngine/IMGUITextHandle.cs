using System.Collections.Generic;
using UnityEngine.TextCore.Text;

namespace UnityEngine
{
	internal class IMGUITextHandle : TextHandle
	{
		internal class TextHandleTuple
		{
			public float lastTimeUsed;

			public int hashCode;

			public TextHandleTuple(float lastTimeUsed, int hashCode)
			{
			}
		}

		internal LinkedListNode<TextHandleTuple> tuple;

		private static Dictionary<int, IMGUITextHandle> textHandles;

		private static LinkedList<TextHandleTuple> textHandlesTuple;

		private static float lastCleanupTime;

		private static int newHandlesSinceCleanup;

		internal bool isCachedOnNative;

		internal static void EmptyManagedCache()
		{
		}

		internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor)
		{
			return null;
		}

		internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor, ref bool isCached)
		{
			return null;
		}

		private static bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold)
		{
			return false;
		}

		private static void ClearUnusedTextHandles()
		{
		}

		private static IMGUITextHandle GetTextHandle(UnityEngine.TextCore.Text.TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached)
		{
			return null;
		}

		protected override float GetPixelsPerPoint()
		{
			return 0f;
		}

		internal static float GetLineHeight(GUIStyle style)
		{
			return 0f;
		}

		private static void ConvertGUIStyleToGenerationSettings(UnityEngine.TextCore.Text.TextGenerationSettings settings, GUIStyle style, Color textColor, string text, Rect rect)
		{
		}

		private static TextOverflowMode LegacyClippingToNewOverflow(TextClipping clipping)
		{
			return default(TextOverflowMode);
		}

		internal override bool IsAdvancedTextEnabledForElement()
		{
			return false;
		}
	}
}
