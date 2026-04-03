using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	internal class TextInfo
	{
		private static Vector2 s_InfinityVectorPositive;

		private static Vector2 s_InfinityVectorNegative;

		public int characterCount;

		public int spriteCount;

		public int spaceCount;

		public int wordCount;

		public int linkCount;

		public int lineCount;

		public int materialCount;

		public TextElementInfo[] textElementInfo;

		public WordInfo[] wordInfo;

		public LinkInfo[] linkInfo;

		public LineInfo[] lineInfo;

		public MeshInfo[] meshInfo;

		public bool hasMultipleColors;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal void Clear()
		{
		}

		internal void ClearMeshInfo(bool updateMesh)
		{
		}

		internal void ClearLineInfo()
		{
		}

		internal static void Resize<T>(ref T[] array, int size)
		{
		}

		internal static void Resize<T>(ref T[] array, int size, bool isBlockAllocated)
		{
		}

		public virtual Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, Rect screenRect, float lineHeight, bool inverseYAxis = true)
		{
			return default(Vector2);
		}

		public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, Rect screenRect, float lineHeight, bool useXAdvance = false, bool inverseYAxis = true)
		{
			return default(Vector2);
		}

		public int GetCursorIndexFromPosition(Vector2 position, Rect screenRect, bool inverseYAxis = true)
		{
			return 0;
		}

		public int LineDownCharacterPosition(int originalPos)
		{
			return 0;
		}

		public int LineUpCharacterPosition(int originalPos)
		{
			return 0;
		}

		public int FindNearestLine(Vector2 position)
		{
			return 0;
		}

		public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly)
		{
			return 0;
		}

		public int FindIntersectingLink(Vector3 position, Rect screenRect, bool inverseYAxis = true)
		{
			return 0;
		}

		public int GetCorrespondingStringIndex(int index)
		{
			return 0;
		}

		public LineInfo GetLineInfoFromCharacterIndex(int index)
		{
			return default(LineInfo);
		}

		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return false;
		}

		private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
		{
			return 0f;
		}

		public int GetLineNumber(int index)
		{
			return 0;
		}

		public float GetLineHeight(int lineNumber)
		{
			return 0f;
		}

		public float GetLineHeightFromCharacterIndex(int index)
		{
			return 0f;
		}

		public float GetCharacterHeightFromIndex(int index)
		{
			return 0f;
		}

		public string Substring(int startIndex, int length)
		{
			return null;
		}

		public int IndexOf(char value, int startIndex)
		{
			return 0;
		}

		public int LastIndexOf(char value, int startIndex)
		{
			return 0;
		}
	}
}
