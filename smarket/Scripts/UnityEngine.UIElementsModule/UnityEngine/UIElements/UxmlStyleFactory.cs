using System;

namespace UnityEngine.UIElements
{
	[Obsolete("UxmlStyleFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits>
	{
		public override string uxmlName => null;

		public override string uxmlQualifiedName => null;

		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc)
		{
			return null;
		}
	}
}
