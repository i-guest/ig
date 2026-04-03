using System;

namespace UnityEngine.UIElements
{
	[Obsolete("UxmlRootElementTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public class UxmlRootElementTraits : UxmlTraits
	{
		protected UxmlStringAttributeDescription m_Name;

		private UxmlStringAttributeDescription m_Class;
	}
}
