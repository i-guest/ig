using System;

namespace UnityEngine.UIElements
{
	public class Box : VisualElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<Box>
		{
		}

		public static readonly string ussClassName;
	}
}
