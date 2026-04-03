using System;

namespace UnityEngine.UIElements
{
	[Obsolete("UxmlTemplateTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public class UxmlTemplateTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Name;

		private UxmlStringAttributeDescription m_Path;

		private UxmlStringAttributeDescription m_Src;
	}
}
