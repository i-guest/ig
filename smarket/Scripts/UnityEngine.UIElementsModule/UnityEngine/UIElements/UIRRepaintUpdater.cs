using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	internal class UIRRepaintUpdater : BaseVisualTreeUpdater, IPanelRenderer
	{
		private BaseVisualElementPanel attachedPanel;

		internal RenderTreeManager renderTreeManager;

		private static readonly string s_Description;

		private static readonly ProfilerMarker s_ProfilerMarker;

		private bool m_ForceGammaRendering;

		private uint m_VertexBudget;

		private TextureSlotCount m_TextureSlotCount;

		public override ProfilerMarker profilerMarker => default(ProfilerMarker);

		public bool forceGammaRendering
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public uint vertexBudget
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public TextureSlotCount textureSlotCount
		{
			get
			{
				return default(TextureSlotCount);
			}
			set
			{
			}
		}

		public bool drawStats { get; }

		public bool breakBatches { get; }

		protected bool disposed { get; private set; }

		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		public override void Update()
		{
		}

		public void Render()
		{
		}

		protected virtual RenderTreeManager CreateRenderChain()
		{
			return null;
		}

		static UIRRepaintUpdater()
		{
		}

		private static void OnGraphicsResourcesRecreate(bool recreate)
		{
		}

		private void OnPanelChanged(BaseVisualElementPanel obj)
		{
		}

		private void AttachToPanel()
		{
		}

		private void DetachFromPanel()
		{
		}

		private void InitRenderChain()
		{
		}

		public void Reset()
		{
		}

		private void DestroyRenderChain()
		{
		}

		private void OnPanelIsFlatChanged()
		{
		}

		private void OnPanelAtlasChanged()
		{
		}

		private void OnPanelDrawsInCamerasChanged()
		{
		}

		private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null)
		{
		}

		private void ResetAllElementsDataRecursive(VisualElement ve)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
