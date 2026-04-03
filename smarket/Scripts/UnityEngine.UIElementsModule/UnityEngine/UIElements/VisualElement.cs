using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Unity.Profiling;
using Unity.Properties;
using UnityEngine.Bindings;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UIElements.Layout;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	public class VisualElement : Focusable, IResolvedStyle, IStylePropertyAnimations, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public class UxmlFactory : UxmlFactory<VisualElement, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public class UxmlTraits : UnityEngine.UIElements.UxmlTraits
		{
			protected UxmlStringAttributeDescription m_Name;

			private UxmlBoolAttributeDescription m_EnabledSelf;

			private UxmlStringAttributeDescription m_ViewDataKey;

			protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode;

			private UxmlStringAttributeDescription m_Tooltip;

			private UxmlEnumAttributeDescription<UsageHints> m_UsageHints;

			private UxmlIntAttributeDescription m_TabIndex;

			private UxmlStringAttributeDescription m_Class;

			private UxmlStringAttributeDescription m_ContentContainer;

			private UxmlStringAttributeDescription m_Style;

			private UxmlAssetAttributeDescription<Object> m_DataSource;

			private UxmlStringAttributeDescription m_DataSourcePath;

			protected UxmlIntAttributeDescription focusIndex { get; }

			protected UxmlBoolAttributeDescription focusable { get; }

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		public enum MeasureMode
		{
			Undefined = 0,
			Exactly = 1,
			AtMost = 2
		}

		public struct Hierarchy
		{
			private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation";

			private readonly VisualElement m_Owner;

			public VisualElement parent => null;

			internal List<VisualElement> children => null;

			public int childCount => 0;

			public VisualElement this[int key] => null;

			internal Hierarchy(VisualElement element)
			{
				m_Owner = null;
			}

			public void Add(VisualElement child)
			{
			}

			public void Insert(int index, VisualElement child)
			{
			}

			public void Remove(VisualElement child)
			{
			}

			public void RemoveAt(int index)
			{
			}

			public void Clear()
			{
			}

			internal void BringToFront(VisualElement child)
			{
			}

			internal void SendToBack(VisualElement child)
			{
			}

			internal void PlaceBehind(VisualElement child, VisualElement over)
			{
			}

			private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex)
			{
			}

			public int IndexOf(VisualElement element)
			{
				return 0;
			}

			public VisualElement ElementAt(int index)
			{
				return null;
			}

			public IEnumerable<VisualElement> Children()
			{
				return null;
			}

			private void SetParent(VisualElement value)
			{
			}

			private void PutChildAtIndex(VisualElement child, int index)
			{
			}

			private void RemoveChildAtIndex(int index)
			{
			}

			private void ReleaseChildList()
			{
			}

			public bool Equals(Hierarchy other)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public static bool operator ==(Hierarchy x, Hierarchy y)
			{
				return false;
			}
		}

		private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem
		{
			public TimerEventScheduler scheduler;

			private readonly EventCallback<AttachToPanelEvent> m_OnAttachToPanelCallback;

			private readonly EventCallback<DetachFromPanelEvent> m_OnDetachFromPanelCallback;

			public VisualElement element { get; private set; }

			public bool isScheduled => false;

			public bool isActive { get; private set; }

			public bool isDetaching { get; private set; }

			protected BaseVisualElementScheduledItem(VisualElement handler)
				: base(0L)
			{
			}

			private void SetActive(bool action)
			{
			}

			private void SendActivation()
			{
			}

			private void SendDeactivation()
			{
			}

			private void OnElementAttachToPanelCallback(AttachToPanelEvent evt)
			{
			}

			private void OnElementDetachFromPanelCallback(DetachFromPanelEvent evt)
			{
			}

			public IVisualElementScheduledItem StartingIn(long delayMs)
			{
				return null;
			}

			public IVisualElementScheduledItem Until(Func<bool> stopCondition)
			{
				return null;
			}

			public IVisualElementScheduledItem Every(long intervalMs)
			{
				return null;
			}

			internal override void OnItemUnscheduled()
			{
			}

			public void Resume()
			{
			}

			public void Pause()
			{
			}

			public void ExecuteLater(long delayMs)
			{
			}

			public void OnPanelActivate()
			{
			}

			public void OnPanelDeactivate()
			{
			}

			public bool CanBeActivated()
			{
				return false;
			}
		}

		private abstract class VisualElementScheduledItem<ActionType> : BaseVisualElementScheduledItem
		{
			public ActionType updateEvent;

			public VisualElementScheduledItem(VisualElement handler, ActionType upEvent)
			{
			}
		}

		private class TimerStateScheduledItem : VisualElementScheduledItem<Action<TimerState>>
		{
			public TimerStateScheduledItem(VisualElement handler, Action<TimerState> updateEvent)
			{
			}

			public override void PerformTimerUpdate(TimerState state)
			{
			}
		}

		private class SimpleScheduledItem : VisualElementScheduledItem<Action>
		{
			public SimpleScheduledItem(VisualElement handler, Action updateEvent)
			{
			}

			public override void PerformTimerUpdate(TimerState state)
			{
			}
		}

		internal class CustomStyleAccess : ICustomStyle
		{
			private Dictionary<string, StylePropertyValue> m_CustomProperties;

			private float m_DpiScaling;

			public void SetContext(Dictionary<string, StylePropertyValue> customProperties, float dpiScaling)
			{
			}

			public bool TryGetValue(CustomStyleProperty<float> property, out float value)
			{
				value = default(float);
				return false;
			}

			public bool TryGetValue(CustomStyleProperty<int> property, out int value)
			{
				value = default(int);
				return false;
			}

			public bool TryGetValue(CustomStyleProperty<Color> property, out Color value)
			{
				value = default(Color);
				return false;
			}

			public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value)
			{
				value = null;
				return false;
			}

			public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value)
			{
				value = null;
				return false;
			}

			public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value)
			{
				value = null;
				return false;
			}

			public bool TryGetValue(CustomStyleProperty<string> property, out string value)
			{
				value = null;
				return false;
			}

			private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp)
			{
				customProp = default(StylePropertyValue);
				return false;
			}

			private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp)
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule" })]
		internal class TypeData
		{
			private string m_FullTypeName;

			private string m_TypeName;

			public Type type { get; }

			public string fullTypeName => null;

			public string typeName => null;

			public TypeData(Type type)
			{
			}
		}

		internal static uint s_NextId;

		private static List<string> s_EmptyClassList;

		internal static readonly PropertyName userDataPropertyKey;

		public static readonly string disabledUssClassName;

		private string m_Name;

		private List<string> m_ClassList;

		private Dictionary<PropertyName, object> m_PropertyBag;

		private VisualElementFlags m_Flags;

		private string m_ViewDataKey;

		private RenderHints m_RenderHints;

		internal Rect lastLayout;

		internal Rect lastPseudoPadding;

		internal RenderData renderData;

		internal RenderData nestedRenderData;

		internal int hierarchyDepth;

		internal int insertionIndex;

		private Rect m_Layout;

		private Rect m_BoundingBox;

		private const VisualElementFlags worldBoundingBoxDirtyDependencies = VisualElementFlags.WorldTransformDirty | VisualElementFlags.BoundingBoxDirty | VisualElementFlags.WorldBoundingBoxDirty;

		private Rect m_WorldBoundingBox;

		private const VisualElementFlags worldTransformInverseDirtyDependencies = VisualElementFlags.WorldTransformDirty | VisualElementFlags.WorldTransformInverseDirty;

		private Matrix4x4 m_WorldTransformCache;

		private Matrix4x4 m_WorldTransformInverseCache;

		internal PseudoStates triggerPseudoMask;

		internal PseudoStates dependencyPseudoMask;

		private PseudoStates m_PseudoStates;

		private PickingMode m_PickingMode;

		private LayoutNode m_LayoutNode;

		internal ComputedStyle m_Style;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StyleVariableContext variableContext;

		internal int inheritedStylesHash;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule" })]
		internal readonly uint controlid;

		internal int imguiContainerDescendantCount;

		internal static int s_FinalizerCount;

		private bool m_EnabledSelf;

		private LanguageDirection m_LanguageDirection;

		private LanguageDirection m_LocalLanguageDirection;

		private static readonly ProfilerMarker k_GenerateVisualContentMarker;

		private List<IValueAnimationUpdate> m_RunningAnimations;

		internal static readonly BindingId childCountProperty;

		internal static readonly BindingId contentRectProperty;

		internal static readonly BindingId dataSourcePathProperty;

		internal static readonly BindingId dataSourceProperty;

		internal static readonly BindingId disablePlayModeTintProperty;

		internal static readonly BindingId enabledInHierarchyProperty;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule" })]
		internal static readonly BindingId enabledSelfProperty;

		internal static readonly BindingId layoutProperty;

		internal static readonly BindingId languageDirectionProperty;

		internal static readonly BindingId localBoundProperty;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule" })]
		internal static readonly BindingId nameProperty;

		internal static readonly BindingId panelProperty;

		internal static readonly BindingId pickingModeProperty;

		internal static readonly BindingId styleSheetsProperty;

		internal static readonly BindingId tooltipProperty;

		internal static readonly BindingId usageHintsProperty;

		internal static readonly BindingId userDataProperty;

		internal static readonly BindingId viewDataKeyProperty;

		internal static readonly BindingId visibleProperty;

		internal static readonly BindingId visualTreeAssetSourceProperty;

		internal static readonly BindingId worldBoundProperty;

		internal static readonly BindingId worldTransformProperty;

		private object m_DataSource;

		private PathRef m_DataSourcePath;

		private List<Binding> m_Bindings;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Type _003CdataSourceType_003Ek__BackingField;

		private readonly int m_TrickleDownHandleEventCategories;

		private readonly int m_BubbleUpHandleEventCategories;

		private int m_BubbleUpEventCallbackCategories;

		private int m_TrickleDownEventCallbackCategories;

		private int m_EventInterestSelfCategories;

		private int m_CachedEventInterestParentCategories;

		private static uint s_NextParentVersion;

		private uint m_NextParentCachedVersion;

		private uint m_NextParentRequiredVersion;

		private VisualElement m_CachedNextParentWithEventInterests;

		private const string k_VisualElementAssetPropertyName = "--unity-visual-element-asset-property";

		private const string k_LinkedTemplateAssetOwnerPropertyName = "--unity-linked-template-asset-owner";

		internal const string k_RootVisualContainerName = "rootVisualContainer";

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _003CcacheAsBitmap_003Ek__BackingField;

		private VisualElement m_PhysicalParent;

		private VisualElement m_LogicalParent;

		private static readonly List<VisualElement> s_EmptyList;

		private List<VisualElement> m_Children;

		private VisualTreeAsset m_VisualTreeAssetSource;

		internal static CustomStyleAccess s_CustomStyleAccess;

		internal InlineStyleAccess inlineStyleAccess;

		internal ResolvedStyleAccess resolvedStyleAccess;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal List<StyleSheet> styleSheetList;

		private static readonly Regex s_InternalStyleSheetPath;

		internal static readonly PropertyName tooltipPropertyKey;

		private static readonly Dictionary<Type, TypeData> s_TypeData;

		private TypeData m_TypeData;

		Align IResolvedStyle.alignContent => default(Align);

		Align IResolvedStyle.alignItems => default(Align);

		Align IResolvedStyle.alignSelf => default(Align);

		Ratio IResolvedStyle.aspectRatio => default(Ratio);

		Color IResolvedStyle.backgroundColor => default(Color);

		Background IResolvedStyle.backgroundImage => default(Background);

		BackgroundPosition IResolvedStyle.backgroundPositionX => default(BackgroundPosition);

		BackgroundPosition IResolvedStyle.backgroundPositionY => default(BackgroundPosition);

		BackgroundRepeat IResolvedStyle.backgroundRepeat => default(BackgroundRepeat);

		BackgroundSize IResolvedStyle.backgroundSize => default(BackgroundSize);

		Color IResolvedStyle.borderBottomColor => default(Color);

		float IResolvedStyle.borderBottomLeftRadius => 0f;

		float IResolvedStyle.borderBottomRightRadius => 0f;

		float IResolvedStyle.borderBottomWidth => 0f;

		Color IResolvedStyle.borderLeftColor => default(Color);

		float IResolvedStyle.borderLeftWidth => 0f;

		Color IResolvedStyle.borderRightColor => default(Color);

		float IResolvedStyle.borderRightWidth => 0f;

		Color IResolvedStyle.borderTopColor => default(Color);

		float IResolvedStyle.borderTopLeftRadius => 0f;

		float IResolvedStyle.borderTopRightRadius => 0f;

		float IResolvedStyle.borderTopWidth => 0f;

		float IResolvedStyle.bottom => 0f;

		Color IResolvedStyle.color => default(Color);

		DisplayStyle IResolvedStyle.display => default(DisplayStyle);

		IEnumerable<FilterFunction> IResolvedStyle.filter => null;

		StyleFloat IResolvedStyle.flexBasis => default(StyleFloat);

		FlexDirection IResolvedStyle.flexDirection => default(FlexDirection);

		float IResolvedStyle.flexGrow => 0f;

		float IResolvedStyle.flexShrink => 0f;

		Wrap IResolvedStyle.flexWrap => default(Wrap);

		float IResolvedStyle.fontSize => 0f;

		float IResolvedStyle.height => 0f;

		Justify IResolvedStyle.justifyContent => default(Justify);

		float IResolvedStyle.left => 0f;

		float IResolvedStyle.letterSpacing => 0f;

		float IResolvedStyle.marginBottom => 0f;

		float IResolvedStyle.marginLeft => 0f;

		float IResolvedStyle.marginRight => 0f;

		float IResolvedStyle.marginTop => 0f;

		StyleFloat IResolvedStyle.maxHeight => default(StyleFloat);

		StyleFloat IResolvedStyle.maxWidth => default(StyleFloat);

		StyleFloat IResolvedStyle.minHeight => default(StyleFloat);

		StyleFloat IResolvedStyle.minWidth => default(StyleFloat);

		float IResolvedStyle.opacity => 0f;

		float IResolvedStyle.paddingBottom => 0f;

		float IResolvedStyle.paddingLeft => 0f;

		float IResolvedStyle.paddingRight => 0f;

		float IResolvedStyle.paddingTop => 0f;

		Position IResolvedStyle.position => default(Position);

		float IResolvedStyle.right => 0f;

		Rotate IResolvedStyle.rotate => default(Rotate);

		Scale IResolvedStyle.scale => default(Scale);

		TextOverflow IResolvedStyle.textOverflow => default(TextOverflow);

		float IResolvedStyle.top => 0f;

		Vector3 IResolvedStyle.transformOrigin => default(Vector3);

		IEnumerable<TimeValue> IResolvedStyle.transitionDelay => null;

		IEnumerable<TimeValue> IResolvedStyle.transitionDuration => null;

		IEnumerable<StylePropertyName> IResolvedStyle.transitionProperty => null;

		IEnumerable<EasingFunction> IResolvedStyle.transitionTimingFunction => null;

		Vector3 IResolvedStyle.translate => default(Vector3);

		Color IResolvedStyle.unityBackgroundImageTintColor => default(Color);

		EditorTextRenderingMode IResolvedStyle.unityEditorTextRenderingMode => default(EditorTextRenderingMode);

		Font IResolvedStyle.unityFont => null;

		FontDefinition IResolvedStyle.unityFontDefinition => default(FontDefinition);

		FontStyle IResolvedStyle.unityFontStyleAndWeight => default(FontStyle);

		MaterialDefinition IResolvedStyle.unityMaterial => default(MaterialDefinition);

		float IResolvedStyle.unityParagraphSpacing => 0f;

		int IResolvedStyle.unitySliceBottom => 0;

		int IResolvedStyle.unitySliceLeft => 0;

		int IResolvedStyle.unitySliceRight => 0;

		float IResolvedStyle.unitySliceScale => 0f;

		int IResolvedStyle.unitySliceTop => 0;

		SliceType IResolvedStyle.unitySliceType => default(SliceType);

		TextAnchor IResolvedStyle.unityTextAlign => default(TextAnchor);

		TextGeneratorType IResolvedStyle.unityTextGenerator => default(TextGeneratorType);

		Color IResolvedStyle.unityTextOutlineColor => default(Color);

		float IResolvedStyle.unityTextOutlineWidth => 0f;

		TextOverflowPosition IResolvedStyle.unityTextOverflowPosition => default(TextOverflowPosition);

		Visibility IResolvedStyle.visibility => default(Visibility);

		WhiteSpace IResolvedStyle.whiteSpace => default(WhiteSpace);

		float IResolvedStyle.width => 0f;

		float IResolvedStyle.wordSpacing => 0f;

		internal bool hasRunningAnimations => false;

		internal bool hasCompletedAnimations => false;

		int IStylePropertyAnimations.runningAnimationCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		int IStylePropertyAnimations.completedAnimationCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal IStylePropertyAnimations styleAnimation => null;

		internal bool isCompositeRoot
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool areAncestorsAndSelfDisplayed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool hasOneOrMorePointerCaptures
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal VisualElementFlags flags
		{
			get
			{
				return default(VisualElementFlags);
			}
			set
			{
			}
		}

		[CreateProperty]
		public string viewDataKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool enableViewDataPersistence => false;

		[CreateProperty]
		public object userData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool canGrabFocus => false;

		public override FocusController focusController => null;

		[CreateProperty]
		public bool disablePlayModeTint
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal Color playModeTintColor => default(Color);

		[CreateProperty]
		public UsageHints usageHints
		{
			get
			{
				return default(UsageHints);
			}
			set
			{
			}
		}

		internal RenderHints renderHints
		{
			get
			{
				return default(RenderHints);
			}
			set
			{
			}
		}

		internal bool useRenderTexture => false;

		internal bool isLayoutManual
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public float scaledPixelsPerPoint => 0f;

		[Obsolete("scaledPixelsPerPoint_noChecks is deprecated. Use scaledPixelsPerPoint instead.")]
		internal float scaledPixelsPerPoint_noChecks => 0f;

		[CreateProperty(ReadOnly = true)]
		public Rect layout
		{
			get
			{
				return default(Rect);
			}
			internal set
			{
			}
		}

		[CreateProperty(ReadOnly = true)]
		public Rect contentRect => default(Rect);

		protected Rect paddingRect => default(Rect);

		internal bool needs3DBounds
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool isLocalBounds3DDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool isLocalBoundsWithoutNested3DDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool isBoundingBoxDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool isWorldBoundingBoxDirty
		{
			set
			{
			}
		}

		internal bool isWorldBoundingBoxOrDependenciesDirty => false;

		internal Rect boundingBox => default(Rect);

		internal Rect boundingBoxWithoutNested => default(Rect);

		internal Rect worldBoundingBox => default(Rect);

		private Rect boundingBoxInParentSpace => default(Rect);

		internal Bounds localBounds3D => default(Bounds);

		internal Bounds localBoundsPicking3D => default(Bounds);

		internal Bounds localBounds3DWithoutNested3D => default(Bounds);

		[CreateProperty(ReadOnly = true)]
		public Rect worldBound => default(Rect);

		[CreateProperty(ReadOnly = true)]
		public Rect localBound => default(Rect);

		internal Rect rect
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return default(Rect);
			}
		}

		internal bool isWorldSpaceRootUIDocument
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		internal bool isWorldTransformDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool isWorldTransformInverseDirty
		{
			set
			{
			}
		}

		internal bool isWorldTransformInverseOrDependenciesDirty => false;

		[CreateProperty(ReadOnly = true)]
		public Matrix4x4 worldTransform => default(Matrix4x4);

		internal ref Matrix4x4 worldTransformRef
		{
			get
			{
				throw null;
			}
		}

		internal ref Matrix4x4 worldTransformInverse
		{
			get
			{
				throw null;
			}
		}

		internal Rect worldClip
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return default(Rect);
			}
		}

		internal bool receivesHierarchyGeometryChangedEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool boundingBoxDirtiedSinceLastLayoutPass
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal PseudoStates pseudoStates
		{
			get
			{
				return default(PseudoStates);
			}
			set
			{
			}
		}

		internal int containedPointerIds { get; set; }

		[CreateProperty]
		public PickingMode pickingMode
		{
			get
			{
				return default(PickingMode);
			}
			set
			{
			}
		}

		[CreateProperty]
		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal List<string> classList
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		internal string fullTypeName
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		internal string typeName
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule" })]
			get
			{
				return null;
			}
		}

		internal ref LayoutNode layoutNode
		{
			get
			{
				throw null;
			}
		}

		internal ref ComputedStyle computedStyle
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				throw null;
			}
		}

		internal bool hasInlineStyle => false;

		internal bool styleInitialized
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool isParentEnabledInHierarchy => false;

		[CreateProperty(ReadOnly = true)]
		public bool enabledInHierarchy => false;

		[CreateProperty]
		public bool enabledSelf
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
		public LanguageDirection languageDirection
		{
			get
			{
				return default(LanguageDirection);
			}
			set
			{
			}
		}

		internal LanguageDirection localLanguageDirection
		{
			get
			{
				return default(LanguageDirection);
			}
			set
			{
			}
		}

		[CreateProperty]
		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Action<MeshGenerationContext> generateVisualContent { get; set; }

		internal bool requireMeasureFunction
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
		public object dataSource
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
		public PropertyPath dataSourcePath
		{
			get
			{
				return default(PropertyPath);
			}
			set
			{
			}
		}

		internal bool isDataSourcePathEmpty => false;

		internal VisualElement nextParentWithEventInterests => null;

		internal int eventInterestParentCategories => 0;

		internal bool isEventInterestParentCategoriesDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IExperimentalFeatures experimental => null;

		ITransitionAnimations IExperimentalFeatures.animation => null;

		public Hierarchy hierarchy { get; }

		internal bool isRootVisualContainer => false;

		internal bool disableClipping
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool disableRendering
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public VisualElement parent => null;

		internal BaseVisualElementPanel elementPanel
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get;
			private set; }

		[CreateProperty(ReadOnly = true)]
		public IPanel panel => null;

		public virtual VisualElement contentContainer => null;

		[CreateProperty(ReadOnly = true)]
		public VisualTreeAsset visualTreeAssetSource
		{
			get
			{
				return null;
			}
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			internal set
			{
			}
		}

		public VisualElement this[int key] => null;

		[CreateProperty(ReadOnly = true)]
		public int childCount => 0;

		private Vector3 positionWithLayout => default(Vector3);

		internal bool hasDefaultRotationAndScale
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		internal bool has3DTransform => false;

		private bool has3DTranslation => false;

		private bool has3DRotation => false;

		public IVisualElementScheduler schedule => null;

		[CreateProperty]
		public IStyle style => null;

		[CreateProperty]
		public IResolvedStyle resolvedStyle => null;

		public ICustomStyle customStyle => null;

		[CreateProperty(ReadOnly = true)]
		public VisualElementStyleSheetSet styleSheets => default(VisualElementStyleSheetSet);

		[CreateProperty]
		public string tooltip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private TypeData typeData => null;

		private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem()
		{
			return null;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, Ratio from, Ratio to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, List<FilterFunction> from, List<FilterFunction> to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		bool IStylePropertyAnimations.Start(StylePropertyId id, MaterialDefinition from, MaterialDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return false;
		}

		void IStylePropertyAnimations.CancelAnimation(StylePropertyId id)
		{
		}

		void IStylePropertyAnimations.CancelAllAnimations()
		{
		}

		void IStylePropertyAnimations.UpdateAnimation(StylePropertyId id)
		{
		}

		void IStylePropertyAnimations.GetAllAnimations(List<StylePropertyId> outPropertyIds)
		{
		}

		internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0)
		{
			return false;
		}

		internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to)
		{
			return false;
		}

		internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to)
		{
			return false;
		}

		internal bool TryConvertBackgroundSizeUnits(ref BackgroundSize from, ref BackgroundSize to)
		{
			return false;
		}

		private float? GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0)
		{
			return null;
		}

		internal void MarkRenderHintsClean()
		{
		}

		internal void ClearManualLayout()
		{
		}

		internal void UpdateBoundingBox()
		{
		}

		internal void UpdateWorldBoundingBox()
		{
		}

		private void UpdateBounds3D()
		{
		}

		internal void UpdateWorldTransform()
		{
		}

		internal void UpdateWorldTransformInverse()
		{
		}

		internal void EnsureWorldTransformAndClipUpToDate()
		{
		}

		internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat)
		{
			return default(Rect);
		}

		public void SetActivePseudoState(bool value)
		{
		}

		public void SetCheckedPseudoState(bool value)
		{
		}

		internal void UpdateHoverPseudoState()
		{
		}

		private static bool IsPartOfCapturedChain(VisualElement self, in IEventHandler capturingElement)
		{
			return false;
		}

		internal void UpdateHoverPseudoStateAfterCaptureChange(int pointerId)
		{
		}

		internal void UpdatePointerCaptureFlag()
		{
		}

		private void ChangeIMGUIContainerCount(int delta)
		{
		}

		~VisualElement()
		{
		}

		internal void SetTooltip(TooltipEvent e)
		{
		}

		public sealed override void Focus()
		{
		}

		internal long TimeSinceStartupMs()
		{
			return 0L;
		}

		internal void SetPanel(BaseVisualElementPanel p)
		{
		}

		private void WillChangePanel(BaseVisualElementPanel destinationPanel)
		{
		}

		private void HasChangedPanel(BaseVisualElementPanel prevPanel)
		{
		}

		public sealed override void SendEvent(EventBase e)
		{
		}

		internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void IncrementVersion(VersionChangeType changeType)
		{
		}

		internal void InvokeHierarchyChanged(HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null)
		{
		}

		private bool SetEnabledFromHierarchyPrivate(bool state)
		{
			return false;
		}

		public void SetEnabled(bool value)
		{
		}

		private void PropagateEnabledToChildren(bool value)
		{
		}

		public void MarkDirtyRepaint()
		{
		}

		internal void InvokeGenerateVisualContent(MeshGenerationContext mgc)
		{
		}

		internal void GetFullHierarchicalViewDataKey(StringBuilder key)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal string GetFullHierarchicalViewDataKey()
		{
			return null;
		}

		internal T GetOrCreateViewData<T>(object existing, string key) where T : class, new()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void OverwriteFromViewData(object obj, string key)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void SaveViewData()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal virtual void OnViewDataReady()
		{
		}

		public virtual bool ContainsPoint(Vector2 localPoint)
		{
			return false;
		}

		private void AssignMeasureFunction()
		{
		}

		private void RemoveMeasureFunction()
		{
		}

		protected internal virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
		{
			return default(Vector2);
		}

		internal static void Measure(VisualElement ve, ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result)
		{
			result = default(LayoutSize);
		}

		private void FinalizeLayout()
		{
		}

		internal void SetInlineRule(StyleSheet sheet, StyleRule rule)
		{
		}

		internal void SetComputedStyle(ref ComputedStyle newStyle)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal List<string> GetClassesForIteration()
		{
			return null;
		}

		public void AddToClassList(string className)
		{
		}

		public void RemoveFromClassList(string className)
		{
		}

		public void EnableInClassList(string className, bool enable)
		{
		}

		public bool ClassListContains(string cls)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule" })]
		internal object GetProperty(PropertyName key)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule" })]
		internal void SetProperty(PropertyName key, object value)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule" })]
		internal bool HasProperty(PropertyName key)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule" })]
		internal bool ClearProperty(PropertyName key)
		{
			return false;
		}

		private static void CheckUserKeyArgument(PropertyName key)
		{
		}

		private void SetPropertyInternal(PropertyName key, object value)
		{
		}

		internal void UpdateCursorStyle(long eventType)
		{
		}

		private VisualElementAnimationSystem GetAnimationSystem()
		{
			return null;
		}

		internal void RegisterAnimation(IValueAnimationUpdate anim)
		{
		}

		internal void UnregisterAnimation(IValueAnimationUpdate anim)
		{
		}

		private void UnregisterRunningAnimations()
		{
		}

		private void RegisterRunningAnimations()
		{
		}

		private static ValueAnimation<T> StartAnimation<T>(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged)
		{
			return null;
		}

		private static void AssignStyleValues(VisualElement ve, StyleValues src)
		{
		}

		private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead)
		{
			return default(StyleValues);
		}

		ValueAnimation<StyleValues> ITransitionAnimations.Start(StyleValues to, int durationMs)
		{
			return null;
		}

		private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs)
		{
			return null;
		}

		public bool TryGetBinding(BindingId bindingId, out Binding binding)
		{
			binding = null;
			return false;
		}

		private void ProcessBindingRequests()
		{
		}

		private void CreateBindingRequests()
		{
		}

		private void TrackSource(object previous, object current)
		{
		}

		private void DetachDataSource()
		{
		}

		private void AttachDataSource()
		{
		}

		private void DirtyNextParentWithEventInterests()
		{
		}

		internal void SetAsNextParentWithEventInterests()
		{
		}

		internal bool GetCachedNextParentWithEventInterests(out VisualElement nextParent)
		{
			nextParent = null;
			return false;
		}

		private void PropagateCachedNextParentWithEventInterests(VisualElement nextParent, VisualElement stopParent)
		{
		}

		internal void AddEventCallbackCategories(int eventCategories, TrickleDown trickleDown)
		{
		}

		private void UpdateEventInterestSelfCategories()
		{
		}

		private void UpdateEventInterestParentCategories()
		{
		}

		internal bool HasParentEventInterests(EventCategory eventCategory)
		{
			return false;
		}

		internal bool HasParentEventInterests(int eventCategories)
		{
			return false;
		}

		internal bool HasSelfEventInterests(EventCategory eventCategory)
		{
			return false;
		}

		internal bool HasSelfEventInterests(int eventCategories)
		{
			return false;
		}

		internal bool HasTrickleDownEventInterests(int eventCategories)
		{
			return false;
		}

		internal bool HasBubbleUpEventInterests(int eventCategories)
		{
			return false;
		}

		internal bool HasTrickleDownEventCallbacks(int eventCategories)
		{
			return false;
		}

		internal bool HasBubbleUpEventCallbacks(int eventCategories)
		{
			return false;
		}

		internal bool HasTrickleDownHandleEvent(int eventCategories)
		{
			return false;
		}

		internal bool HasBubbleUpHandleEvent(int eventCategories)
		{
			return false;
		}

		internal bool ShouldClip()
		{
			return false;
		}

		public void Add(VisualElement child)
		{
		}

		internal void Add(VisualElement child, bool ignoreContentContainer)
		{
		}

		public void Insert(int index, VisualElement element)
		{
		}

		internal void Insert(int index, VisualElement element, bool ignoreContentContainer)
		{
		}

		public void Remove(VisualElement element)
		{
		}

		public void Clear()
		{
		}

		public VisualElement ElementAt(int index)
		{
			return null;
		}

		internal int ChildCount(bool ignoreContentContainer)
		{
			return 0;
		}

		public int IndexOf(VisualElement element)
		{
			return 0;
		}

		internal int IndexOf(VisualElement element, bool ignoreContentContainer)
		{
			return 0;
		}

		internal VisualElement ElementAtTreePath(List<int> childIndexes)
		{
			return null;
		}

		internal bool FindElementInTree(VisualElement element, List<int> outChildIndexes)
		{
			return false;
		}

		public IEnumerable<VisualElement> Children()
		{
			return null;
		}

		public void BringToFront()
		{
		}

		public void SendToBack()
		{
		}

		public void PlaceBehind(VisualElement sibling)
		{
		}

		internal virtual void OnChildAdded(VisualElement child)
		{
		}

		internal virtual void OnChildRemoved(VisualElement child)
		{
		}

		public void RemoveFromHierarchy()
		{
		}

		public T GetFirstOfType<T>() where T : class
		{
			return null;
		}

		public T GetFirstAncestorOfType<T>() where T : class
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule" })]
		internal VisualElement GetFirstAncestorWhere(Predicate<VisualElement> predicate)
		{
			return null;
		}

		public bool Contains(VisualElement child)
		{
			return false;
		}

		private void GatherAllChildren(List<VisualElement> elements)
		{
		}

		public VisualElement FindCommonAncestor(VisualElement other)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal VisualElement GetRootVisualContainer(bool stopAtNearestRoot = false)
		{
			return null;
		}

		internal VisualElement GetNextElementDepthFirst()
		{
			return null;
		}

		internal VisualElement GetPreviousElementDepthFirst()
		{
			return null;
		}

		internal VisualElement RetargetElement(VisualElement retargetAgainst)
		{
			return null;
		}

		internal void GetPivotedMatrixWithLayout(out Matrix4x4 result)
		{
			result = default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float Min(float a, float b, float c, float d)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float Max(float a, float b, float c, float d)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TransformAlignedBoundsToParentSpace(ref Bounds bounds)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void TransformAlignedRectToParentSpace(ref Rect rect)
		{
		}

		internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect)
		{
			return default(Rect);
		}

		internal static Bounds CalculateConservativeBounds(ref Matrix4x4 matrix, Bounds bounds)
		{
			return default(Bounds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void TransformAlignedBounds(ref Matrix4x4 matrix, ref Bounds bounds)
		{
		}

		internal static void OrderMinMaxRect(ref Rect rect)
		{
		}

		internal static void OrderMinMaxBounds(ref Bounds bounds)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point)
		{
			return default(Vector2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector3 MultiplyMatrix44Point2ToPoint3(ref Matrix4x4 lhs, Vector2 point)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector2 MultiplyMatrix44Point3ToPoint2(ref Matrix4x4 lhs, Vector3 point)
		{
			return default(Vector2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector)
		{
			return default(Vector2);
		}

		internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res)
		{
			res = default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res)
		{
			res = default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs)
		{
		}

		IVisualElementScheduledItem IVisualElementScheduler.Execute(Action<TimerState> timerUpdateEvent)
		{
			return null;
		}

		IVisualElementScheduledItem IVisualElementScheduler.Execute(Action updateEvent)
		{
			return null;
		}

		internal void AddStyleSheetPath(string sheetPath)
		{
		}

		internal StyleFloat ResolveLengthValue(Length length, bool isRow)
		{
			return default(StyleFloat);
		}

		internal Vector3 ResolveTranslate()
		{
			return default(Vector3);
		}

		internal Vector3 ResolveTransformOrigin()
		{
			return default(Vector3);
		}

		private Quaternion ResolveRotation()
		{
			return default(Quaternion);
		}

		private Vector3 ResolveScale()
		{
			return default(Vector3);
		}
	}
}
