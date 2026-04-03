namespace UnityEngine.UIElements
{
	internal class VisualTreeWorldSpaceHierarchyFlagsUpdater : VisualTreeHierarchyFlagsUpdater
	{
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		private static VisualElementFlags GetParentMustDirtyFlags(VisualElement ve)
		{
			return default(VisualElementFlags);
		}

		private static void DirtyBoundingBoxHierarchy(VisualElement ve)
		{
		}

		private static void DirtyParentHierarchy(VisualElement ve, VisualElementFlags flags)
		{
		}

		public override void Update()
		{
		}
	}
}
