using System;

namespace UnityEngine.UIElements
{
	[Obsolete("UxmlStyleTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public class UxmlStyleTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Name;

		private UxmlStringAttributeDescription m_Path;

		private UxmlStringAttributeDescription m_Src;
	}
}
