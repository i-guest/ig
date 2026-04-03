using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[DefaultExecutionOrder(-100)]
	[AddComponentMenu("UI Toolkit/UI Document")]
	[HelpURL("UIE-get-started-with-runtime-ui")]
	public sealed class UIDocument : MonoBehaviour
	{
		public enum WorldSpaceSizeMode
		{
			Dynamic = 0,
			Fixed = 1
		}

		internal const string k_RootStyleClassName = "unity-ui-document__root";

		internal const string k_VisualElementNameSuffix = "-container";

		internal const string k_EditorElementsWarningMessage = "The VisualTreeAsset contains editor-only elements that are incompatible at runtime.\nTo fix this, remove the editor elements from the VisualTreeAsset.";

		private const int k_DefaultSortingOrder = 0;

		private static int s_CurrentUIDocumentCounter;

		internal readonly int m_UIDocumentCreationIndex;

		internal static int EnabledDocumentCount;

		[SerializeField]
		private PanelSettings m_PanelSettings;

		private PanelSettings m_PreviousPanelSettings;

		[SerializeField]
		private UIDocument m_ParentUI;

		private UIDocumentList m_ChildrenContent;

		private List<UIDocument> m_ChildrenContentCopy;

		[SerializeField]
		private VisualTreeAsset sourceAsset;

		private UIDocumentRootElement m_RootVisualElement;

		internal int softPointerCaptures;

		private int m_FirstChildInsertIndex;

		[SerializeField]
		private float m_SortingOrder;

		[SerializeField]
		private Position m_Position;

		[SerializeField]
		private WorldSpaceSizeMode m_WorldSpaceSizeMode;

		[SerializeField]
		private float m_WorldSpaceWidth;

		[SerializeField]
		private float m_WorldSpaceHeight;

		[SerializeField]
		private PivotReferenceSize m_PivotReferenceSize;

		[SerializeField]
		private Pivot m_Pivot;

		[SerializeField]
		[HideInInspector]
		private BoxCollider m_WorldSpaceCollider;

		private bool m_RootHasWorldTransform;

		public PanelSettings panelSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UIDocument parentUI
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public VisualTreeAsset visualTreeAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VisualElement rootVisualElement
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		internal VisualElementFocusRing focusRing { get; private set; }

		internal int firstChildInserIndex => 0;

		public Position position
		{
			get
			{
				return default(Position);
			}
			set
			{
			}
		}

		public WorldSpaceSizeMode worldSpaceSizeMode
		{
			get
			{
				return default(WorldSpaceSizeMode);
			}
			set
			{
			}
		}

		public Vector2 worldSpaceSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		private bool isWorldSpace => false;

		internal bool isTransformControlledByGameObject => false;

		public PivotReferenceSize pivotReferenceSize
		{
			get
			{
				return default(PivotReferenceSize);
			}
			set
			{
			}
		}

		public Pivot pivot
		{
			get
			{
				return default(Pivot);
			}
			set
			{
			}
		}

		public float sortingOrder
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public IRuntimePanel runtimePanel => null;

		internal RuntimePanel containerPanel => null;

		private float pixelsPerUnit => 0f;

		internal void ApplySortingOrder()
		{
		}

		internal static UIDocument FindRootUIDocument(VisualElement element)
		{
			return null;
		}

		private UIDocument()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void _Enable()
		{
		}

		private void LateUpdate()
		{
		}

		internal void DoUpdate()
		{
		}

		private void UpdateRenderer()
		{
		}

		private Bounds SanitizeRendererBounds(Bounds b)
		{
			return default(Bounds);
		}

		private void AddOrRemoveRendererComponent()
		{
		}

		internal void UpdateWorldSpaceCollider(ColliderUpdateMode mode)
		{
		}

		internal void RemoveWorldSpaceCollider()
		{
		}

		private static bool IsValidBounds(in Bounds b)
		{
			return false;
		}

		private void UpdateIsWorldSpaceRootFlag()
		{
		}

		private void SetTransform()
		{
		}

		private void ClearTransform()
		{
		}

		private Matrix4x4 ScaleAndFlipMatrix()
		{
			return default(Matrix4x4);
		}

		private Bounds LocalBoundsFromPivotSource()
		{
			return default(Bounds);
		}

		private Vector2 PivotOffset()
		{
			return default(Vector2);
		}

		private Matrix4x4 TransformToGameObjectMatrix()
		{
			return default(Matrix4x4);
		}

		private void ComputeTransform(Transform transform, out Matrix4x4 matrix)
		{
			matrix = default(Matrix4x4);
		}

		private static Vector2 GetPivotAsPercent(Pivot origin)
		{
			return default(Vector2);
		}

		private void SetupFromHierarchy()
		{
		}

		private UIDocument FindUIDocumentParent()
		{
			return null;
		}

		internal void Reset()
		{
		}

		internal void AddChildAndInsertContentToVisualTree(UIDocument child)
		{
		}

		private void RemoveChild(UIDocument child)
		{
		}

		private void RecreateUI()
		{
		}

		internal void SetupPosition()
		{
		}

		private void SetupRootClassList()
		{
		}

		private void SetupWorldSpaceSize()
		{
		}

		private void AddRootVisualElementToTree()
		{
		}

		private void RemoveFromHierarchy()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTransformChildrenChanged()
		{
		}

		private void OnTransformParentChanged()
		{
		}

		internal void ReactToHierarchyChanged()
		{
		}
	}
}
