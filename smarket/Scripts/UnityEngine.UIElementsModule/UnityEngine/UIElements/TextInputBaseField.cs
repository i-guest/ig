using System;
using System.Runtime.CompilerServices;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public abstract class TextInputBaseField<TValueType> : BaseField<TValueType>, IDelayedField
	{
		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription>
		{
			private UxmlIntAttributeDescription m_MaxLength;

			private UxmlBoolAttributeDescription m_Password;

			private UxmlStringAttributeDescription m_MaskCharacter;

			private UxmlStringAttributeDescription m_PlaceholderText;

			private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus;

			private UxmlBoolAttributeDescription m_IsReadOnly;

			private UxmlBoolAttributeDescription m_IsDelayed;

			private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility;

			private UxmlBoolAttributeDescription m_SelectAllOnMouseUp;

			private UxmlBoolAttributeDescription m_SelectAllOnFocus;

			private UxmlBoolAttributeDescription m_SelectWordByDoubleClick;

			private UxmlBoolAttributeDescription m_SelectLineByTripleClick;

			private UxmlBoolAttributeDescription m_EmojiFallbackSupport;

			private UxmlBoolAttributeDescription m_HideMobileInput;

			private UxmlEnumAttributeDescription<TouchScreenKeyboardType> m_KeyboardType;

			private UxmlBoolAttributeDescription m_AutoCorrection;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		protected internal abstract class TextInputBase : VisualElement
		{
			internal ScrollView scrollView;

			internal VisualElement multilineContainer;

			public static readonly string innerComponentsModifierName;

			public static readonly string innerTextElementUssClassName;

			internal static readonly string innerTextElementWithScrollViewUssClassName;

			public static readonly string horizontalVariantInnerTextElementUssClassName;

			public static readonly string verticalVariantInnerTextElementUssClassName;

			public static readonly string verticalHorizontalVariantInnerTextElementUssClassName;

			public static readonly string innerScrollviewUssClassName;

			public static readonly string innerViewportUssClassName;

			public static readonly string innerContentContainerUssClassName;

			internal Vector2 scrollOffset;

			private bool m_ScrollViewWasClamped;

			private Vector2 lastCursorPos;

			internal ScrollerVisibility verticalScrollerVisibility;

			internal TextElement textElement { get; private set; }

			public ITextSelection textSelection => null;

			public ITextEdition textEdition => null;

			internal bool isDragging
			{
				[CompilerGenerated]
				set
				{
					_003CisDragging_003Ek__BackingField = value;
				}
			}

			public string text
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal string originalText => null;

			internal TextInputBase()
			{
			}

			protected virtual TValueType StringToValue(string str)
			{
				return default(TValueType);
			}

			internal void UpdateValueFromText()
			{
			}

			internal void UpdateTextFromValue()
			{
			}

			internal void MoveFocusToCompositeRoot()
			{
			}

			private void MakeSureScrollViewDoesNotLeakEvents(ChangeEvent<float> evt)
			{
			}

			internal void SetSingleLine()
			{
			}

			internal void SetMultiline()
			{
			}

			private void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e)
			{
			}

			private void TextElementOnGeometryChangedEvent(GeometryChangedEvent e)
			{
			}

			internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e)
			{
			}

			private string GetDefaultValueType()
			{
				return null;
			}

			internal virtual bool AcceptCharacter(char c)
			{
				return false;
			}

			internal void UpdateScrollOffset(bool isBackspace = false)
			{
			}

			internal void UpdateScrollOffset(bool isBackspace, bool widthChanged)
			{
			}

			private Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged)
			{
				return default(Vector2);
			}

			internal void SetScrollViewMode()
			{
			}

			private void SetMultilineContainerStyle()
			{
			}

			private void RemoveSingleLineComponents()
			{
			}

			private void RemoveMultilineComponents()
			{
			}

			internal bool SetVerticalScrollerVisibility(ScrollerVisibility sv)
			{
				return false;
			}
		}

		internal static readonly BindingId autoCorrectionProperty;

		internal static readonly BindingId hideMobileInputProperty;

		internal static readonly BindingId hidePlaceholderOnFocusProperty;

		internal static readonly BindingId keyboardTypeProperty;

		internal static readonly BindingId isReadOnlyProperty;

		internal static readonly BindingId isPasswordFieldProperty;

		internal static readonly BindingId textSelectionProperty;

		internal static readonly BindingId textEditionProperty;

		internal static readonly BindingId placeholderTextProperty;

		internal static readonly BindingId cursorIndexProperty;

		internal static readonly BindingId cursorPositionProperty;

		internal static readonly BindingId selectIndexProperty;

		internal static readonly BindingId selectAllOnFocusProperty;

		internal static readonly BindingId selectAllOnMouseUpProperty;

		internal static readonly BindingId maxLengthProperty;

		internal static readonly BindingId doubleClickSelectsWordProperty;

		internal static readonly BindingId tripleClickSelectsLineProperty;

		internal static readonly BindingId emojiFallbackSupportProperty;

		internal static readonly BindingId isDelayedProperty;

		internal static readonly BindingId maskCharProperty;

		internal static readonly BindingId verticalScrollerVisibilityProperty;

		private static CustomStyleProperty<Color> s_SelectionColorProperty;

		private static CustomStyleProperty<Color> s_CursorColorProperty;

		public new static readonly string ussClassName;

		public new static readonly string labelUssClassName;

		public new static readonly string inputUssClassName;

		internal static readonly string multilineContainerClassName;

		public static readonly string singleLineInputUssClassName;

		public static readonly string multilineInputUssClassName;

		public static readonly string placeholderUssClassName;

		internal static readonly string multilineInputWithScrollViewUssClassName;

		public static readonly string textInputUssName;

		private TextInputBase m_TextInputBase;

		internal bool m_UpdateTextFromValue;

		internal bool password
		{
			set
			{
			}
		}

		internal bool readOnly
		{
			set
			{
			}
		}

		[CreateProperty]
		internal string placeholderText
		{
			get
			{
				return null;
			}
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			set
			{
			}
		}

		[CreateProperty]
		internal bool hidePlaceholderOnFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected internal TextInputBase textInputBase => null;

		[CreateProperty(ReadOnly = true)]
		public ITextSelection textSelection => null;

		[CreateProperty(ReadOnly = true)]
		public ITextEdition textEdition => null;

		protected Action<bool> onIsReadOnlyChanged
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
		public bool isReadOnly
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
		public bool isPasswordField
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
		public bool autoCorrection
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
		public bool hideMobileInput
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
		public TouchScreenKeyboardType keyboardType
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
		public int maxLength
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
		public bool isDelayed
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
		public char maskChar
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
		public int cursorIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreateProperty(ReadOnly = true)]
		public Vector2 cursorPosition => default(Vector2);

		[CreateProperty]
		public int selectIndex
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
		public bool selectAllOnFocus
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
		public bool selectAllOnMouseUp
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
		public bool doubleClickSelectsWord
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
		public bool tripleClickSelectsLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string text
		{
			get
			{
				return null;
			}
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			protected internal set
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
		public ScrollerVisibility verticalScrollerVisibility
		{
			get
			{
				return default(ScrollerVisibility);
			}
			set
			{
			}
		}

		private protected override bool canSwitchToMixedValue => false;

		protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBase textInputBase)
			: base((string)null)
		{
		}

		[EventInterest(new Type[]
		{
			typeof(NavigationSubmitEvent),
			typeof(FocusInEvent),
			typeof(FocusEvent),
			typeof(FocusOutEvent),
			typeof(BlurEvent)
		})]
		protected override void HandleEventBubbleUp(EventBase evt)
		{
		}

		public override void SetValueWithoutNotify(TValueType newValue)
		{
		}

		protected abstract string ValueToString(TValueType value);

		protected abstract TValueType StringToValue(string str);

		protected override void UpdateMixedValueContent()
		{
		}

		internal void OnPlaceholderChanged()
		{
		}

		internal void UpdatePlaceholderClassList(ChangeEvent<TValueType> evt = null)
		{
		}

		internal virtual void UpdateValueFromText()
		{
		}

		internal virtual void UpdateTextFromValue()
		{
		}

		private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}
	}
}
