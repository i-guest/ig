using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule", "UnityEngine.VectorGraphicsModule" })]
	internal abstract class BaseRuntimePanel : Panel
	{
		private GameObject m_SelectableGameObject;

		private static int s_CurrentRuntimePanelCounter;

		internal readonly int m_RuntimePanelCreationIndex;

		private float m_SortingPriority;

		internal int resolvedSortingIndex;

		private bool m_DrawsInCameras;

		private float m_PixelsPerUnit;

		internal RenderTexture targetTexture;

		internal static readonly Func<Vector2, Vector3> DefaultScreenToPanelSpace;

		private Func<Vector2, Vector3> m_ScreenToPanelSpace;

		public GameObject selectableGameObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float sortingPriority
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal bool drawsInCameras
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal float pixelsPerUnit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal int targetDisplay { get; set; }

		internal int screenRenderingWidth => 0;

		internal int screenRenderingHeight => 0;

		public Func<Vector2, Vector3> screenToPanelSpace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action destroyed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal event Action drawsInCamerasChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null)
			: base(null, default(ContextType), null)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void InvokeDrawsInCamerasChanged()
		{
		}

		internal virtual void Update()
		{
		}

		internal static int getScreenRenderingHeight(int display)
		{
			return 0;
		}

		internal static int getScreenRenderingWidth(int display)
		{
			return 0;
		}

		public override void Render()
		{
		}

		internal Vector3 ScreenToPanel(Vector2 screen)
		{
			return default(Vector3);
		}

		internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector3 panelPosition, bool allowOutside = false)
		{
			panelPosition = default(Vector3);
			return false;
		}

		private void AssignPanelToComponents(BaseRuntimePanel panel)
		{
		}

		internal void PointerLeavesPanel(int pointerId)
		{
		}

		internal void PointerEntersPanel(int pointerId, Vector3 position)
		{
		}
	}
}
