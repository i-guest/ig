using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "Unity.UIElements.PlayModeTests" })]
	[NativeHeader("Modules/TextCoreTextEngine/Native/TextSelectionService.h")]
	internal class TextSelectionService
	{
		[NativeMethod(Name = "TextSelectionService::Substring")]
		internal static string Substring(IntPtr textGenerationInfo, int startIndex, int endIndex)
		{
			return null;
		}

		[NativeMethod(Name = "TextSelectionService::SelectCurrentWord")]
		internal static void SelectCurrentWord(IntPtr textGenerationInfo, int currentIndex, ref int startIndex, ref int endIndex)
		{
		}

		[NativeMethod(Name = "TextSelectionService::PreviousCodePointIndex")]
		internal static int PreviousCodePointIndex(IntPtr textGenerationInfo, int currentIndex)
		{
			return 0;
		}

		[NativeMethod(Name = "TextSelectionService::NextCodePointIndex")]
		internal static int NextCodePointIndex(IntPtr textGenerationInfo, int currentIndex)
		{
			return 0;
		}

		[NativeMethod(Name = "TextSelectionService::GetCursorLogicalIndexFromPosition")]
		internal static int GetCursorLogicalIndexFromPosition(IntPtr textGenerationInfo, Vector2 position)
		{
			return 0;
		}

		[NativeMethod(Name = "TextSelectionService::GetCursorPositionFromLogicalIndex")]
		internal static Vector2 GetCursorPositionFromLogicalIndex(IntPtr textGenerationInfo, int logicalIndex)
		{
			return default(Vector2);
		}

		[NativeMethod(Name = "TextSelectionService::LineUpCharacterPosition")]
		internal static int LineUpCharacterPosition(IntPtr textGenerationInfo, int originalPos)
		{
			return 0;
		}

		[NativeMethod(Name = "TextSelectionService::LineDownCharacterPosition")]
		internal static int LineDownCharacterPosition(IntPtr textGenerationInfo, int originalPos)
		{
			return 0;
		}

		[NativeMethod(Name = "TextSelectionService::GetHighlightRectangles")]
		internal static Rect[] GetHighlightRectangles(IntPtr textGenerationInfo, int cursorIndex, int selectIndex)
		{
			return null;
		}

		[NativeMethod(Name = "TextSelectionService::GetCharacterHeightFromIndex")]
		internal static float GetCharacterHeightFromIndex(IntPtr textGenerationInfo, int index)
		{
			return 0f;
		}

		[NativeMethod(Name = "TextSelectionService::GetStartOfNextWord")]
		internal static int GetStartOfNextWord(IntPtr textGenerationInfo, int currentIndex)
		{
			return 0;
		}

		[NativeMethod(Name = "TextSelectionService::GetEndOfPreviousWord")]
		internal static int GetEndOfPreviousWord(IntPtr textGenerationInfo, int currentIndex)
		{
			return 0;
		}

		[NativeMethod(Name = "TextSelectionService::GetFirstCharacterIndexOnLine")]
		internal static int GetFirstCharacterIndexOnLine(IntPtr textGenerationInfo, int currentIndex)
		{
			return 0;
		}

		[NativeMethod(Name = "TextSelectionService::GetLastCharacterIndexOnLine")]
		internal static int GetLastCharacterIndexOnLine(IntPtr textGenerationInfo, int currentIndex)
		{
			return 0;
		}

		[NativeMethod(Name = "TextSelectionService::GetLineHeight")]
		internal static float GetLineHeight(IntPtr textGenerationInfo, int lineIndex)
		{
			return 0f;
		}

		[NativeMethod(Name = "TextSelectionService::GetLineNumberFromLogicalIndex")]
		internal static int GetLineNumber(IntPtr textGenerationInfo, int logicalIndex)
		{
			return 0;
		}

		[NativeMethod(Name = "TextSelectionService::SelectToPreviousParagraph")]
		internal static void SelectToPreviousParagraph(IntPtr textGenerationInfo, ref int cursorIndex)
		{
		}

		[NativeMethod(Name = "TextSelectionService::SelectToStartOfParagraph")]
		internal static void SelectToStartOfParagraph(IntPtr textGenerationInfo, ref int cursorIndex)
		{
		}

		[NativeMethod(Name = "TextSelectionService::SelectToEndOfParagraph")]
		internal static void SelectToEndOfParagraph(IntPtr textGenerationInfo, ref int cursorIndex)
		{
		}

		[NativeMethod(Name = "TextSelectionService::SelectToNextParagraph")]
		internal static void SelectToNextParagraph(IntPtr textGenerationInfo, ref int cursorIndex)
		{
		}

		[NativeMethod(Name = "TextSelectionService::SelectCurrentParagraph")]
		internal static void SelectCurrentParagraph(IntPtr textGenerationInfo, ref int cursorIndex, ref int selectIndex)
		{
		}

		private static void Substring_Injected(IntPtr textGenerationInfo, int startIndex, int endIndex, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static int GetCursorLogicalIndexFromPosition_Injected(IntPtr textGenerationInfo, [In] ref Vector2 position)
		{
			return 0;
		}

		private static void GetCursorPositionFromLogicalIndex_Injected(IntPtr textGenerationInfo, int logicalIndex, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void GetHighlightRectangles_Injected(IntPtr textGenerationInfo, int cursorIndex, int selectIndex, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}
	}
}
