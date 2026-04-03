namespace UnityEngine.UIElements
{
	public interface ITextSelection
	{
		bool isSelectable { get; set; }

		int cursorIndex { get; set; }

		bool doubleClickSelectsWord { get; set; }

		int selectIndex { get; set; }

		bool tripleClickSelectsLine { get; set; }

		bool selectAllOnFocus { get; set; }

		bool selectAllOnMouseUp { get; set; }

		Vector2 cursorPosition { get; }

		internal float lineHeightAtCursorPosition { get; }

		internal float cursorWidth { get; }

		bool HasSelection();

		void SelectAll();

		void SelectNone();
	}
}
