namespace UnityEngine
{
	public class GUILayout
	{
		private sealed class LayoutedWindow
		{
			private readonly GUI.WindowFunction m_Func;

			private readonly Rect m_ScreenRect;

			private readonly GUILayoutOption[] m_Options;

			private readonly GUIStyle m_Style;

			internal LayoutedWindow(GUI.WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style)
			{
			}

			public void DoWindow(int windowID)
			{
			}
		}

		public static void Label(string text, params GUILayoutOption[] options)
		{
		}

		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
		}

		public static void Box(string text, params GUILayoutOption[] options)
		{
		}

		private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
		}

		public static bool Button(string text, params GUILayoutOption[] options)
		{
			return false;
		}

		private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return false;
		}

		public static bool Toggle(bool value, string text, params GUILayoutOption[] options)
		{
			return false;
		}

		private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return false;
		}

		public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return 0f;
		}

		private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options)
		{
			return 0f;
		}

		public static void BeginHorizontal(params GUILayoutOption[] options)
		{
		}

		public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		public static void EndHorizontal()
		{
		}

		public static void BeginArea(Rect screenRect)
		{
		}

		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
		}

		public static void EndArea()
		{
		}

		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
		{
			return default(Rect);
		}

		private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return default(Rect);
		}

		public static GUILayoutOption Width(float width)
		{
			return null;
		}

		public static GUILayoutOption Height(float height)
		{
			return null;
		}
	}
}
