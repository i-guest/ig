using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule" })]
	internal class UIDocumentRootElement : TemplateContainer
	{
		public readonly UIDocument document;

		internal UIRenderer uiRenderer { get; set; }

		public UIDocumentRootElement(UIDocument document, VisualTreeAsset sourceAsset)
		{
		}
	}
}
