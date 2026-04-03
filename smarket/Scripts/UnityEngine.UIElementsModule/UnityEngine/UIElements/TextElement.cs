using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Properties;
using UnityEngine.Bindings;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	public class TextElement : BindableElement, INotifyValueChanged<string>, ITextEdition, IExperimentalFeatures, ITextSelection
	{
		public readonly struct GlyphsEnumerable
		{
			public readonly int Count;

			private readonly List<NativeSlice<Vertex>> m_Vertices;

			private readonly TextElement m_TextElement;

			internal GlyphsEnumerable(TextElement te, List<NativeSlice<Vertex>> vertices)
			{
				Count = 0;
				m_Vertices = null;
				m_TextElement = null;
			}

			internal GlyphsEnumerable(TextElement te, List<NativeSlice<Vertex>> vertices, Span<ATGMeshInfo> meshInfos)
			{
				Count = 0;
				m_Vertices = null;
				m_TextElement = null;
			}

			private static int ComputeCount(List<NativeSlice<Vertex>> verts)
			{
				return 0;
			}
		}

		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			private UxmlStringAttributeDescription m_Text;

			private UxmlBoolAttributeDescription m_EnableRichText;

			private UxmlBoolAttributeDescription m_EmojiFallbackSupport;

			private UxmlBoolAttributeDescription m_ParseEscapeSequences;

			private UxmlBoolAttributeDescription m_Selectable;

			private UxmlBoolAttributeDescription m_SelectWordByDoubleClick;

			private UxmlBoolAttributeDescription m_SelectLineByTripleClick;

			private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId displayTooltipWhenElidedProperty;

		internal static readonly BindingId emojiFallbackSupportProperty;

		internal static readonly BindingId enableRichTextProperty;

		internal static readonly BindingId isElidedProperty;

		internal static readonly BindingId parseEscapeSequencesProperty;

		internal static readonly BindingId textProperty;

		internal static readonly BindingId valueProperty;

		public static readonly string ussClassName;

		public static readonly string selectableUssClassName;

		private string m_Text;

		private bool m_EnableRichText;

		private bool m_EmojiFallbackSupport;

		private bool m_ParseEscapeSequences;

		private bool m_DisplayTooltipWhenElided;

		internal static readonly string k_EllipsisText;

		internal string elidedText;

		private bool m_WasElided;

		internal static readonly BindingId autoCorrectionProperty;

		internal static readonly BindingId hideMobileInputProperty;

		internal static readonly BindingId keyboardTypeProperty;

		internal static readonly BindingId isReadOnlyProperty;

		internal static readonly BindingId isPasswordProperty;

		internal static readonly BindingId maxLengthProperty;

		internal static readonly BindingId maskCharProperty;

		internal bool isInputField;

		private bool m_Multiline;

		internal TouchScreenKeyboard m_TouchScreenKeyboard;

		internal Action<bool> onIsReadOnlyChanged;

		internal TouchScreenKeyboardType m_KeyboardType;

		private bool m_HideMobileInput;

		private bool m_IsReadOnly;

		private int m_MaxLength;

		private string m_PlaceholderText;

		private const string ZeroWidthSpace = "\u200b";

		private string m_RenderedText;

		private string m_OriginalText;

		private char m_MaskChar;

		private bool m_IsPassword;

		private bool m_HidePlaceholderTextOnFocus;

		private bool m_AutoCorrection;

		internal static readonly BindingId isSelectableProperty;

		internal static readonly BindingId cursorIndexProperty;

		internal static readonly BindingId selectIndexProperty;

		internal static readonly BindingId doubleClickSelectsWordProperty;

		internal static readonly BindingId tripleClickSelectsLineProperty;

		internal static readonly BindingId cursorPositionProperty;

		internal static readonly BindingId selectAllOnFocusProperty;

		internal static readonly BindingId selectAllOnMouseUpProperty;

		internal static readonly BindingId selectionProperty;

		private TextSelectingManipulator m_SelectingManipulator;

		private bool m_IsSelectable;

		private bool m_DoubleClickSelectsWord;

		private bool m_TripleClickSelectsLine;

		private bool m_SelectAllOnFocus;

		private bool m_SelectAllOnMouseUp;

		private Color m_SelectionColor;

		private Color m_CursorColor;

		private float m_CursorWidth;

		public Action<GlyphsEnumerable> PostProcessTextVertices { get; }

		internal UITKTextHandle uitkTextHandle { get; set; }

		[CreateProperty]
		public virtual string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool enableRichText
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool emojiFallbackSupport
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool parseEscapeSequences
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool displayTooltipWhenElided
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty(ReadOnly = true)]
		public bool isElided { get; private set; }

		internal bool hasFocus => false;

		string INotifyValueChanged<string>.value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		private string value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ITextEdition edition => null;

		internal TextEditingManipulator editingManipulator { get; private set; }

		bool ITextEdition.multiline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		TouchScreenKeyboard ITextEdition.touchScreenKeyboard => null;

		TouchScreenKeyboardType ITextEdition.keyboardType
		{
			get
			{
				return default(TouchScreenKeyboardType);
			}
			set
			{
			}
		}

		[CreateProperty]
		private TouchScreenKeyboardType keyboardType
		{
			get
			{
				return default(TouchScreenKeyboardType);
			}
			set
			{
			}
		}

		bool ITextEdition.hideMobileInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		private bool hideMobileInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool ITextEdition.isReadOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		private bool isReadOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		int ITextEdition.maxLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreateProperty]
		private int maxLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		string ITextEdition.placeholder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		bool ITextEdition.isDelayed
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		Func<char, bool> ITextEdition.AcceptCharacter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		Action<bool> ITextEdition.UpdateScrollOffset
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		Action ITextEdition.UpdateValueFromText
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		Action ITextEdition.UpdateTextFromValue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		Action ITextEdition.MoveFocusToCompositeRoot
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal Action OnPlaceholderChanged { get; set; }

		Func<string> ITextEdition.GetDefaultValueType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		char ITextEdition.maskChar
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		[CreateProperty]
		private char maskChar
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		private char effectiveMaskChar => '\0';

		bool ITextEdition.isPassword
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		private bool isPassword
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool ITextEdition.hidePlaceholderOnFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool needsPlaceholderIfTextIsEmpty => false;

		internal bool showPlaceholderText => false;

		bool ITextEdition.autoCorrection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		private bool autoCorrection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal RenderedText renderedText => default(RenderedText);

		internal string renderedTextString => null;

		internal string originalText => null;

		[CreateProperty(ReadOnly = true)]
		public ITextSelection selection => null;

		bool ITextSelection.isSelectable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		internal bool isSelectable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		int ITextSelection.cursorIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreateProperty]
		private int cursorIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		int ITextSelection.selectIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreateProperty]
		private int selectIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		bool ITextSelection.doubleClickSelectsWord
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		internal bool doubleClickSelectsWord
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool ITextSelection.tripleClickSelectsLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		internal bool tripleClickSelectsLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool ITextSelection.selectAllOnFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		private bool selectAllOnFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool ITextSelection.selectAllOnMouseUp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[CreateProperty]
		private bool selectAllOnMouseUp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		Vector2 ITextSelection.cursorPosition => default(Vector2);

		[CreateProperty(ReadOnly = true)]
		private Vector2 cursorPosition => default(Vector2);

		float ITextSelection.lineHeightAtCursorPosition => 0f;

		internal Color selectionColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		internal Color cursorColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		float ITextSelection.cursorWidth => 0f;

		internal TextSelectingManipulator selectingManipulator
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		private string GetDefaultValueType()
		{
			return null;
		}

		[EventInterest(new Type[]
		{
			typeof(ContextualMenuPopulateEvent),
			typeof(KeyDownEvent),
			typeof(KeyUpEvent),
			typeof(ValidateCommandEvent),
			typeof(ExecuteCommandEvent),
			typeof(FocusEvent),
			typeof(BlurEvent),
			typeof(FocusInEvent),
			typeof(FocusOutEvent),
			typeof(PointerDownEvent),
			typeof(PointerUpEvent),
			typeof(PointerMoveEvent),
			typeof(NavigationMoveEvent),
			typeof(NavigationSubmitEvent),
			typeof(NavigationCancelEvent),
			typeof(IMEEvent),
			typeof(GeometryChangedEvent),
			typeof(AttachToPanelEvent),
			typeof(DetachFromPanelEvent)
		})]
		protected override void HandleEventBubbleUp(EventBase evt)
		{
		}

		private void OnAttachToPanel(AttachToPanelEvent attachEvent)
		{
		}

		private void OnDetachFromPanel(DetachFromPanelEvent detachEvent)
		{
		}

		internal static void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
		}

		internal void OnGenerateTextOver(MeshGenerationContext mgc)
		{
		}

		internal void OnGenerateTextOverNative(MeshGenerationContext mgc)
		{
		}

		internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition)
		{
			return null;
		}

		private void UpdateTooltip()
		{
		}

		private void UpdateVisibleText()
		{
		}

		private bool ShouldElide()
		{
			return false;
		}

		public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode)
		{
			return default(Vector2);
		}

		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
		{
			return default(Vector2);
		}

		internal static bool AnySizeAutoOrNone(ComputedStyle computedStyle)
		{
			return false;
		}

		void INotifyValueChanged<string>.SetValueWithoutNotify(string newValue)
		{
		}

		private void ProcessMenuCommand(string command)
		{
		}

		private void Cut(DropdownMenuAction a)
		{
		}

		private void Copy(DropdownMenuAction a)
		{
		}

		private void Paste(DropdownMenuAction a)
		{
		}

		private void BuildContextualMenu(ContextualMenuPopulateEvent evt)
		{
		}

		private DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a)
		{
			return default(DropdownMenuAction.Status);
		}

		private DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a)
		{
			return default(DropdownMenuAction.Status);
		}

		private DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a)
		{
			return default(DropdownMenuAction.Status);
		}

		private void EditionHandleEvent(EventBase evt)
		{
		}

		void ITextEdition.SaveValueAndText()
		{
		}

		void ITextEdition.RestoreValueAndText()
		{
		}

		void ITextEdition.UpdateText(string value)
		{
		}

		string ITextEdition.CullString(string s)
		{
			return null;
		}

		private void SetRenderedText(string value)
		{
		}

		void ITextSelection.SelectAll()
		{
		}

		void ITextSelection.SelectNone()
		{
		}

		bool ITextSelection.HasSelection()
		{
			return false;
		}

		private void DrawHighlighting(MeshGenerationContext mgc)
		{
		}

		private void DrawNativeHighlighting(MeshGenerationContext mgc)
		{
		}

		internal void DrawCaret(MeshGenerationContext mgc)
		{
		}

		private int GetLastCharacterAt(int lineIndex)
		{
			return 0;
		}
	}
}
