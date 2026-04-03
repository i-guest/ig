using System;

namespace UnityEngine.UIElements
{
	[Obsolete("UxmlRootElementFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits>
	{
		public override string uxmlName => null;

		public override string uxmlQualifiedName => null;

		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
		{
			return null;
		}
	}
}
