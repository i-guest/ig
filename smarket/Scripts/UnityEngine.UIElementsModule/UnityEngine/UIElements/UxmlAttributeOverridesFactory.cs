using System;

namespace UnityEngine.UIElements
{
	[Obsolete("UxmlAttributeOverridesFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits>
	{
		public override string uxmlName => null;

		public override string uxmlQualifiedName => null;

		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
		{
			return null;
		}
	}
}
